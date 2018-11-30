using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    public enum TicketType
    {
        KID,
        STANDARD,
        SENIOR
    }

    interface ITicket
    {
        int GetPrice();
    }
}
