using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    public class DatosAlumno
    {
        private static List<Alumno> ListaAlumnos = new List<Alumno>()
        {
           new Alumno { Legajo = 10042, Nombre = "Lucia Gomez", Condición = "Aprobado"},
           new Alumno { Legajo = 219230, Nombre = "Luciano Perreira", Condición = "Desaprobado"},
           new Alumno { Legajo = 300392, Nombre = "Juan de Dios", Condición = "Pelotudo"},
        };

        public static Alumno ObtenerPorLegajo(int legajo)
        {
            return ListaAlumnos.FirstOrDefault(a => a.Legajo == legajo);
        }
    }
}