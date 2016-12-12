using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Help: Command
    {

        public override bool CanExecute(string i)
        {
            string[] words = i.Split(' ');
            string command = words[0];
            if (command == "help") 
            {
                return true;
            }
            return false;
        }

        public override void Excecute(string i)
        {
            Command[] names = new Command[4];
            {
                names[0] = new LightSwitch();
                names[1] = new ConditionSwitch();
                names[2] = new SendSMS();
                names[3] = new SendMail();
            }
            for (int k = 0; k < names.Length; k++) 
            {
                if (i.Contains(names[k].name())) 
                {
                    Console.WriteLine(names[k].example());
                    return;
                }
            }
            foreach (Command element in names)
            {
                Console.WriteLine(element.example());
            }
            Console.ReadLine();
        }

        public override string example()
        {
             return "Turn the condition (ON/OFF) in SomeRoom";
        }

        public override string name()
        {
            return "help"; 
        }
    }
}
