using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class SysObject
    {
        public int SysobjIdf { get; set; }
        public string SysobjCode { get; set; }
        public string SysobjLib { get; set; }
        public string SysobjName { get; set; }
        public string SysobjData { get; set; }
        public DateTime? SysobjStartDate { get; set; }
        public DateTime? SysobjEndDate { get; set; }
        public int? DroitusesIdf { get; set; }
        public string SysobjInt { get; set; }
        public int? UserIdf { get; set; }
        public DateTime? LastUpdt { get; set; }
    }
}
