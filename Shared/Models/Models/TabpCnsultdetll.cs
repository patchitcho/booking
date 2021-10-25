using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpCnsultdetll
    {
        public Guid? CnsudtlUidf { get; set; }
        public int CnsudtlIdf { get; set; }
        public string CnsudtlCode { get; set; }
        public string CnsudtlLib { get; set; }
        public int? CnsudtlDure { get; set; }
        public string CnsudtlPosologie { get; set; }
        public int? ProdIdf { get; set; }
        public int? CnsltIdf { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpConsultation CnsltIdfNavigation { get; set; }
        public virtual TabpProduit ProdIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
    }
}
