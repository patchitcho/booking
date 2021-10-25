using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpDci
    {
        public TabpDci()
        {
            TabpProduits = new HashSet<TabpProduit>();
        }

        public Guid? DciUidf { get; set; }
        public int DciIdf { get; set; }
        public string DciCode { get; set; }
        public string DciLib { get; set; }
        public string DciDescpt { get; set; }
        public int? SpcltIdf { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpSpecialite SpcltIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual ICollection<TabpProduit> TabpProduits { get; set; }
    }
}
