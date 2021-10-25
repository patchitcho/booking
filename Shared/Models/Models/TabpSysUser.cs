using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpSysUser
    {
        public TabpSysUser()
        {
            InverseUserIdfNavigation = new HashSet<TabpSysUser>();
            SysDroitprofils = new HashSet<SysDroitprofil>();
            SysJointUsrproflUserIdfNavigations = new HashSet<SysJointUsrprofl>();
            SysJointUsrproflUsrIdfNavigations = new HashSet<SysJointUsrprofl>();
            SysProfils = new HashSet<SysProfil>();
            TabpAntcdntspatens = new HashSet<TabpAntcdntspaten>();
            TabpAntecedents = new HashSet<TabpAntecedent>();
            TabpBiodiagnostics = new HashSet<TabpBiodiagnostic>();
            TabpCertificats = new HashSet<TabpCertificat>();
            TabpCnsultdetlls = new HashSet<TabpCnsultdetll>();
            TabpConsultations = new HashSet<TabpConsultation>();
            TabpConsultsimpthos = new HashSet<TabpConsultsimptho>();
            TabpCrtfctconslts = new HashSet<TabpCrtfctconslt>();
            TabpDcis = new HashSet<TabpDci>();
            TabpEchographies = new HashSet<TabpEchographie>();
            TabpExamanbios = new HashSet<TabpExamanbio>();
            TabpExamen = new HashSet<TabpExaman>();
            TabpFormMedics = new HashSet<TabpFormMedic>();
            TabpLots = new HashSet<TabpLot>();
            TabpMouvements = new HashSet<TabpMouvement>();
            TabpPatients = new HashSet<TabpPatient>();
            TabpProduits = new HashSet<TabpProduit>();
            TabpSimpthomes = new HashSet<TabpSimpthome>();
            TabpSpecialites = new HashSet<TabpSpecialite>();
            TabpUserproduitUserIdfNavigations = new HashSet<TabpUserproduit>();
            TabpUserproduitUsrIdfNavigations = new HashSet<TabpUserproduit>();
            TabpUsersympthomUserIdfNavigations = new HashSet<TabpUsersympthom>();
            TabpUsersympthomUsrIdfNavigations = new HashSet<TabpUsersympthom>();
        }

        public Guid? UsrUidf { get; set; }
        public int UsrIdf { get; set; }
        public string UsrCode { get; set; }
        public string UsrLib { get; set; }
        public string UsrPass { get; set; }
        public string UsrCivlt { get; set; }
        public string UsrNom { get; set; }
        public string UsrPnom { get; set; }
        public string UsrTel { get; set; }
        public string UsrEmail { get; set; }
        public string UsrAdrss { get; set; }
        public string UsrDescript { get; set; }
        public string UsrAutres { get; set; }
        public string UsrPost { get; set; }
        public int? DroitusesIdf { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual ICollection<TabpSysUser> InverseUserIdfNavigation { get; set; }
        public virtual ICollection<SysDroitprofil> SysDroitprofils { get; set; }
        public virtual ICollection<SysJointUsrprofl> SysJointUsrproflUserIdfNavigations { get; set; }
        public virtual ICollection<SysJointUsrprofl> SysJointUsrproflUsrIdfNavigations { get; set; }
        public virtual ICollection<SysProfil> SysProfils { get; set; }
        public virtual ICollection<TabpAntcdntspaten> TabpAntcdntspatens { get; set; }
        public virtual ICollection<TabpAntecedent> TabpAntecedents { get; set; }
        public virtual ICollection<TabpBiodiagnostic> TabpBiodiagnostics { get; set; }
        public virtual ICollection<TabpCertificat> TabpCertificats { get; set; }
        public virtual ICollection<TabpCnsultdetll> TabpCnsultdetlls { get; set; }
        public virtual ICollection<TabpConsultation> TabpConsultations { get; set; }
        public virtual ICollection<TabpConsultsimptho> TabpConsultsimpthos { get; set; }
        public virtual ICollection<TabpCrtfctconslt> TabpCrtfctconslts { get; set; }
        public virtual ICollection<TabpDci> TabpDcis { get; set; }
        public virtual ICollection<TabpEchographie> TabpEchographies { get; set; }
        public virtual ICollection<TabpExamanbio> TabpExamanbios { get; set; }
        public virtual ICollection<TabpExaman> TabpExamen { get; set; }
        public virtual ICollection<TabpFormMedic> TabpFormMedics { get; set; }
        public virtual ICollection<TabpLot> TabpLots { get; set; }
        public virtual ICollection<TabpMouvement> TabpMouvements { get; set; }
        public virtual ICollection<TabpPatient> TabpPatients { get; set; }
        public virtual ICollection<TabpProduit> TabpProduits { get; set; }
        public virtual ICollection<TabpSimpthome> TabpSimpthomes { get; set; }
        public virtual ICollection<TabpSpecialite> TabpSpecialites { get; set; }
        public virtual ICollection<TabpUserproduit> TabpUserproduitUserIdfNavigations { get; set; }
        public virtual ICollection<TabpUserproduit> TabpUserproduitUsrIdfNavigations { get; set; }
        public virtual ICollection<TabpUsersympthom> TabpUsersympthomUserIdfNavigations { get; set; }
        public virtual ICollection<TabpUsersympthom> TabpUsersympthomUsrIdfNavigations { get; set; }
    }
}
