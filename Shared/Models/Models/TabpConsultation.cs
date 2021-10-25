using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpConsultation
    {
        public TabpConsultation()
        {
            TabpCnsultdetlls = new HashSet<TabpCnsultdetll>();
            TabpConsultsimpthos = new HashSet<TabpConsultsimptho>();
            TabpCrtfctconslts = new HashSet<TabpCrtfctconslt>();
            TabpMouvements = new HashSet<TabpMouvement>();
        }

        public Guid? CnsltUidf { get; set; }
        public int CnsltIdf { get; set; }
        public string CnsltCode { get; set; }
        public string CnsltLib { get; set; }
        public string CnsltRdv { get; set; }
        public DateTime? CnsltRdvDate { get; set; }
        public int? CnsltRdvNum { get; set; }
        public int? CnsltRdvColor { get; set; }
        public string CnsltRdvStat { get; set; }
        public string CnsltMotif { get; set; }
        public string CnsltRcliniq { get; set; }
        public string CnsltRparcliniq { get; set; }
        public string CnsltAncinTret { get; set; }
        public string CnsltRaport { get; set; }
        public string CnsltAutre { get; set; }
        public string CnsltType { get; set; }
        public int? CnsltTsysto { get; set; }
        public int? CnsltTdiasto { get; set; }
        public float? CnsltGlycemie { get; set; }
        public int? CnsltPois { get; set; }
        public float? CnsltPrix { get; set; }
        public float? CnsltRegle { get; set; }
        public string CnsltArrTraval { get; set; }
        public string CnsltArrTrvPrlng { get; set; }
        public string CnsltVirgiQPrsnt { get; set; }
        public string CnsltVirgiConclus { get; set; }
        public string CnsltPhtisioQPrsnt { get; set; }
        public string CnsltPhtisioConclus { get; set; }
        public DateTime? CnsltDate { get; set; }
        public int? PtienIdf { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }
        public float? CnsltPoid { get; set; }
        public float? CnsltTaille { get; set; }
        public float? CnsltImc { get; set; }
        public float? CnsltPc { get; set; }
        public float? CnsltTemp { get; set; }
        public int? EcogrphIdf { get; set; }
        public string CnsltPnom { get; set; }
        public string CnsltPprenom { get; set; }
        public string CnsltOrdAge { get; set; }

        public virtual TabpPatient PtienIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual ICollection<TabpCnsultdetll> TabpCnsultdetlls { get; set; }
        public virtual ICollection<TabpConsultsimptho> TabpConsultsimpthos { get; set; }
        public virtual ICollection<TabpCrtfctconslt> TabpCrtfctconslts { get; set; }
        public virtual ICollection<TabpMouvement> TabpMouvements { get; set; }
    }
}
