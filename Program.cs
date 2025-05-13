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
                
                while (true) 
                {
                    Console.WriteLine("please enter a series: ");
                    string input = Console.ReadLine()!;
                    string[] trySeries = input.Split(' ' , ',');
                    List<int> newSeries = new List<int>();
                    bool doasANumber = true;
                    int number;
                    foreach (string s in trySeries)
                    {
                        if (int.TryParse(s, out number))
                        {
                            newSeries.Add(number);
                        }
                        else
                        {
                            Console.WriteLine("Invalid series");
                            doasANumber = false;
                            break;
                        }
                    }
                    if(doasANumber && newSeries.Count >= 3)
                    {
                        series = newSeries;
                        break;
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
                newSeries.Sort();
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
            int max(List<int> series)
            {
                int max = series[0];
                for (int i = 1; i < series.Count; i++)
                {
                    if (series[i] > max)
                    {
                        max = series[i];
                    }
                }
                return max;
            }

            //receiving a series - Returns the minimum term in the series.
            int min()
            {
                int min = series[0];
                for (int i = 1; i < series.Count; i++)
                {
                    if (series[i] < min)
                    {
                        min = series[i];
                    }
                }
                return min;
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
