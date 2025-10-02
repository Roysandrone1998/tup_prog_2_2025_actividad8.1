using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act8._1.Models
{
    public class Cuenta : IComparable
    {
        public string Nombre {  get; set; }

        public int DNI { get; set; }

        public double Importe { get; set; }
        public Cuenta(string Nombre,int DNI, double Importe) {
        
        this.Nombre = Nombre;
            this.DNI = DNI; 
            this.Importe = Importe;
        }

        public override string ToString()
        {
            return $"cuenta de {Nombre}  \r\n dni {DNI }  \r\n";
        }

        public int CompareTo(object obj)
        {
            Cuenta cuenta = obj as Cuenta;
            if (cuenta != null)
            {
                return this.DNI.CompareTo(cuenta.DNI);
            }
            return -1;
        }
    }
}
