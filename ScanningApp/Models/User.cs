using System;
using System.Collections.Generic;

namespace ScanningApp.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? QrCode { get; set; }
        public DateTime? DateLastScan { get; set; }
    }
}
