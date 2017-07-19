using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Test_1
{
    enum Cities
    {
        
    }

    struct City
    {
        public string NameCity;
        public int PopulationCity;
        public int AreaCity;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input cities,their population and area:");
            string InputCities = Console.ReadLine();
            
            //Input cities
            Console.Write(InputCities);
            Console.WriteLine("=======================");
            

            for (int i = 0; i < InputCities.Length; i++)
            {
                if (i == '=')
                {
                    Console.Write("Name is", InputCities[i]);
                }

                if (i == ',')
                {
                    Console.Write("Population is:", InputCities[i]);
                }
                { 
                if (i == ';') Console.Write("Area is:", InputCities[i]);
                }
                Console.Write(InputCities[i]);
            }


            City[] city = new City[]
            {
                
            };

            

            Console.WriteLine("Most populated:");
            Console.WriteLine("Longest name");
            Console.WriteLine("Density");

        }
    }
}
