using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class SysDroitprofil
    {
        public Guid? DroprflUidf { get; set; }
        public int DroprflIdf { get; set; }
        public string DroprflCode { get; set; }
        public string DroprflLib { get; set; }
        public string DroprflCmnt { get; set; }
        public int? DroprflShow { get; set; }
        public int? DroprflCreat { get; set; }
        public int? DroprflEdit { get; set; }
        public int? DroprflDel { get; set; }
        public int? ProfilIdf { get; set; }
        public int? SysobjIdf { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual SysProfil ProfilIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
    }
}
