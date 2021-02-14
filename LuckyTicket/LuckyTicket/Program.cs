using System;
using System.Text.RegularExpressions;

namespace LuckyTicket
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                string ticketNumber;
                ticketNumber = EnterTicketNumber();
                string correctTicketNumber = FixNumber(ticketNumber);
                IsLuckyTicket(correctTicketNumber);
            }
        }

        private static string EnterTicketNumber()
        {
            string pattern = @"^[0-9]{4,8}$";
            Console.Write("Enter your ticket number: ");
            string ticketNumber;

            while (!Regex.IsMatch(ticketNumber = Console.ReadLine(), pattern))
            {
                Console.WriteLine("The ticket number is a number that can be 4 to 8 digits long.");
                Console.Write("Enter your ticket number: ");
            }
            return ticketNumber;
        }

        private static string FixNumber(string ticketNumber)
        {
            if (ticketNumber.Length % 2 == 0)
            {
                return ticketNumber;
            }
            else
            {
                return "0" + ticketNumber;
            }
        }

        private static void IsLuckyTicket(string correctTicketNumber)
        {
            int sumLeft = 0, sumRight = 0;
            int midNumber = correctTicketNumber.Length / 2;
            for (int i = 0; i < midNumber; i++)
            {
                sumLeft += Convert.ToInt32(correctTicketNumber[i].ToString());
            }
            for (int i = midNumber; i < correctTicketNumber.Length; i++)
            {
                sumRight += Convert.ToInt32(correctTicketNumber[i].ToString());
            }
            if (sumLeft == sumRight)
            {
                Console.WriteLine("Congratulations on your lucky ticket!");
            }
            else
            {
                Console.WriteLine("Sorry you have a regular ticket.");
            }
        }
    }
}