using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Chain_of_responsability
{
    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }
}
