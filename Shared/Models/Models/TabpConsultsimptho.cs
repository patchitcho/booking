using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpConsultsimptho
    {
        public Guid? CnsltsimpthUidf { get; set; }
        public int CnsltsimpthIdf { get; set; }
        public string CnsltsimpthCode { get; set; }
        public string CnsltsimpthLib { get; set; }
        public string CnsltsimpthComnt { get; set; }
        public int? CnsltIdf { get; set; }
        public int? SmpthIdf { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpConsultation CnsltIdfNavigation { get; set; }
        public virtual TabpSimpthome SmpthIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
    }
}
