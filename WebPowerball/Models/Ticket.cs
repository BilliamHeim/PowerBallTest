using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPowerball.Models
{
    public class Ticket
    {
        public string Name { get; set; }
        public int[] Numbers = new int[6];
        public int ID { get; set; }
    }
}