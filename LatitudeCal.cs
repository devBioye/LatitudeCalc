using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Latitude
{
    static class LatitudeCal
    {
        static int dum1 = 0;
        static int num = 0;
        static int dum=0;
        static int beep = 0;
        static public void Redo()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            while (beep < 5)
            {

                Console.Beep();
                beep++;

            }
            Console.WriteLine("Welcome user to latitude digital calculator\tSelect 1 Or 2");
            Console.WriteLine("1 Country value");
            Console.WriteLine("2 Countries value");
            int first;
            Console.WriteLine("Select 1 for just one country and 2 for more than one country");
            first = int.Parse(Console.ReadLine());
            switch (first)
            {
                case 1:
                    
                    Console.WriteLine("Country Latitude number/degree: ");
                    num = int.Parse(Console.ReadLine());
                    int almost = num - 0;
                    int distance = 111 * almost;
                    Console.WriteLine("Distance = {0}km", distance);
                    Console.ReadLine();
                    break;
                case 2:
                    
                    Console.WriteLine("First Country Latitude number/degree: ");
                    dum = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Second Country Latitude number/degree: ");
                    dum1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the Location of the first Country [either south or north] ");
                    String dum2 = Console.ReadLine();
                    Console.WriteLine("Enter the Location of the second Country [either south or north] ");
                    String dum3 = Console.ReadLine();
                    if (dum2 == "north" && dum3 == "south")
                    {
                        int crumb = dum + dum1;
                        int distance1 = crumb * 111;
                        Console.WriteLine("Distance = {0}km\n", distance1);
                        Redo();
                    }
                    else if (dum2 == "south" && dum3 == "north")
                    {
                        int crumb = dum + dum1;
                        int distance1 = crumb * 111;
                        Console.WriteLine("Distance = {0}km \n", distance1);
                        Redo();
                    }
                    else if (dum2 == "south" && dum3 == "south")
                    {
                        if (dum - dum1 > 0)
                        {
                            int crumb = dum - dum1;
                            int distance1 = crumb * 111;
                            Console.WriteLine("Distance = {0}km \n", distance1);
                            Redo();
                        }
                        else
                        {
                            int crumb = dum1 - dum;
                            int distance1 = crumb * 111;
                            Console.WriteLine("Distance = {0}km \n", distance1);
                            Redo();
                        }
                    }
                    else if (dum2 == "north" && dum3 == "north")
                    {
                        if (dum - dum1 > 0)
                        {
                            int crumb = dum - dum1;
                            int distance1 = crumb * 111;
                            Console.WriteLine("Distance = {0}km \n", distance1);
                            Redo();
                        }
                        else
                        {
                            int crumb = dum1 - dum;
                            int distance1 = crumb * 111;
                            Console.WriteLine("Distance = {0}km \n", distance1);
                            Redo();
                        }


                    }
                    else
                    {
                        Console.WriteLine("Incorrect Location");
                        Console.ReadLine();
                    }
                    break;


            }

            Console.ReadLine();
        }
    }
}
