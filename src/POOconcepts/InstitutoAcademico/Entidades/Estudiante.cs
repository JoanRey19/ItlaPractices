using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoAcademico.Entidades
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }
        public string Matricula { get; set; }
        public double Promedio { get; set; }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Año de Matrícula: {Matricula}");
            Console.WriteLine($"Promedio: {Promedio}");
        }
    }
}
