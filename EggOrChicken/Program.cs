using System;
using System.Threading;

namespace EggOrChicken
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread chicken = new(ThrChicken);
            chicken.Start();
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine("Яйцо");
            }
            ThrAns(chicken);
        }

            static void ThrChicken()
            {
                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine("Курица");
                }
            }
            static void ThrAns(Thread chicken)
            {
                Thread.Sleep(10);
                bool ans = chicken.IsAlive;
                Console.WriteLine(ans ? "Спор Окончен. Победила Курица." : "Спор окончен. Победило Яйцо.");
            }
        
    }
}