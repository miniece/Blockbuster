using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
    public enum Categories
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action

    }
    public abstract class Movie
    {
        public string Title { get; set; }
        public Categories Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; } = new List<string>();

        public Movie(string Title, Categories Category, int RunTime)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            Scenes.Add("Bad Movie Trailers");
        }


        public abstract void Play();

        public static void PrintInfo(Movie m)
        {
            Console.WriteLine($"{m.Title}\nCategory: {m.Category}\nRuntime: {m.RunTime}\n");
        }

        public static string PrintScenes(List<string> Scenes)
        {
            string listScenes = "";
            for (int i = 1; i < Scenes.Count; i++)
            {
                listScenes = $"{Scenes[i]}: {Scenes}";
            }
            return listScenes;

        }


    }
}