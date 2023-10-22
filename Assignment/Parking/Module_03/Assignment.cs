using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    class Assignment
    {
        //public String Parking ( int spots, string pairs)
        //{
        //    int parked = 0;

        //    int[] spotsArray = new int[spots];
        //    string[] pairArray = pairs.Split(" ");
        //    int[] timesArray = new int[pairArray.Length];

        //    for (int i = 0; i < pairArray.Length; i++)
        //    {
        //        int[] temp = Array.ConvertAll((pairArray[i].Split(":")),int.Parse);
        //        timesArray[i] = temp[0] + temp[1];
        //    }

        //    for (int i = 0; i < pairArray.Length; i++)
        //    {
        //        for(int j = 0; j < spotsArray.Length; j++)
        //        {
        //            if (spotsArray[j] == 0 || spotsArray[j] < Convert.ToInt32(pairArray[i].Split(":")[0]))
        //            {
        //                spotsArray[j] = Convert.ToInt32(timesArray[i]);
        //                parked++;
        //                break;
        //            }
        //        }
        //    }

        //    return (pairArray.Length - parked).ToString();
        //}

        public string Parking(int spots, string pairs)
        {
            int parked = 0;
            Queue<int> spotEndTimes = new Queue<int>();

            string[] pairArray = pairs.Split(' ');

            foreach (var pair in pairArray)
            {
                var temp = pair.Split(':');
                if (temp.Length == 2 && int.TryParse(temp[0], out int hours) && int.TryParse(temp[1], out int minutes))
                {
                    var time = hours * 60 + minutes;

                    // Check if any spots have become available
                    while (spotEndTimes.Count > 0 && spotEndTimes.Peek() <= time)
                    {
                        spotEndTimes.Dequeue();
                    }

                    if (spotEndTimes.Count < spots)
                    {
                        // Park the car
                        spotEndTimes.Enqueue(time);
                        parked++;
                    }
                }
            }

            return (pairArray.Length - parked).ToString();
        }
    }
}
