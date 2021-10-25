using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpPatient
    {
        public TabpPatient()
        {
            TabpAntcdntspatens = new HashSet<TabpAntcdntspaten>();
            TabpConsultations = new HashSet<TabpConsultation>();
            TabpEchographies = new HashSet<TabpEchographie>();
            TabpExamen = new HashSet<TabpExaman>();
            TabpMouvements = new HashSet<TabpMouvement>();
        }

        public Guid? PtienUidf { get; set; }
        public int PtienIdf { get; set; }
        public string PtienCode { get; set; }
        public string PtienLib { get; set; }
        public string PtienCvlt { get; set; }
        public string PtienNom { get; set; }
        public string PtienPnom { get; set; }
        public DateTime? PtienNaiss { get; set; }
        public string PtienTel { get; set; }
        public string PtienProfession { get; set; }
        public int? PtienAss { get; set; }
        public string PtienNss { get; set; }
        public string PtienAutrMed { get; set; }
        public int? PtienIsDiabete { get; set; }
        public int? PtienIsCardio { get; set; }
        public int? PtienIsHprtension { get; set; }
        public int? PtienIsRespir { get; set; }
        public int? PtienIsDigestives { get; set; }
        public int? PtienIsCancers { get; set; }
        public string PtienInfoChirurg { get; set; }
        public string PtienInfoFamlie { get; set; }
        public string PtienComnt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }
        public string PtienSexe { get; set; }
        public string PtienGsang { get; set; }

        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual ICollection<TabpAntcdntspaten> TabpAntcdntspatens { get; set; }
        public virtual ICollection<TabpConsultation> TabpConsultations { get; set; }
        public virtual ICollection<TabpEchographie> TabpEchographies { get; set; }
        public virtual ICollection<TabpExaman> TabpExamen { get; set; }
        public virtual ICollection<TabpMouvement> TabpMouvements { get; set; }
    }
}
