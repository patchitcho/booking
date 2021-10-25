using DinkToPdf;
using DinkToPdf.Contracts;
using Proxima.Shared;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Proxima.Server.Services.Pdf
{
    public class PdfCreateService : IPdfCreateService
    {
        private readonly IConverter _converter;
        public PdfCreateService(IConverter Converter)
        {
            _converter = Converter;
        }
        public ReportResult ExportPdf<T>(IEnumerable<T> list, string title)
        {
            List<string> brutprops = typeof(T).GetProperties().Select(a => a.Name).ToList();
            List<string> props = new List<string>();
            foreach (var item in brutprops)
            {
                string[] str = item.Split("_");
                if (str != null)
                {
                    var correctkeyword = new StringBuilder();
                    foreach (var chars in str)
                    {
                        correctkeyword.Append(chars + @" ");
                    }
                    props.Add(correctkeyword.ToString());
                }
                else
                {
                    props.Add(item);
                }
            }

            var sb = new StringBuilder();
            sb.AppendFormat(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>{0}</h1></div>
                                <table class='table table-bordered table-responsive-xl' align='center'>
                                    <thead class='thead-light'>
                                        <tr style='line-height:40px'>", title);
            foreach (var item in props)
            {
                sb.AppendFormat(@"<th style='width:{0}%'>{1}</th>", 100 / (props.Count), item);
            }
            sb.Append(@"</tr>
                        </thead>");
            foreach (var eng in list)
            {
                sb.Append(@"<tr align='center' style='line-height:35px'>");
                foreach (var item in brutprops)
                {
                    sb.AppendFormat(@"<td>{0}</td>", eng.GetType().GetProperty(item).GetValue(eng, null).ToString());
                }
                sb.Append(@"</tr>");
            }
            sb.Append(@"
                                </table>
                            </body>
                        </html>");
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                ViewportSize = "1920x1080",
                DPI = 300
            };
            if (props.Count > 6)
            {
                globalSettings.Orientation = Orientation.Landscape;
            }
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = sb.ToString(),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "bootstrap", "bootstrap.min.css") },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] de [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Force tracking" },
                UseLocalLinks = false,
                UseExternalLinks = false,
                ProduceForms = false,
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            byte[] bytes = _converter.Convert(pdf);
            return new ReportResult { result = "Ok", stream = bytes };
        }
    }
}

