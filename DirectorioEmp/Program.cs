using DirectorioEmp.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear Grados
            Grado grado1 = new Grado(1, "Licenciatura", "Universidad Nacional", "Ingeniería en Informatica",
                                     "Universitario", "Honduras",
                                     new DateTime(2015, 2, 1), new DateTime(2019, 11, 30), DateTime.MaxValue);

            Grado grado2 = new Grado(2, "Licenciatura", "Universidad Autónoma", "Periodismo",
                                     "Postgrado", "Honduras",
                                     new DateTime(2020, 1, 15), new DateTime(2022, 10, 20), DateTime.MaxValue);

            // Crear Cargos
            Cargo cargo1 = new Cargo(1, "Desarrollador ", "TechCorp", "Desarrollo de aplicaciones web",
                                     12000m, new DateTime(2019, 1, 10), new DateTime(2021, 6, 15), false);

            Cargo cargo2 = new Cargo(2, "Líder de Proyecto ", "InnovaSoft", "Gestión de proyectos y equipos",
                                     40000m, new DateTime(2021, 7, 1), DateTime.MaxValue, true);

            // Crear listas
            List<Grado> listaGrados = new List<Grado> { grado1, grado2 };
            List<Cargo> listaCargos = new List<Cargo> { cargo1, cargo2 };

            // Crear Persona

            Persona persona = new Persona("0801-2003-04667", "Owen", "Amador", "2222-3333", "9899-4194",
                                          "Honduras", "Tegucigalpa", "Col. Arturo Quezada ", "Ingeniero",
                                          new DateTime(2003, 2, 11), listaGrados, listaCargos);



            // Mostrar Información
            Console.WriteLine("******Información de la Persona *******");
            Console.WriteLine("ID: " + persona.NumeroID);
            Console.WriteLine("Nombre: " + persona.Nombres + " " + persona.Apellidos);
            Console.WriteLine("Profesión: " + persona.Profesion);
            Console.WriteLine("Fecha de nacimiento: " + persona.FechaNacimiento.ToShortDateString());
            Console.WriteLine("Teléfono: " + persona.Telefono + " Celular: " + persona.Celular);
            Console.WriteLine("Dirección: " + persona.Ciudad + ", " + persona.Pais + ", " + persona.Direccion);
            Console.WriteLine();

            Console.WriteLine("*****Grados Académicos*****");
            foreach (var g in persona.Grados)
            {
            Console.WriteLine(g.NivelEducativo + " en " + g.NombreTitulo + ", " + g.Institucion + " (" + g.FechaInicio.Year + "-" + g.FechaFinal.Year + ")");

            }
            Console.WriteLine();

            Console.WriteLine("*****Cargos Laborales*****");
            foreach (var c in persona.Cargos)
            {
                string estado = c.EmpleoActual ? "Activo" : "Inactivo";       
                Console.WriteLine(c.Titulo + "en " + c.Empresa + " Salario: " + c.Salario + " lps Actualmente: " + estado);
              
            }

            Console.ReadKey();
        }
    }
}
