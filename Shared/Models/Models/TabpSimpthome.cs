using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class TabpSimpthome
    {
        public TabpSimpthome()
        {
            TabpConsultsimpthos = new HashSet<TabpConsultsimptho>();
            TabpUsersympthoms = new HashSet<TabpUsersympthom>();
        }

        public Guid? SmpthUidf { get; set; }
        public int SmpthIdf { get; set; }
        public string SmpthCode { get; set; }
        public string SmpthLib { get; set; }
        public string SmpthComnt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
        public int? UserIdf { get; set; }

        public virtual TabpSysUser UserIdfNavigation { get; set; }
        public virtual ICollection<TabpConsultsimptho> TabpConsultsimpthos { get; set; }
        public virtual ICollection<TabpUsersympthom> TabpUsersympthoms { get; set; }
    }
}
