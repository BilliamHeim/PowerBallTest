using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPowerball.Models
{
    public class AddTicketViewModel
    {
        public string Name { get; set; }
        public int Numbers1 { get; set; }
        public int Numbers2 { get; set; }
        public int Numbers3 { get; set; }
        public int Numbers4 { get; set; }
        public int Numbers5 { get; set; }
        public int Numbers6 { get; set; }
    }
}