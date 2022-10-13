using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
    public class DVD : Movie
    {
        public int index { get; set; } = 0;
        public DVD(string Title, Categories Category, int RunTime) : base(Title, Category, RunTime)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
        }

        public override void Play()
        {
            Console.WriteLine("What scene would you like to watch?");
            PrintScenes(Scenes);

            try
            {
                index = int.Parse(Console.ReadLine());
                while (index >= 0 && index < Scenes.Count)
                {
                    Console.WriteLine(Scenes[index]);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
    }
}
