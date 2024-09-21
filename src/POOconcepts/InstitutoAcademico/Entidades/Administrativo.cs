using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoAcademico.Entidades
{
    public class Administrativo : Empleado
    {
        public string Departamento { get; set; }
        public string Cargo { get; set; }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Departamento: {Departamento}");
            Console.WriteLine($"Cargo: {Cargo}");
        }
    }
}
