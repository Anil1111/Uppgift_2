using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    static class TicketFactory
    {
        public static ITicket GetTicket(TicketType ticketType)
        {
            switch (ticketType)
            {
                case TicketType.KID:
                    return new KidTicket();
                case TicketType.STANDARD:
                    return new StandardTicket();
                case TicketType.SENIOR:
                    return new SeniorTicket();
                case TicketType.FREE:
                    return new FreeTicket();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
