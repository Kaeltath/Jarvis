using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SendSMS: Command
    {
        public override bool CanExecute(string Input)
        {
            if (Input.Contains("sms") && Input.Contains("send"))
            {
                return true;
            }
            return false;
        }



        public override void Excecute(string input)
        {
           string[] words = input.Split(' ');
           string adresant = "";
                    
           
           for (int i = 0; i < words.Length; i++)
           {
               if (words[i] == "to")
               {
                   adresant = words[i + 1];
                   break;
               }
           }
                    
           int first = input.IndexOf("\"");
           int last = input.LastIndexOf("\"");
           string str2 = input.Substring(first, last - first);
           Console.WriteLine("Ok, I'll Send SMS to {0} with text \"{1}\"",adresant, str2);
           
                    
        }

        public override string example()
        {
            return "Send SMS to {adressant} with this text - :\"  some message \"";
        }
        public override string name()
        {
            return "sms_bot";
        }
    }
}
