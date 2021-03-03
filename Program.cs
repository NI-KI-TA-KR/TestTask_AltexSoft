using System;

namespace LuckyTicket
{
    class Program
    {
        public static void Main(string[] args)
        {
            String TicketNumber;

            
            Console.Clear();
            Console.Title = "Lucky Test";

            while (true)
            {

                while (true)
                {
                    Console.Write("Enter the ticket number (4 to 8 digits): ");
                    TicketNumber = Console.ReadLine();

                    if (TicketNumber.Equals("-1"))
                        return;

                    if ((TicketNumber.Length <= 8) && (TicketNumber.Length >= 4))
                        break;
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("The ticket number must be 4-8 digits. Try again\n");
                        Console.WriteLine("Enter '-1' to exit the program");
                    }
                }


                try
                {
                    int isINt = Convert.ToInt32(TicketNumber);

                    if (TicketNumber.Length % 2 != 0)
                    {
                        TicketNumber = "0" + TicketNumber;
                    }

                    int SumTicketPart1 = 0;
                    int SumTicketPart2 = 0;

                    for (int i = 0; i != TicketNumber.Length / 2; i++)
                        SumTicketPart1 += Convert.ToInt32(TicketNumber[i]);

                    for (int i = TicketNumber.Length / 2; i != TicketNumber.Length; i++)
                        SumTicketPart2 += Convert.ToInt32(TicketNumber[i]);

                    Console.Clear();

                    if (SumTicketPart1 == SumTicketPart2)
                        WriteLineConsoleColor("The ticket №" + TicketNumber + " is Lucky", ConsoleColor.Green);
                    else
                        WriteLineConsoleColor("THe ticket №" + TicketNumber + " is not Lucky", ConsoleColor.Red);
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Error! The entered data has non-numeric characters\n");
                }

                Console.WriteLine("\nEnter '-1' to exit the program");
            }
        }

        public static void WriteLineConsoleColor(String Line, ConsoleColor Color) 
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(Line);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
