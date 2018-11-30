using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{

    class TicketOrder
    {
        private readonly MovieShow _movieShow;
        List<ITicket> _tickets = new List<ITicket>();

        public TicketOrder(MovieShow movieShow)
        {
            _movieShow = movieShow;
        }

        public void AddTicket(ITicket ticket)
        {
            _tickets.Add(ticket);
        }

        public int GetTotal()
        {
            int total = 0;
            foreach(ITicket ticket in _tickets)
            {
                total += ticket.GetPrice();
            }
            return total;
        }
    }
}
