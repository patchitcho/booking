using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpEchographie
    {
        public Guid? EcogrphUidf { get; set; }
        public int EcogrphIdf { get; set; }
        public string EcogrphCode { get; set; }
        public string EcogrphLib { get; set; }
        public string EcogrphEpous { get; set; }
        public string EcogrphGrpgRhss { get; set; }
        public string EcogrphGsttPart { get; set; }
        public int? EcogrphEnfViv { get; set; }
        public string EcogrphMariage { get; set; }
        public string EcogrphCnsongnt { get; set; }
        public string EcogrphType { get; set; }
        public DateTime? EcogrphDdr { get; set; }
        public string EcogrphAtcdMC { get; set; }
        public DateTime? EcogrphDpa { get; set; }
        public string EcogrphT1Ta { get; set; }
        public float? EcogrphT1Poid { get; set; }
        public string EcogrphT1TrmThrq { get; set; }
        public string EcogrphT1Pathologie { get; set; }
        public string EcogrphT1Vessie { get; set; }
        public string EcogrphT1Utrus { get; set; }
        public string EcogrphT1Gsttnnel { get; set; }
        public string EcogrphT1Siege { get; set; }
        public string EcogrphT1Embryon { get; set; }
        public string EcogrphT1Lcc { get; set; }
        public string EcogrphT1BiPartl { get; set; }
        public string EcogrphT1Cardio { get; set; }
        public string EcogrphT1Trphblst { get; set; }
        public string EcogrphT1Droite { get; set; }
        public string EcogrphT1Gauche { get; set; }
        public string EcogrphT1Douglas { get; set; }
        public string EcogrphT1Cnclus { get; set; }
        public DateTime? EcogrphT1Date { get; set; }
        public string EcogrphT2Ta { get; set; }
        public float? EcogrphT2Poid { get; set; }
        public string EcogrphT2TrmThrq { get; set; }
        public string EcogrphT2Pathologie { get; set; }
        public string EcogrphT2Grssess { get; set; }
        public string EcogrphT2Position { get; set; }
        public string EcogrphT2Dos { get; set; }
        public string EcogrphT2Cardio { get; set; }
        public string EcogrphT2MouvAFoetx { get; set; }
        public string EcogrphT2BiPartl { get; set; }
        public string EcogrphT2Lf { get; set; }
        public string EcogrphT2Dat { get; set; }
        public string EcogrphT2Placenta { get; set; }
        public string EcogrphT2LqdAmntq { get; set; }
        public string EcogrphT2Morphlg { get; set; }
        public string EcogrphT2Cnclus { get; set; }
        public DateTime? EcogrphT2Date { get; set; }
        public string EcogrphT3Ta { get; set; }
        public float? EcogrphT3Poid { get; set; }
        public string EcogrphT3TrmThrq { get; set; }
        public string EcogrphT3Pathologie { get; set; }
        public string EcogrphT3Grssess { get; set; }
        public string EcogrphT3Position { get; set; }
        public string EcogrphT3Dos { get; set; }
        public string EcogrphT3Cardio { get; set; }
        public string EcogrphT3MouvAFoetx { get; set; }
        public string EcogrphT3BiPartl { get; set; }
        public string EcogrphT3Lf { get; set; }
        public string EcogrphT3Dat { get; set; }
        public string EcogrphT3Placenta { get; set; }
        public string EcogrphT3LqdAmntq { get; set; }
        public string EcogrphT3Morphlg { get; set; }
        public string EcogrphT3Cnclus { get; set; }
        public DateTime? EcogrphT3Date { get; set; }
        public int? PtienIdf { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpPatient PtienIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
    }
}
