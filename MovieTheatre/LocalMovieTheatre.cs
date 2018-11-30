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
        public const int KID_PRICE = 80;
        public const int STANDARD_PRICE = 120;
        public const int OLD_MAN_PRICE = 90;

        private MovieShowRepository _movieShowRepository = new MovieShowRepository();
        private TicketOrderRepository _ticketOrderRepository = new TicketOrderRepository();

        static int GetPrice(int age)
        {
            int price = 0;

            if (age < INFANT_AGE || age > VERY_OLD_AGE)
            {
                Console.WriteLine("Price: Free!!!");
                price = 0;
            }
            else if (age >= INFANT_AGE && age <= KID_AGE)
            {
                Console.WriteLine("Kid price: {0}", KID_PRICE.ToString("c"));
                price = KID_PRICE;
            }
            else if (age >= KID_AGE && age <= OLD_MAN_AGE)
            {
                Console.WriteLine("Standard price: {0}", STANDARD_PRICE.ToString("c"));
                price = STANDARD_PRICE;
            }
            else if (age > OLD_MAN_AGE && age <= VERY_OLD_AGE)
            {
                Console.WriteLine("Senior price {0}", OLD_MAN_PRICE.ToString("c"));
                price = OLD_MAN_PRICE;
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
