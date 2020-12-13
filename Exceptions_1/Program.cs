using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exceptions_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = null;
            int n = 9;
            int sum_n = 0;
            int sum_m = 0;
            
            int[] array = null;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Файли і їх дані:");

            for (int i = 0; i < 20; ++i)
            {
                n++;
                file = n + ".txt";
                Console.ForegroundColor = ConsoleColor.Green;

                try
                {
                    string[] strings = File.ReadAllLines(file);
                    array = Array.ConvertAll(strings[0].Split(' '), int.Parse);

                    int multiplication;
                    checked
                    {
                        multiplication = array[0] * array[1];
                    }

                    sum_n += 1;
                    sum_m += multiplication;

                    Console.Write("{0} - ", file);

                    for (int j = 0; j < array.Length; ++j)
                    {
                        Console.Write("{0}; ", array[j]);
                    }

                    Console.Write("multiplication = {0};", multiplication);
                    Console.WriteLine();

                }

                catch (FileNotFoundException fileNotFoundException)
                {
                    using (var files = new StreamWriter(@"Result\no_file.txt", true))
                    {
                        files.WriteLine(file);
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(fileNotFoundException.Message);
                }
                catch (FormatException formatException)
                {
                    using (var files = new StreamWriter(@"Result\bad_data.txt", true))
                    {
                        files.WriteLine(file);
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(formatException.Message);
                }
                catch (OverflowException overflowException)
                {
                    using (var files = new StreamWriter(@"Result\overflow.txt", true))
                    {
                        files.WriteLine(file);
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(overflowException.Message);
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    break;
                }

            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Кількість файлів = {0}; сума добутків = {1}; Середнє арифметичне = {2}.", sum_n, sum_m, sum_m / sum_n);

            //File.Exists("no_file.txt");
            //File.Create(@"bad_data.txt");
            //File.Create(@"overflow.txt");

            Console.ReadKey();

        }
    }
}
