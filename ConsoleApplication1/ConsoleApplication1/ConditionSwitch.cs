using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ConditionSwitch: Command
    {
       public override bool CanExecute( string Input)
        {
            if (Input.Contains("condition") && Input.Contains("turn"))
            {
                return true;
            }
            return false;
        }



        public override void Excecute(string input)
        {

            string[] words = input.Split(' ');
            string room = words[words.Length - 1];

            if (input.Contains("off"))
            {
                Console.WriteLine("Ok, i'll turn off the condition in the {0}", room);
            }
            else if (input.Contains("on"))
            {
                Console.WriteLine("Ok, I'll turn on the condition in the {0}", room);
            }
            ;
        }

        public override string example()
        {
            return "Turn the condition (ON/OFF) in SomeRoom";
        }
        public override string name()
        {
            return "condition_switcher";
        }
        
    }
}
