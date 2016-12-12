using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Excecutor
    {
        public string[] log = new string[10];
        public int counter = 0;

        public void ExcecuteThisCommand(string _input){
         Command[] listofcommands = new Command[6];
            {
                listofcommands[0] = new LightSwitch();
                listofcommands[1] = new ConditionSwitch();
                listofcommands[2] = new SendSMS();
                listofcommands[3] = new SendMail();
                listofcommands[4] = new Listofnames();
                listofcommands[5] = new Help();
            }
            for (int i = 0; i < 100; i++)
            {
                _input = _input.ToLower();
                if (_input == "log")
                {
                    for (int m = 0 ; m <= counter; m++)
                    {
                        Console.WriteLine(log[m]);
                    }
                }
                else
                {
                    for (int j = 0; j < listofcommands.Length; j++)
                    {
                        if (listofcommands[j].CanExecute(_input))
                        {
                            listofcommands[j].Excecute(_input);
                            log[counter] = listofcommands[j].name();
                            counter++;
                            return;
                        }
                        continue;
                    }
                }
           }
            
        }
    }
}
