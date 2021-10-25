using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpMouvement
    {
        public Guid? MouvUidf { get; set; }
        public int MouvIdf { get; set; }
        public string MouvCode { get; set; }
        public string MouvLib { get; set; }
        public string MouvType { get; set; }
        public float? MouvQtt { get; set; }
        public string MouvUnit { get; set; }
        public string MouvComnt { get; set; }
        public int? LotIdf { get; set; }
        public int? PtienIdf { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }
        public int? CnsltIdf { get; set; }

        public virtual TabpConsultation CnsltIdfNavigation { get; set; }
        public virtual TabpLot LotIdfNavigation { get; set; }
        public virtual TabpPatient PtienIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
    }
}
