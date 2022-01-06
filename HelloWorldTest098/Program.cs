using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTest098
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            //className variale=new className()
            FibonocciSeries series = new FibonocciSeries();
            series.FindFibonocciSeries();
            ReplaceWord.ReadingInputFromUser();
            Console.Read();
        }

    }
}
