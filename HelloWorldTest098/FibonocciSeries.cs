
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //0 1 1 2 3

        public void FindFibonocciSeries()
        {
            Console.WriteLine("Please enter number to generate series");
            //string num = Console.ReadLine();
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User number is: "+num);
            result = firstNum + secondNum;
            Console.Write("Series are:" + firstNum + " " + secondNum);
            for(int i=2;i<num;i++)
            {
                firstNum = secondNum;
                secondNum = result;
                Console.Write(" " + result);
                result = firstNum + secondNum;
                
            }
            
        }


        
    }
}
