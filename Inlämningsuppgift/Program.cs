using System;
namespace Inlämningsuppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur gammal är du? (år)");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder > 16 && ålder  < 19)
            {
                Console.WriteLine("du får delta");
            }
            else
            { 
                Console.WriteLine("du får inte delta");

            }
        }
    }
}
