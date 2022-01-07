using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldTest098;

namespace HelloWorldTest098
{
    class ReplaceWord
    {
        public static void ReadingInputFromUser()
        {
    
            Console.WriteLine("Please enter your UserName");
            string name=Console.ReadLine(); //"5","xyz"
            if(name.Length>=3)
            {
                ReplaceStringWithTemplate(name);
            }
            else
            {
                Console.WriteLine("Please provide your username as atleast 3 characters");
            }
        }

        public static void ReplaceStringWithTemplate(string name)
        {
            string template = "Hello <<UserName>>, How are you?";
            if (template.Contains("<<UserName>>"))
            {
                string result=template.Replace("<<UserName>>", name);
                Console.WriteLine("After replace:"+result);
            }
            else
            {
                Console.WriteLine("UserName not exists");
            }
        }

    }
}
