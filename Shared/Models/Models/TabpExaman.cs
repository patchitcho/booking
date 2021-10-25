using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpExaman
    {
        public TabpExaman()
        {
            TabpExamanbios = new HashSet<TabpExamanbio>();
        }

        public Guid? ExamUidf { get; set; }
        public int ExamIdf { get; set; }
        public string ExamCode { get; set; }
        public string ExamLib { get; set; }
        public string ExamComnt { get; set; }
        public int? PtienIdf { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpPatient PtienIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual ICollection<TabpExamanbio> TabpExamanbios { get; set; }
    }
}
