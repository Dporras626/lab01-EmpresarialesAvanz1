using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    public class Empleado : Persona
    {
        public double Sueldo { get; set; }

        public double CalcularImpuesto(double impuesto)
        {
            return Sueldo * impuesto / 100;
        }

    }
}
