using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpUserproduit
    {
        public Guid? UsrprdUidf { get; set; }
        public int UsrprdIdf { get; set; }
        public string UsrprdCode { get; set; }
        public string UsrprdLib { get; set; }
        public int? ProdIdf { get; set; }
        public int? UsrIdf { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpProduit ProdIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual TabpSysUser UsrIdfNavigation { get; set; }
    }
}
