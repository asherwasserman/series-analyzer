using System.Collections.Immutable;

namespace SeriesAnlyzer
{
 class Program
    {
        static void Main(string[] seriesArr)
        {
            List<int> series = new List<int>();
            for (int i = 0; i < seriesArr.Length; i++)
            {
                int num = Convert.ToInt32(seriesArr[i]);
                series.Add(num);
            }

            //Main function that displays a menu
            void menu()
            {

            }


            //Allows you to change the series
            List<int> changingTheSeries()
            {
                List<int> series = new List<int>();
                bool doasANumber = false;
                while (doasANumber == false && series.Count < 3) 

                {
                    Console.WriteLine("please enter a series: ");
                    string input = Console.ReadLine()!;
                    string[] trySeries = input.Split(' ' , ',');
                    int number;
                    foreach (string s in trySeries)
                    {
                        doasANumber = int.TryParse(s, out number);
                        series.Add(number);
                        if (doasANumber == false)
                        {
                            Console.WriteLine("Invalid series");
                            break;
                        }
                    }
                }
                return series;

            }

            //receiving a series - Returens the series in sorted order.
            List<int> sort()
            {
                List<int> newSeries = new List<int>();
                for(int i = 0;i < series.Count; i++)
                {
                    newSeries.Add(series[i]);
                }
                return newSeries;
            }

            //receiving a series - Returns the series in reverse
            List<int> reverse(List <int> series)
            {
                List<int> newSeries = new List<int>();
                for(int i = series.Count; i >=0; i--)
                {
                    newSeries.Add(series[i]);
                }  
                return newSeries;
            }

            //receiving a series - Returns the maximum term in the series.
            int max()
            {

            }

            //receiving a series - Returns the minimum term in the series.
            int min()
            {

            }

            //receiving a series - Returns the sum of the elements in the series
            int sumOfElements()
            {

            }

            //receiving a series - Returns the sum of all elements in a series
            int sumOfAll()
            {

            }

            //receiving a series - Returns the average of the array elements
            int average()
            {

            }
        }
    }
}
