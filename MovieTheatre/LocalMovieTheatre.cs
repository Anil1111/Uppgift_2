using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    public class LocalMovieTheatre
    {
        public const int INFANT_AGE = 5;
        public const int KID_AGE = 20;
        public const int OLD_MAN_AGE = 64;
        public const int VERY_OLD_AGE = 100;

        private MovieShowRepository _movieShowRepository = new MovieShowRepository();
        private TicketOrderRepository _ticketOrderRepository = new TicketOrderRepository();

        static int GetPrice(int age)
        {
            int price = 0;

            if (age < INFANT_AGE || age > VERY_OLD_AGE)
            {
                price = 0;
            }
            else if (age >= INFANT_AGE && age <= KID_AGE)
            {
                price = PriceList.KID_PRICE;
            }
            else if (age >= KID_AGE && age <= OLD_MAN_AGE)
            {
                price = PriceList.STANDARD_PRICE;
            }
            else if (age > OLD_MAN_AGE && age <= VERY_OLD_AGE)
            {
                price = PriceList.SENIOR_PRICE;
            }

            return price;
        }

        public void PrintShows()
        {
            foreach(var movieShow in _movieShowRepository.GetMovieShows())
            {
                Console.WriteLine(movieShow);
            }
        }

        public int BuyTickets(MovieShow movieShow, int[] customersAge)
        {
            int total = 0;
            TicketOrder order = new TicketOrder(movieShow);

            foreach(int age in customersAge)
            {
                total += LocalMovieTheatre.GetPrice(age);
            }

            return total;
        }

        public void PrintTicketOrders()
        {
            foreach(var ticketOrder in _ticketOrderRepository.GetTicketOrders())
            {
                Console.WriteLine(ticketOrder);
            }
        }
    }
}
