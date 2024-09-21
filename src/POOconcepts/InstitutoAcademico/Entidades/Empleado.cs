using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoAcademico.Entidades
{
    public class Empleado : MiembroDeLaComunidad
    {
        public string Puesto { get; set; }
        public decimal Salario { get; set; }
        public string Horario { get; set; }

        public virtual void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Puesto: {Puesto}");
            Console.WriteLine($"Salario: {Salario:C}");
            Console.WriteLine($"Horario: {Horario}");
        }
    }
}
