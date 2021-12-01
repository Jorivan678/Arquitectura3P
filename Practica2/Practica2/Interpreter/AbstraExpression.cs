using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Interpreter
{
    public abstract class AbstraExpression
    {
        public abstract void Interpret(Context contex);
    }
}
