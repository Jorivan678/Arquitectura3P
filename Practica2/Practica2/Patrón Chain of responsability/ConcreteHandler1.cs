using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Chain_of_responsability
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if(request >= 0 && request < 10)
            {
                Console.WriteLine("{0} manejó la solicitud {1}", this.GetType().Name, request);
            }
            else if(successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
