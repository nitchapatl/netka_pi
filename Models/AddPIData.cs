using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netka_pi.Models
{
    public class AddPIData
    {
        public string Issue_No { get; set; }
        public string Title { get; set; }
        public string Originator_Name { get; set; }
        public string Date_Raised { get; set; }
        public string Date_Resolved { get; set; }
        public string Item_Name { get; set; }
        public string Issue_Description { get; set; }
        public string Process { get; set; }
        public string Category { get; set; }
        public string Severity { get; set; }
        public string Status { get; set; }
        public string TimestampUtc { get; set; }

    }
}
