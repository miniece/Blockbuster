using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
    public class VHS : Movie
    {
        public int CurrentScene { get; set; }
        public VHS(string Title, Categories Category, int RunTime) : base(Title, Category, RunTime)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
        }

        public override void Play()
        {
            CurrentScene = 0;
            CurrentScene++;
        }
        public virtual int Rewind()
        {
            CurrentScene = 0;
            return CurrentScene;
        }
    }
}
