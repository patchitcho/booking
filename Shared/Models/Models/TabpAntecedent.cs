using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpAntecedent
    {
        public TabpAntecedent()
        {
            TabpAntcdntspatens = new HashSet<TabpAntcdntspaten>();
        }

        public Guid? AntcdnUidf { get; set; }
        public int AntcdnIdf { get; set; }
        public string AntcdnCode { get; set; }
        public string AntcdnLib { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual ICollection<TabpAntcdntspaten> TabpAntcdntspatens { get; set; }
    }
}
