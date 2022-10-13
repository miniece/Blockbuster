using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
    public class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public static void PrintMovies(List<Movie> Movies)
        {
            for (int i = 1; i < Movies.Count; i++)
            {
                Console.WriteLine($" {i}) \t {Movies[i].Title}");
            }
        }
        public virtual void CheckOut(List<Movie> Movies)
        {
            int movieIndex = 0;
            PrintMovies(Movies);

            while(true)
            {
                try
                {
                    Console.WriteLine("Which movie would you like to checkout?");
                    movieIndex = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentOutOfRangeException e1)
                {
                    Console.WriteLine(e1.Message);
                }
                Console.WriteLine($"{movieIndex}: {Movies[movieIndex].Title}");

            }
        }
    }
}
