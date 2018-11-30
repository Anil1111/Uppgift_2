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
        

        private static ITicket GetAppropriateTicket(int age)
        {

            ITicket ticket = null;

            if (age < INFANT_AGE || age > VERY_OLD_AGE)
            {
                ticket = TicketFactory.GetTicket(TicketType.FREE);
            }
            else if (age >= INFANT_AGE && age <= KID_AGE)
            {
                ticket = TicketFactory.GetTicket(TicketType.KID);
            }
            else if (age >= KID_AGE && age <= OLD_MAN_AGE)
            {
                ticket = TicketFactory.GetTicket(TicketType.STANDARD);
            }
            else if (age > OLD_MAN_AGE && age <= VERY_OLD_AGE)
            {
                ticket = TicketFactory.GetTicket(TicketType.SENIOR);
            }

            return ticket;
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

            TicketOrder order = new TicketOrder(movieShow);

            foreach(int age in customersAge)
            {
                ITicket ticket = GetAppropriateTicket(age);
                order.AddTicket(ticket);
            }

            _ticketOrderRepository.AddOrder(order);

            return order.GetTotal();
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
