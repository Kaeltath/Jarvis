using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Listofnames: Command 
    {

        public override bool CanExecute(string i)
        {
            if (i.Contains("commands") && i.Contains("list")) 
            {
                return true;
            }
            return false;
        }

        public override void Excecute(string i)
        {

            Command[] names = new Command[5];
            {
                names[0] = new LightSwitch();
                names[1] = new ConditionSwitch();
                names[2] = new SendSMS();
                names[3] = new SendMail();
                names[4] = new Help();
            }

            foreach (Command element in names)
            {
               Console.WriteLine(element.name());
            }
                                   


        }

        public override string example()
        {
            return "List of Commands - it returns list of Commands O_O";
        }

        public override string name()
        {
            return "list_of_commands";
        }
    }
}
