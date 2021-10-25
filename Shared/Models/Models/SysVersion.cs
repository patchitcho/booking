using System;
using System.Collections.Generic;

#nullable disable

namespace Proxima.Shared.Models
{
    public partial class SysVersion
    {
        public int VerIdf { get; set; }
        public string VerCode { get; set; }
        public string VerProd { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdt { get; set; }
    }
}
