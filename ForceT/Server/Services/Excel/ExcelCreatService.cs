using ForceT.Shared;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace ForceT.Server.Services.Excel
{
    public class ExcelCreatService : IExcelCreatService
    {
        public ReportResult ExportExcel<T>(IEnumerable<T> list, string title)
        {
            MemoryStream stream = new MemoryStream();
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

            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add(title);

                workSheet.Row(1).Height = 20;
                workSheet.Row(1).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                workSheet.Row(1).Style.Font.Size = 14;
                workSheet.Cells[1, 1, 1, 2].Merge = true;
                workSheet.Cells[1, 1, 1, 2].AutoFitColumns();

                workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Row(1).Style.Font.Bold = true;
                workSheet.Cells[1, 1, 1, 2].Value = title;
                workSheet.Cells[1, 1, 1, 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
                workSheet.Cells[1, 1, 1, 2].Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
                workSheet.Row(3).Style.Font.Bold = true;
                workSheet.Row(3).Style.Font.Size = 12;

                int titleIndex = 1;
                int recordIndex = 4;
                foreach (var item in props)
                {
                    workSheet.Cells[3, titleIndex].Value = item.ToString();
                    titleIndex++;
                }
                titleIndex = 1;
                foreach (var item in brutprops)
                {
                    recordIndex = 4;
                    foreach (var obj in list)
                    {
                        workSheet.Cells[recordIndex, titleIndex].Value = obj.GetType().GetProperty(item.ToString()).GetValue(obj, null).ToString();
                        recordIndex++;
                    }
                    titleIndex++;
                }

                workSheet.Cells[3, 1, 3, titleIndex - 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                workSheet.Cells[3, 1, 3, titleIndex - 1].Style.Fill.BackgroundColor.SetColor(Color.LightGreen);
                var r = workSheet.Cells[3, 1, recordIndex - 1, titleIndex - 1];
                r.Style.Border.Top.Style = ExcelBorderStyle.Dotted;
                r.Style.Border.Right.Style = ExcelBorderStyle.Dotted;
                r.Style.Border.Bottom.Style = ExcelBorderStyle.Dotted;
                r.Style.Border.Left.Style = ExcelBorderStyle.Dotted;
                r.Style.Locked = false;
                r.Style.Hidden = false;
                r.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                package.Save();
            }
            return new ReportResult { result = "Ok", stream = stream.ToArray() };
        }
    }
}
