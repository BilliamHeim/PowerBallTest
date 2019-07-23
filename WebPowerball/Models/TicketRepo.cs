using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPowerball.Models
{
    public class TicketRepo
    {
        private static List<Ticket> _tickets;

        static TicketRepo()
        {
            _tickets = new List<Ticket>()
            {
            new Ticket { Name="Biscuit", Numbers = new int[6] { 24, 15, 12, 17, 2, 14 },ID=1 },
            new Ticket { Name = "Abradolf Lincler", Numbers = new int[6] { 34, 30, 22, 37, 52, 11 }, ID = 2 },
            new Ticket { Name = "Bob Ross", Numbers = new int[6] { 64, 39, 13, 27, 32, 7 }, ID = 3 },
            new Ticket { Name = "Iroh", Numbers = new int[6] { 54, 31, 45, 7, 42, 4 }, ID = 4 },
            };
        }

        public static void Add(Ticket ticket)
        {
            if (_tickets.Any())
            {
                ticket.ID = _tickets.Max(t => t.ID) + 1;
            }
            else
            {
                ticket.ID = 1;
            }

            _tickets.Add(ticket);
        }

        public static List<Ticket> GetAll()
        {
            return _tickets;
        }

        public static Ticket Get(int id)
        {
            return _tickets.FirstOrDefault(t => t.ID == id);
        }
    }
}