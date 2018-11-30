using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    class TicketFactory
    {
        public ITicket GetTicket(TicketType ticketType)
        {
            switch (ticketType)
            {
                case TicketType.KID:
                    return new KidTicket();
                case TicketType.STANDARD:
                    return new StandardTicket();
                case TicketType.SENIOR:
                    return new SeniorTicket();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
