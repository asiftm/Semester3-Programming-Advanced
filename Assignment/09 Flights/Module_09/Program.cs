using System;
using System.Collections.Generic;
namespace Module_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int cities = Convert.ToInt32(Console.ReadLine());
                int flights = Convert.ToInt32(Console.ReadLine());

                FindFlightPath findFlightPath = new FindFlightPath(cities*2);

                Dictionary<string, int> city_index = new Dictionary<string, int>();

                int temp = 0;
                for (int i = 0; i < flights; i++)
                {
                    string input = Console.ReadLine();
                    string city1 = input.Split(",")[0].Trim();
                    string city2 = input.Split(",")[1].Trim();

                    if (!city_index.ContainsKey(city1))
                    {
                        city_index[city1] = temp++;
                    }
                    if (!city_index.ContainsKey(city2))
                    {
                        city_index[city2] = temp++;
                    }
                    findFlightPath.AddFlight(city_index[city1], city_index[city2], int.Parse(input.Split(",")[2].Trim()));
                }

                string departure = Console.ReadLine();
                int depIndex = -1;
                string destination = Console.ReadLine();
                int desIndex = -1;

                foreach (var item in city_index)
                {
                    if (item.Key == departure) depIndex = item.Value;
                    if (item.Key == destination) desIndex = item.Value;

                }
                Console.WriteLine(findFlightPath.Dijkstra(depIndex, desIndex));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}