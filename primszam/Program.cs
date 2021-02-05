using System;

namespace primszam
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Adj egy számot 1-1000 között");
                string szam = Console.ReadLine();
                int number;
                bool van = int.TryParse(szam, out number);
                int alma = 1;
                if (van && 1<= number && number <=1000)
                {
                    bool prim = number > 1;
                    while (alma < number - 1)
                    {
                        alma += 1;
                        if (number % alma == 0)
                        {
                            prim = false;
                            break;
                        }

                    }
                    if (prim)
                    {
                        Console.WriteLine("A(z) " + szam + " prímszám.");
                    }
                    else
                    {
                        Console.WriteLine("A(z) " + szam + " nem prímszám.");
                    }
                }
                else
                {
                    Console.WriteLine("Nem megfelő adatot adott meg.");
                }

            }
        }
    }
}
