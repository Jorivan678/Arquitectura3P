using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Observer
{
    public class ConcreteObserver : Observer
    {
        private string nombre;
        private string observerState;
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject, string nombre)
        {
            this.subject = subject;
            this.nombre = nombre;
        }

        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine($"El nuevo estado del observador {nombre} es {observerState}");
        }

        //Obtiene o establece el sujeto

        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}
