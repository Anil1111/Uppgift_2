using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    public class KidTicket : ITicket
    {

        public int GetPrice()
        {
            return PriceList.KID_PRICE;
        }
    }
}
