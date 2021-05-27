using System;

//Coder     PETER NKANE.

namespace sess4local
{
    class Program
    {
        static void Main(string[] args)
        {
            //Space traveller age in seconds
            int spacetravelorAGE = 631154000;
            // decimal spacetravelorAGE = 631154000f;

            //Earth orbital period in seconds
            int earthseconds = 31557600;
            // decimal earthseconds = 31557600f;

            //Planet names and their orbital periods
            string[] planetnames = new string[4];
            float[] orbitalyears = new float[4];
            planetnames[0] = "Venus age :";
            orbitalyears[0] = 0.61519726f;
            // planetnames[1] = "Earth age :";
            // orbitalyears[1] = 0.00f;
            planetnames[1] = "Mars age :";
            orbitalyears[1] = 1.8808158f;
            planetnames[2] = "Jupiter age :";
            orbitalyears[2] = 11.862615f;
            planetnames[3] = "Neptune age :";
            orbitalyears[3] = 164.79132f;

                       
            //Calculation of space travelor age(in years) on earth
            float ageinyears = spacetravelorAGE/earthseconds;
            float amount1 = (float)Math.Round(ageinyears, 2);
            Console.WriteLine("Space traveller is "+ amount1 + " years old");

            for(int i = 0;  i < planetnames.Length; i++ ){  
               
                    // foreach(var o in orbitalyears){ 

                        float Amount2 = (amount1 / orbitalyears[i]);
                        float amount3 = MathF.Round(Amount2, 2);
                        Console.WriteLine(planetnames[i] + " " + amount3 + " Earth-years old");
                        // break;                                              
                    // }             
            } 


        }
    }
}
