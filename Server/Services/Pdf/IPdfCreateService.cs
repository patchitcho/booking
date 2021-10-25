using Proxima.Shared;
using System.Collections.Generic;

namespace Proxima.Server.Services.Pdf
{
    public interface IPdfCreateService
    {
        public ReportResult ExportPdf<T>(IEnumerable<T> list, string title);
    }
}
