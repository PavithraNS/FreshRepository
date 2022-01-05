using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTest098
{
    class ReverseNumber
    {
        public static void FindReverse()
        {
            //123
            Console.WriteLine("Enter a No. to reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            decimal y = 10.25M;
            //Number=123
            while (Number > 0)
            {
                //remainder=3 ,2
                int remainder = Number % 10; //1
                Reverse = (Reverse * 10) + remainder; //Reverse=(3*10)+2=(32*10)+1=321;
                Number = Number / 10;
                int res = (int)y / 10;
                
            }
            Console.WriteLine("Converting decimal into int:" + Math.Floor(y));
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
        }

    }
}
