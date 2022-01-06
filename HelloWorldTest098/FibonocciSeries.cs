
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace HelloWorldTest098
{
    public class FibonocciSeries
    {
        //public int firstNum=0;
        //public int secondNum = 1;
        //public int result = 0;        
        /// <summary>
        /// instances variables 
        /// </summary>
        public int firstNum=0, secondNum=1, result=0;

        public void FindFibonocciSeries()
        {
            Console.WriteLine("Please enter number to generate series");
            //Reading input from user
            int num=Convert.ToInt32(Console.ReadLine());
            result = firstNum + secondNum;

            Console.Write("Series are:" + firstNum + " " + secondNum);
            for(int i=2;i<num;i++)
            {
                firstNum = secondNum;
                secondNum = result;
                Console.Write(" " + result);
                result = firstNum + secondNum; 
            }
            Console.WriteLine();
            
        } 
    }
}
