using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    class StandardTicket : ITicket
    {
        public int GetPrice()
        {
            return PriceList.STANDARD_PRICE;
        }
    }
}
