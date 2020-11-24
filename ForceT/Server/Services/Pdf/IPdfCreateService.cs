using ForceT.Shared;
using System.Collections.Generic;

namespace ForceT.Server.Services.Pdf
{
    public interface IPdfCreateService
    {
        public ReportResult ExportPdf<T>(IEnumerable<T> list, string title);
    }
}
