using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_List
{
    public class Perro
    {
        //Propiedades
        private string nombre;
        private int edad;
        //Encapsulación
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
