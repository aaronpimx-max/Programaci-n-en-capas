using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    public class NegocioAlumno
    {
        public static string Consultar(int Legajo, out Alumno alumno)
        {
            alumno = null;

            if (Legajo <= 0)
            {
                return "Error: el numero debe ser mayor a cero";
            }

            alumno = DatosAlumno.ObtenerPorLegajo(Legajo);

            if (alumno == null)
            {
                return "Aviso: no se encontro a ningún alumno con ese Legajo";
            }

            return "Éxito";
        }
    }
}