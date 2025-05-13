using System.Collections.Immutable;

namespace SeriesAnlyzer
{
 class Program
    {
        static void Main(string[] seriesArr)
        {
            menu(seriesArr);

            //Main function that displays a menu
            void menu(string[] seriesArr)
            {
                List<int> series = ListStringToInt(ArrayIntToList(seriesArr));
                bool isRunnig = true;
                while (isRunnig) 
                {
                    PrintMenu();
                    string choice = Console.ReadLine()!;
                    switch (choice)
                    {
                        case "a":
                            series = changingTheSeries();
                            break;

                        case "b":
                            printTheSeries(series);
                            break;

                        case "c":
                                printTheSeries(reverse(series));
                                break;
                            
                        case "d":
                                printTheSeries(sort(series));
                                break; 

                        case "e":
                            Console.WriteLine(max(series));
                            break;

                        case "f":
                            Console.WriteLine(min(series));
                            break;

                        case "g":
                            Console.WriteLine(average(series));
                            break;

                        case "h":
                            Console.WriteLine(sumOfElements(series));
                            break;

                        case "i":
                            Console.WriteLine(sumOfAll(series));
                            break;

                        case "j":
                            isRunnig = false;
                            break;
                    }

                }
            }

            //Prints a menu for the series analyzer
            void PrintMenu()
            {
                Console.WriteLine("Select one of the following options:\n"
                        + "a. Enter a new series of numbers (separate each number with a space)\n"
                        + "b. Print the current series of numbers \n"
                        + "c. Print the current series of numbers in reverse\n" +
                        "d. Print the current series of numbers sorted \n" +
                        "e. Print the highest value in the current series of numbers\n" +
                        "f. Print the lowest value in the current series of numbers\n" +
                        "g. Print the average of the current series of numbers\n" +
                        "h. Print the number of numbers in the series\n" +
                        "i. Print the sum of the total elements in the series\n" +
                        "j. Exit");
            }

            //Converts an array of strings to a list 
            List<string> ArrayIntToList(string[] seriesArr)
            {
                List<string> seriesList = new List<string>();
                foreach (string item in seriesArr)
                {
                    seriesList.Add(item);
                }
                return seriesList;
            }

            //Converts a list of string to a list of int
            List<int> ListStringToInt(List<string> seriesList)
            {
                List<int> series = new List<int>();
                foreach (string item in seriesList)
                {
                    series.Add(Convert.ToInt32(item));
                }
                return series;
            }

            //receiving a series - prints the series
            void printTheSeries(List<int> series)
            {
                foreach(int item in series)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("");
            }

            //Allows you to change the series
            List<int> changingTheSeries()
            {
                List<int> series = new List<int>();
                
                while (sumOfElements(series) == 0) 
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
                    }
                    else
                    {
                        Console.WriteLine("A series must have at least 3 numbers.");
                    }
                }
                return series;
            }

            //receiving a series - Returens the series in sorted order.
            List<int> sort(List<int> series)
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
                for(int i = sumOfElements(series) - 1; i >=0; i--)
                {
                    newSeries.Add(series[i]);
                }  
                return newSeries;
            }

            //receiving a series - Returns the maximum term in the series.
            int max(List<int> series)
            {
                int max = series[0];
                for (int i = 1; i < sumOfElements(series); i++)
                {
                    if (series[i] > max)
                    {
                        max = series[i];
                    }
                }
                return max;
            }

            //receiving a series - Returns the minimum term in the series.
            int min(List<int> series)
            {
                int min = series[0];
                for (int i = 1; i < sumOfElements(series); i++)
                {
                    if (series[i] < min)
                    {
                        min = series[i];
                    }
                }
                return min;
            }

            //receiving a series - Returns the sum of the elements in the series
            int sumOfElements(List<int> series)
            {
                int sum = 0;
                foreach(int item in series)
                {
                    sum++;
                }
                return sum;
            }

            //receiving a series - Returns the sum of all elements in a series
            int sumOfAll(List<int> series)
            {
                int sum = 0;
                for (int i = 0; i < sumOfElements(series); i++)
                {
                    sum += series[i];
                }    
                return sum;
            }

            //receiving a series - Returns the average of the array elements
            int average(List<int> series)
            {
                return sumOfAll(series) / sumOfElements(series) ;
            }
        }
    }
}
