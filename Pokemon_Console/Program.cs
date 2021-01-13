using Pokemon_Console; // statement needed to call 'ProgramUI' class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Console
{
}
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI program = new ProgramUI(); // needed 'new' to define 'program'
            program.Run(); // was missing opening parenthesis
        }
    }
