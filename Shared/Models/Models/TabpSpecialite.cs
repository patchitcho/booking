using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpSpecialite
    {
        public TabpSpecialite()
        {
            TabpDcis = new HashSet<TabpDci>();
        }

        public Guid? SpcltUidf { get; set; }
        public int SpcltIdf { get; set; }
        public string SpcltCode { get; set; }
        public string SpcltLib { get; set; }
        public string SpcltFamille { get; set; }
        public string SpcltDescpt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual ICollection<TabpDci> TabpDcis { get; set; }
    }
}
