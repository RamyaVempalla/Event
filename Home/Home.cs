using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neudesic.Model.Events;

namespace Neudesic.Home
{
    class Home
    {
        public static List<Events> EventList { get; private set; }

        static void Main(string[] args)
        {
            Admin admin = new Admin();
            User user = new User();
            Console.WriteLine("-------------------Enter your role-------------------");
            Console.WriteLine("1.Admin");
            Console.WriteLine("2.User");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                int check;
                do
                {
                    Console.WriteLine("-------------------Enter your choice-------------------");
                    Console.WriteLine("1.Create event");
                    Console.WriteLine("2.See events");
                    Console.WriteLine("3.Exit");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter EventId");
                            int eventId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Event name");
                            string eventName = Console.ReadLine();
                            Console.WriteLine("Enter Event place");
                            string eventPlace = Console.ReadLine();
                            Console.WriteLine("Enter Event Fee");
                            int eventFee = Convert.ToInt32(Console.ReadLine());
                            admin.AddEvent(eventId, eventName, eventPlace, eventFee);
                            Console.WriteLine("Successfully Created event");
                            break;
                        case 2:
                            EventList = admin.SeeEvents();
                            foreach (var events in EventList)
                            {
                                Console.WriteLine(events.Id + "." + events.Name + " " + events.Place + " " + events.Fee);
                            }
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    check = choice;
                } while (check != 3);
            }
            else
            {
                int option;
                do
                {
                    Console.WriteLine("-------------------Enter your choice-------------------");
                    Console.WriteLine("1.See events");
                    Console.WriteLine("2.Exit");
                    int select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            user.SeeEvents();
                            break;
                        case 2:
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    option = select;
                } while (option != 2);
            }
        }
    }
}
