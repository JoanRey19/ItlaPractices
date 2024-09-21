using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoAcademico.Entidades
{
    public class Instituto
    {
        public string NombreInstituto {  get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Fundacion { get; set; }

        public void MostrarInstituto()
        {
            Console.WriteLine($"Instituto: {NombreInstituto}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Año de Fundación: {Fundacion}");
        }
    }
}
