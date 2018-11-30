using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    class SeniorTicket : ITicket
    {
        public int GetPrice()
        {
            return PriceList.SENIOR_PRICE;
        }
    }
}
