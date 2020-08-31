using System;

namespace InterestCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Junge gib dein Start-Investment ein: ");
            int investmentStart = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Junge gib dein Investment pro Monat ein: ");
            int investmentPerMonth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Junge gib Zinsen pro Jahr ein: ");
            double interestPerYear = Double.Parse(Console.ReadLine());
            Console.WriteLine("Junge gib die Zeit in Monaten ein: ");
            int months = Int32.Parse(Console.ReadLine());

            int bankAccount = investmentStart;
            int totalInvestment = investmentStart;
            for (int month = 0; month < months; month++)
            {
                totalInvestment += investmentPerMonth;
                bankAccount += investmentPerMonth;
                
                int monthlyReturn = (int)(bankAccount * (interestPerYear / 12) / 100);
                bankAccount += monthlyReturn;
                Console.WriteLine($"Geld nach {month} Monaten: {bankAccount}, (Investiert insgesamt: {totalInvestment}, erhaltener Gewinn / Zinsen: {(bankAccount - totalInvestment)}, Diesen Monat: +{monthlyReturn}");
            }

            Console.WriteLine($"Geld am Ende auf deine Bankkonto (falls kein Hacker das klaut und die börse net abkackt: {bankAccount}");
            Console.ReadLine(); //Damit das fenster net sich verpisst
        }
    }
}
