using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoAcademico.Entidades
{
    public class MiembroDeLaComunidad : Instituto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id { get; set; }
        public string Correo { get; set; }

        public virtual void MostrarDatos()
        {
            base.MostrarInstituto();
            Console.WriteLine($"Nombre: {Nombre} {Apellido}, ID: {Id}");
            Console.WriteLine($"Correo: {Correo}");
           
        }

    }
}
