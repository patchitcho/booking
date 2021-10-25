using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpUsersympthom
    {
        public Guid? UsrsmpthUidf { get; set; }
        public int UsrsmpthIdf { get; set; }
        public string UsrsmpthCode { get; set; }
        public string UsrsmpthLib { get; set; }
        public int? SmpthIdf { get; set; }
        public int? UsrIdf { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpSimpthome SmpthIdfNavigation { get; set; }
        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual TabpSysUser UsrIdfNavigation { get; set; }
    }
}
