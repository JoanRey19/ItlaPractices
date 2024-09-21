
using InstitutoAcademico.Entidades;

MiembroDeLaComunidad miembro1 = new MiembroDeLaComunidad
{
    Nombre = "Pedro",
    Apellido = "Vargas",
    Id = 001,
    Correo = "PedroVargas@Gmail.com"
};


Instituto instituto = new Instituto
{
    NombreInstituto = "Instituto Educativo",
    Direccion = "Calle Principal 123",
    Telefono = "123-456-7890",
    Fundacion = 2000
};


instituto.MostrarInstituto();

Estudiante estudiante = new Estudiante
{
    Carrera = "Desarrollo de software",
    Matricula = "2023-1131",
    Promedio = 90
};


estudiante.MostrarDatos();


Empleado empleado = new Empleado
{
    Puesto = "Profesor",
    Salario = 60000,
    Horario = "Lunes a viernes de 8am a 4pm"
};
empleado.MostrarDatos();


Docente docente = new Docente
{
    Especialidad = "Matemáticas",
    GradoAcademico = "Máster"

};

docente.MostrarDatos();


ExAlumno exAlumno = new ExAlumno
{
     YearGraduacion = 2020,
    TituloObtenido = "Licenciatura en Desarrollo de Software",
     EmpresaActual  = "Tech Solutions"
};

exAlumno.MostrarDatos();

