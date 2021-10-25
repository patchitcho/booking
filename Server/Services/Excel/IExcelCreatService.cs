using Proxima.Shared;
using System.Collections.Generic;

namespace Proxima.Server.Services.Excel
{
    public interface IExcelCreatService
    {
        public ReportResult ExportExcel<T>(IEnumerable<T> list, string title);
    }
}
