using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           Excecutor excecuteCommand = new Excecutor();
           for (int i = 0; i < 100; i++) 
           {
           Console.WriteLine("please input next command");
           excecuteCommand.ExcecuteThisCommand(Console.ReadLine());
           } 
        }
    }
}
