using System;
using System.Collections.Generic;

namespace Module_09
{
    class FindFlightPath
    {
        int Cities;
        List<int>[] Map;
        Dictionary<int, int>[] Flights;

        public FindFlightPath(int cities)
        {
            Cities = cities;

            Map = new List<int>[cities];
            for (int i = 0; i < cities; i++)
            {
                Map[i] = new List<int>();
            }

            Flights = new Dictionary<int, int>[cities];
            for (int i = 0; i < cities; i++)
            {
                Flights[i] = new Dictionary<int, int>();
            }
        }
        public void AddFlight(int city1, int city2, int fare)
        {
            if (!Map[city1].Contains(city2))
            {
                Map[city1].Add(city2);
                Flights[city1][city2] = fare;
            }
        }
        public int Dijkstra(int departure, int destination)
        {
            int[] fares = new int[Cities];
            for (int i = 0; i < Cities; i++)
            {
                fares[i] = Int32.MaxValue;
            }

            int[] previous = new int[Cities];

            List<int> visited = new List<int>();

            fares[departure] = 0;

            while (true)
            {
                int CurrentCity = GetNextCity(fares, visited);

                if (CurrentCity == destination) break;

                if (CurrentCity == -1) break;

                visited.Add(CurrentCity); 

                foreach (int neighbor in Map[CurrentCity])
                {
                    
                    int distance = fares[CurrentCity] + Math.Abs(Flights[CurrentCity][neighbor]);

                    if (fares[neighbor] > distance) 
                    {
                        fares[neighbor] = distance; 
                        previous[neighbor] = CurrentCity;
                    }
                }
            }
            return fares[destination];
        }

        private int GetNextCity(int[] fares, List<int> visited)
        {
            int next = -1;
            int min = Int32.MaxValue;

            for (int i = 0; i < Cities; i++)
            {
                if (fares[i] < min && !visited.Contains(i))
                {
                    min = fares[i];
                    next = i;
                }
            }
            return next;
        }
    }
}
