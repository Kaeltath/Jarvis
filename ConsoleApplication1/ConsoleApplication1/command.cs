using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   abstract class Command: IJarvis
    {
        
        abstract public bool CanExecute(string i);
        abstract public void Excecute(string i);
        abstract public string example();
        abstract public string name();
        
    }
}
