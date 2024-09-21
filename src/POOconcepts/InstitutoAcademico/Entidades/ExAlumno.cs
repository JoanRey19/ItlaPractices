using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoAcademico.Entidades
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        public int YearGraduacion { get; set; }
        public string TituloObtenido { get; set; }
        public string EmpresaActual { get; set; }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Año de Graduación: {YearGraduacion}");
            Console.WriteLine($"Título Obtenido: {TituloObtenido}");
            Console.WriteLine($"Empresa Actual: {EmpresaActual}");
        }
    }

}

