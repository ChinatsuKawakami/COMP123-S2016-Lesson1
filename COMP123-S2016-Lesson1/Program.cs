using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the hello workd to console Method
            HelloWorldToConsole();
        }      
        //This is my helloworld method
        //method HelloworldToConsole
        //return {string} HelloworldString
            public static string HelloWorldToConsole()
            {
            string HelloWorldString ="Hello,world!";
                Console.WriteLine(HelloWorldString);
                return HelloWorldString;
            }

        }
    }

