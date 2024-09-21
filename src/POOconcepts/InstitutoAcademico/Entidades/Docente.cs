using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoAcademico.Entidades
{
   public class Docente : Empleado
    {
        public string Especialidad { get; set; }
        public string GradoAcademico { get; set; }

        public virtual void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Especialidad: {Especialidad}");
            Console.WriteLine($"Grado Académico: {GradoAcademico}");
        }
    }
}
