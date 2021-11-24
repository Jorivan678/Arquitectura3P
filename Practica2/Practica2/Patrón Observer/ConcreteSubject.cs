using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Observer
{
    public class ConcreteSubject : Subject
    {
        private string subjectState;

        //Obtiene o establece el estado del sujeto

        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
}
