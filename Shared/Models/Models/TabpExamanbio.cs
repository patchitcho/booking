using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpExamanbio
    {
        public Guid? ExambiodiagUidf { get; set; }
        public int ExambiodiagIdf { get; set; }
        public string ExambiodiagCode { get; set; }
        public string ExambiodiagLib { get; set; }
        public string ExambiodiagResult { get; set; }
        public int? BiodiagIdf { get; set; }
        public int? ExamIdf { get; set; }
        public float? ExambiodiagLabo { get; set; }
        public float? ExambiodiagConv { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpBiodiagnostic BiodiagIdfNavigation { get; set; }
        public virtual TabpExaman ExamIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
    }
}
