using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosPOO
{
    public class EmpleadoContratado : Empleado
    {
        public string DuracionContrato { get; set; }
        public string TipoContrato { get; set; }
        public EmpleadoContratado() { }
        public EmpleadoContratado(string nombre, string puesto, decimal salario, string usuario, string duracioncontrato, string tipocontrato)
        {
            Nombre = nombre;
            Puesto = puesto;
            Salario = salario;
            Usuario = usuario;
            DuracionContrato = duracioncontrato;
            TipoContrato = tipocontrato;
            Activo = true;
        }
    }
}
