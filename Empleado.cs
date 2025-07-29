using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosPOO
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public decimal Salario { get; set; }
        public string Usuario { get; set; }
        public bool Activo { get; set; } = true;

        public Empleado() { }

        public Empleado(string usuario, string nombre, string puesto, decimal salario)
        {
            Usuario = usuario;
            Nombre = nombre;
            Puesto = puesto;
            Salario = salario;
            Activo = true;
        }

        
    }

}
