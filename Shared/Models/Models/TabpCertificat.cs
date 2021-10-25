using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpCertificat
    {
        public TabpCertificat()
        {
            TabpCrtfctconslts = new HashSet<TabpCrtfctconslt>();
        }

        public Guid? CrtfcUidf { get; set; }
        public int CrtfcIdf { get; set; }
        public string CrtfcCode { get; set; }
        public string CrtfcLib { get; set; }
        public string CrtfcFamille { get; set; }
        public string CrtfcRtfdata { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual ICollection<TabpCrtfctconslt> TabpCrtfctconslts { get; set; }
    }
}
