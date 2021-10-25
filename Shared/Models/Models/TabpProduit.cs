using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpProduit
    {
        public TabpProduit()
        {
            TabpCnsultdetlls = new HashSet<TabpCnsultdetll>();
            TabpLots = new HashSet<TabpLot>();
            TabpUserproduits = new HashSet<TabpUserproduit>();
        }

        public Guid? ProdUidf { get; set; }
        public int ProdIdf { get; set; }
        public string ProdCode { get; set; }
        public string ProdLib { get; set; }
        public int? DciIdf { get; set; }
        public string ProdPrstd { get; set; }
        public int? ProdDrstd { get; set; }
        public string ProdTrtstd { get; set; }
        public string ProdNom { get; set; }
        public string ProdDose { get; set; }
        public string ProdForm { get; set; }
        public string ProdAss { get; set; }
        public DateTime? ProdAssDate { get; set; }
        public DateTime? ProdAssDate2 { get; set; }
        public float? ProdPrix { get; set; }
        public int? FrmIdf { get; set; }
        public string ProdRef1 { get; set; }
        public string ProdMolecule { get; set; }
        public string ProdPays { get; set; }
        public string ProdInfoInscrpt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpDci DciIdfNavigation { get; set; }
        public virtual TabpFormMedic FrmIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual ICollection<TabpCnsultdetll> TabpCnsultdetlls { get; set; }
        public virtual ICollection<TabpLot> TabpLots { get; set; }
        public virtual ICollection<TabpUserproduit> TabpUserproduits { get; set; }
    }
}
