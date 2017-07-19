using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    // описание структуры
    struct City
    {
        public string Name;
        public int Population;
        public int Area;
        public float Destiny;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // ввод исходны данных
            Console.WriteLine("Input cities,their population and areas:");
            string Inputcities = Console.ReadLine();

            int numcity = 0;
            for (int i = 0; i < Inputcities.Length; i++)
            {
                if (Inputcities[i] == ';')
                {
                    numcity++;
                }

            }

            City[] city = new City[numcity];

            string s = "";
            for (int i = 0; i < Inputcities.Length; i++)
            {
                if(Inputcities[i]=='=')
                {
                    city[i].Name = s;
                }
                if (Inputcities[i] == ',')
                {
                    city[i].Population = int.Parse(s);
                }
                if (Inputcities[i] == ';')
                {
                    city[i].Area = int.Parse(s);
                }
            }

            City Pop = new City();
            City Name = new City();
            for (int i = 0; i < city.Length; i++)
            {
                city[i].Destiny = city[i].Area / city[i].Population;

                if (city[i].Population > Pop.Population)
                {
                    Pop.Population = city[i].Population;
                }
                if (city[i].Name.Length > Name.Name)
                {
                    Name.Name= city[i].Name.Length;
                }
            }

            Console.WriteLine("The Most Populated City:",Pop.Name+" "+Pop.Population);
            Console.WriteLine("The Longest Name:",Pop.Name);
            Console.WriteLine("The Destiny");
        }
    }
}

