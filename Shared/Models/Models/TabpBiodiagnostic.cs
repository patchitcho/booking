using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpBiodiagnostic
    {
        public TabpBiodiagnostic()
        {
            TabpExamanbios = new HashSet<TabpExamanbio>();
        }

        public Guid? BiodiagUidf { get; set; }
        public int BiodiagIdf { get; set; }
        public string BiodiagCode { get; set; }
        public string BiodiagLib { get; set; }
        public float? BiodiagLabo { get; set; }
        public float? BiodiagConv { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual ICollection<TabpExamanbio> TabpExamanbios { get; set; }
    }
}
