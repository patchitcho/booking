using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpCrtfctconslt
    {
        public Guid? CrtfctconsltUidf { get; set; }
        public int CrtfctconsltIdf { get; set; }
        public string CrtfctconsltCode { get; set; }
        public string CrtfctconsltLib { get; set; }
        public int? CrtfcIdf { get; set; }
        public int? CnsltIdf { get; set; }
        public string CrtfctconsltRtfdata { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpConsultation CnsltIdfNavigation { get; set; }
        public virtual TabpCertificat CrtfcIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
    }
}
