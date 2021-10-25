using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class SysJointUsrprofl
    {
        public Guid? JointUidf { get; set; }
        public int JointIdf { get; set; }
        public string JointCode { get; set; }
        public string JointLib { get; set; }
        public string JointComn { get; set; }
        public int? UsrIdf { get; set; }
        public int? ProfilIdf { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual SysProfil ProfilIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual TabpSysUser UsrIdfNavigation { get; set; }
    }
}
