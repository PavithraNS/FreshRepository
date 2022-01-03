using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTest098
{
    /// <summary>
    /// Creating Human blueprint or prototype
    /// </summary>
    public class Human
    {
        /// <summary>
        /// Charactersticts or variables of human being
        /// </summary>
        string name = "Harish";
        double height = 5.6;

        /// <summary>
        /// Behaviour or actions of human being
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Running");
        }
    }
}
