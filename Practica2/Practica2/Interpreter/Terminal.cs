using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Interpreter
{
    public class Terminal : AbstraExpression
    {
        public override void Interpret(Context contex)
        {
            Console.WriteLine("Llamado 'Terminal'()");
        }
    }
}
