using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class SysProfil
    {
        public SysProfil()
        {
            SysDroitprofils = new HashSet<SysDroitprofil>();
            SysJointUsrprofls = new HashSet<SysJointUsrprofl>();
        }

        public Guid? ProfilUidf { get; set; }
        public int ProfilIdf { get; set; }
        public string ProfilCode { get; set; }
        public string ProfilLib { get; set; }
        public int? ProfilStat { get; set; }
        public string ProfilComn { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual ICollection<SysDroitprofil> SysDroitprofils { get; set; }
        public virtual ICollection<SysJointUsrprofl> SysJointUsrprofls { get; set; }
    }
}
