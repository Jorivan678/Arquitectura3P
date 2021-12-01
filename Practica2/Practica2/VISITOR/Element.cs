using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.VISITOR
{
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
