using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpLot
    {
        public TabpLot()
        {
            TabpMouvements = new HashSet<TabpMouvement>();
        }

        public Guid? LotUidf { get; set; }
        public int LotIdf { get; set; }
        public string LotCode { get; set; }
        public string LotLib { get; set; }
        public string LotNlot { get; set; }
        public DateTime? LotFabr { get; set; }
        public DateTime? LotExp { get; set; }
        public float? LotAchat { get; set; }
        public float? LotVente { get; set; }
        public int? ProdIdf { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpProduit ProdIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual ICollection<TabpMouvement> TabpMouvements { get; set; }
    }
}
