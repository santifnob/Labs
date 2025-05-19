using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncionesLINQ
{
    public class FuncionesLinq
    {
        public IEnumerable<string> ObtenerProvinciasQueEmpiezanConDeterminadasLetras(IEnumerable<string> provincias)
        {
            //Forma con lambda expressions (expresiones anonimas)
            //return (provincias.Where(p => p.StartsWith("S") || p.StartsWith('T')));

            //Forma con query expressions
            return(from p in provincias where p.StartsWith("S") || p.StartsWith("T") select p);
            
        }

        public IEnumerable<int> ObtenerNumerosMayoresA20(IEnumerable<int> numeros)
        {
            //var numSelec = from n in numeros where n > 20 select n;
            var numSelec = numeros.Where(x => x > 20);
            return numSelec;
        }

        public IEnumerable<int> ObtenerCodigoPostalDeCiudadesQueTenganEnSuNombreTresCarateresDeterminados(IEnumerable<Ciudad> ciudades, string ciudad)
        {
            //var cidSelec = from c in ciudades where c.Nombre.ToLower().StartsWith(ciudad.ToLower()) select c.CodigoPostal;

            var cidSelec = ciudades.Where(c =>  c.Nombre.ToLower().StartsWith(ciudad.ToLower())).Select(c => c.CodigoPostal);   
            return cidSelec;
        }

        public IEnumerable<Empleado> AgregarEmpleadoListaDevolviendolaOrdenadaPorSueldo(IEnumerable<Empleado> empleados, IEnumerable<Empleado> empleadosParaAgregar, string order)
        {
            empleados = empleados.Concat(empleadosParaAgregar);
            IEnumerable<Empleado> todosEmpleados = null;
            
            if (order.Equals("ASC")){
                todosEmpleados = empleados.OrderBy(e => e.Sueldo);
            }
            else { todosEmpleados = empleados.OrderByDescending(e => e.Sueldo); }

            return (todosEmpleados);
        }
    }
}
