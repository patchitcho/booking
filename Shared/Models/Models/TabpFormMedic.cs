using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpFormMedic
    {
        public TabpFormMedic()
        {
            TabpProduits = new HashSet<TabpProduit>();
        }

        public Guid? FrmUidf { get; set; }
        public int FrmIdf { get; set; }
        public string FrmCode { get; set; }
        public string FrmLib { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual ICollection<TabpProduit> TabpProduits { get; set; }
    }
}
