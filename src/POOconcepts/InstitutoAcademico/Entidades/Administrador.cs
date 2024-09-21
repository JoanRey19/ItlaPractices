using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoAcademico.Entidades
{
    public  class Administrador : Docente
    {
        public string AreaResponsabilidad { get; set; }
        public string NivelAutoridad { get; set; }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Área de Responsabilidad: {AreaResponsabilidad}");
            Console.WriteLine($"Nivel de Autoridad: {NivelAutoridad}");
        }


    }
}
