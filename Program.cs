using System.Collections.Immutable;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SeriesAnlyzer
{
 class Program
    {
        static void Main(string[] seriesArr)
        {
            Menu(seriesArr);

            //Main function that displays a menu
            void Menu(string[] seriesArr)
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
                            series = ChangingTheSeries();
                            Console.WriteLine("\nThe series was successfully changed");
                            break;

                        case "b":
                            PrintTheSeries(series);
                            break;

                        case "c":
                                PrintTheSeries(Reverse(series));
                                break;
                            
                        case "d":
                                PrintTheSeries(Sort(series));
                                break; 

                        case "e":
                            Console.WriteLine("\n" + Max(series));
                            break;

                        case "f":
                            Console.WriteLine("\n" + Min(series));
                            break;

                        case "g":
                            Console.WriteLine("\n" + Average(series));
                            break;

                        case "h":
                            Console.WriteLine("\n" + SumOfElements(series));
                            break;

                        case "i":
                            Console.WriteLine("\n" + SumOfAll(series));
                            break;

                        case "j":
                            isRunnig = false;
                            break;
                        default:
                            Console.WriteLine("\nInvalid input");
                            break;
                    }

                }
            }

            //Prints a menu for the series analyzer
            void PrintMenu()
            {
                Console.WriteLine("\nSelect one of the following options:\n"
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
            void PrintTheSeries(List<int> series)
            {
                foreach(int item in series)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("");
            }

            //Allows you to change the series
            List<int> ChangingTheSeries()
            {
                List<int> series = new List<int>();
 
                while (SumOfElements(series) == 0) 
                {
                    Console.WriteLine("\nplease enter a series: ");
                    string input = Console.ReadLine()!;
                    string[] trySeries = input.Split(' ' , ',');
                    if (trySeries.Length >= 3)
                    {
                        series = IfNumbers(trySeries);
                    }
                    else
                    {
                        Console.WriteLine("A series must have at least 3 positive numbers.");
                    }
                }
                return series;
            }

            //receiving a series - If all parameters are positive numbers , returns a list of them, if not, returns an empty list.
            List<int> IfNumbers(string[] trySeries)
            {
                List<int> series = new List<int>();
                List<int> newSeries = new List<int>();
                bool doasANumber = true;
                int number;
                foreach (string s in trySeries)
                {
                    if (int.TryParse(s, out number ) && number >= 0) 
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
                if (doasANumber)
                {
                    series = newSeries;
                    return series;
                }
                else
                {
                    return series;
                }
            }

            
 

            //receiving a series - Returens the series in sorted order.
            List<int> Sort(List<int> series)
            {
                List<int> newSeries = new List<int>();
                for (int i = 0; i < SumOfElements(series); i++)
                {
                    newSeries.Add(series[i]);
                }
                int temp;
                for (int i = 0; i < SumOfElements(newSeries) - 1; i++)
                {
                    for (int j = 0; j < SumOfElements(newSeries) - i - 1; j++)
                    {
                        if (newSeries[j] > newSeries[j + 1])
                        {
                            temp = newSeries[j];
                            newSeries[j] = newSeries[j + 1];
                            newSeries[j + 1] = temp;

                        }
                    }
                }
                return newSeries;
            }

            //receiving a series - Returns the series in reverse
            List<int> Reverse(List <int> series)
            {
                List<int> newSeries = new List<int>();
                for(int i = SumOfElements(series) - 1; i >=0; i--)
                {
                    newSeries.Add(series[i]);
                }  
                return newSeries;
            }

            //receiving a series - Returns the maximum term in the series.
            int Max(List<int> series)
            {
                int max = series[0];
                for (int i = 1; i < SumOfElements(series); i++)
                {
                    if (series[i] > max)
                    {
                        max = series[i];
                    }
                }
                return max;
            }

            //receiving a series - Returns the minimum term in the series.
            int Min(List<int> series)
            {
                int min = series[0];
                for (int i = 1; i < SumOfElements(series); i++)
                {
                    if (series[i] < min)
                    {
                        min = series[i];
                    }
                }
                return min;
            }

            //receiving a series - Returns the sum of the elements in the series
            int SumOfElements(List<int> series)
            {
                int sum = 0;
                foreach(int item in series)
                {
                    sum++;
                }
                return sum;
            }

            //receiving a series - Returns the sum of all elements in a series
            int SumOfAll(List<int> series)
            {
                int sum = 0;
                for (int i = 0; i < SumOfElements(series); i++)
                {
                    sum += series[i];
                }    
                return sum;
            }

            //receiving a series - Returns the average of the array elements
            float Average(List<int> series)
            {
                return (float)SumOfAll(series) / SumOfElements(series) ;
            }            
        }
    }
}

