using System;

namespace SkiPiste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1.Talabfahrt 5,3KM\n 2.Sesselbahn 2,8KM\n 3.Schlepplift 1,3KM\n 4.Tellerlift 0,5KM\n 5.Gondelbahn 4,7KM \n ----------------------------------------");
            double[] lift = { 5.3, 2.8, 1.3, 0.5, 3.7 };

            double km = 0;
            String inp = Console.ReadLine();
            while(!inp.Equals("q"))
            {
                if (inp.Length == 1 && Char.IsDigit(Char.Parse(inp)) && Int32.Parse(inp) <= 5)
                {

                    int inpnum = Int32.Parse(inp) - 1;
                    Console.WriteLine("Kilometer of the route " + (inpnum + 1) + ": " + lift[inpnum] + " km");
                    km = km + lift[inpnum];
                    Console.WriteLine("Your Journey is " + km + " kilometers long!");
                }
                else
                {
                    Console.WriteLine("ungültige eingabe...");
                }
                inp = Console.ReadLine();
                
            

            }
        }
    }
}
