using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpAntcdntspaten
    {
        public Guid? AntcptnUidf { get; set; }
        public int AntcptnIdf { get; set; }
        public string AntcptnCode { get; set; }
        public string AntcptnLib { get; set; }
        public string AntcptnComnt { get; set; }
        public int? PtienIdf { get; set; }
        public int? AntcdnIdf { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpAntecedent AntcdnIdfNavigation { get; set; }
        public virtual TabpPatient PtienIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
    }
}
