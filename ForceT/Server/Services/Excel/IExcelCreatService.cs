using ForceT.Shared;
using System.Collections.Generic;

namespace ForceT.Server.Services.Excel
{
    public interface IExcelCreatService
    {
        public ReportResult ExportExcel<T>(IEnumerable<T> list, string title);
    }
}
