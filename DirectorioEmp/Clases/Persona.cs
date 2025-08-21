using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioEmp.Clases
{
    internal class Persona
    {
        private string numeroID, nombres, apellidos, telefono, celular, pais, ciudad, direccion, profesion;
        private DateTime fechaNacimiento;

        private List<Grado> grados;
        private List<Cargo> cargos;

        // Gets y Sets
        public string NumeroID
        {
            get { return numeroID; }
            set { numeroID = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public List<Grado> Grados
        {
            get { return grados; }
            set { grados = value; }
        }

        public List<Cargo> Cargos
        {
            get { return cargos; }
            set { cargos = value; }
        }

        // Constructor vacío
        public Persona()
        {
            grados = new List<Grado>();
            cargos = new List<Cargo>();
        }

        // Constructor con parámetros
        public Persona(string numeroID, string nombres, string apellidos, string telefono, string celular,
                       string pais, string ciudad, string direccion, string profesion,
                       DateTime fechaNacimiento, List<Grado> grados, List<Cargo> cargos)
        {
            this.numeroID = numeroID;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.celular = celular;
            this.pais = pais;
            this.ciudad = ciudad;
            this.direccion = direccion;
            this.profesion = profesion;
            this.fechaNacimiento = fechaNacimiento;
            this.grados = grados;
            this.cargos = cargos;
        }
    }
}