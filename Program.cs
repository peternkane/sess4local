using System;

//Coder     PETER NKANE.

namespace sess4local
{
    class Program
    {
        static void Main(string[] args)
        {
            //Space traveller age in seconds
            decimal spacetravelorAGE = 631154000M;

            //Earth orbital period in seconds
            decimal earthseconds = 31557600M;

            //Planet names and their orbital periods
            string[] planetnames = new string[4];
            decimal[] orbitalyears = new decimal[4];
            planetnames[0] = "Venus age :";
            orbitalyears[0] = 0.61519726M;
            planetnames[1] = "Earth age :";
            orbitalyears[1] = 0.00M;
            planetnames[2] = "Mars age :";
            orbitalyears[2] = 1.8808158M;
            planetnames[3] = "Jupiter age :";
            orbitalyears[3] = 11.86261M;

                       
            //Calculation of space travelor age(in years) on earth
            decimal ageinyears = spacetravelorAGE/earthseconds;
            decimal amount1 = Math.Round(ageinyears, 2);
            Console.WriteLine("Space traveller is "+ amount1 + " years old");

            for(int i = 0;  i < planetnames.Length; i++ ){  
               
                    foreach(var o in orbitalyears){ 

                        decimal Amount2 = (orbitalyears[i] + amount1);
                        decimal amount3 = Math.Round(Amount2, 2);


                        //  Console.WriteLine(String.Format("{0}"+ planetnames[i] + " " + (orbitalyears[i]+ageinyears) + " Earth-years old"));

                        Console.WriteLine(planetnames[i] + " " + amount3 + " Earth-years old");
                        break;                                              
                    }             
            } 


        }
    }
}
