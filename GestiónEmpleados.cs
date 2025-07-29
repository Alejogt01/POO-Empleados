using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosPOO
{
    public static class GestiónEmpleados
    {
        private static List<Empleado> empleados = new List<Empleado>();

        public static void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public static List <Empleado> ObtenerEmpleados()
        {
            return empleados;
        }

        public static Empleado BuscarPorNombre(string nombre)
        {
            return empleados.FirstOrDefault(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }

        public static List<Empleado> ObtenerActivos()
        {
            return empleados.Where(e => e.Activo).ToList();
        }

        public static List<Empleado> ObtenerInactivos()
        {
            return empleados.Where(e => !e.Activo).ToList();
        }
    }
}
