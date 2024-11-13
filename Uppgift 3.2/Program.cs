using System;

namespace Uppgift_3._2
{
    class Program
    {
        void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? (j/n)");
            bool gymnasie = bool.Parse(Console.ReadLine());
            Console.WriteLine("Ange din ålder:");
            int ålder = int.Parse(Console.ReadLine());
            if (gymnasie = true && ålder < 22 && ålder > 18)
            {
                Console.WriteLine("Vi vill gärna anställa dig!");
            }
            else Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");
        }
    }
}