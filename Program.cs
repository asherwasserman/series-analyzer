namespace SeriesAnlyzer
{
 class Program
    {
        static void Main(string[] args)
        {

            //Main function that displays a menu
            void menu()
            {

            }


            //Allows you to change the series
            List<int> changingTheSeries()
            {
                List<int> series = new List<int>();
                bool doasANumber = false;
                while (doasANumber == false) 
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

            }

            //receiving a series - Returns the series in reverse
            List<int> reverse()
            {

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
