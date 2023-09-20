using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class LineaEmergencia
    {
        private int myProperty;

        public LineaEmergencia(int myProperty)
        {
            this.myProperty = myProperty;
        }

        private int MyProperty { get => myProperty; set => myProperty = value; }
    }
}
