using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioEmp.Clases
{
    internal class Grado
    {
        //variables
        private int numeroGrado;
        private string nivelEducativo, institucion, nombreTitulo, tipoGrado, pais;
        private DateTime fechaInicio, fechaFinal, fechaExpiracion;

        // Gets y Sets
        public int NumeroGrado
        {
            get { return numeroGrado; }
            set { numeroGrado = value; }
        }

        public string NivelEducativo
        {
            get { return nivelEducativo; }
            set { nivelEducativo = value; }
        }

        public string Institucion
        {
            get { return institucion; }
            set { institucion = value; }
        }

        public string NombreTitulo
        {
            get { return nombreTitulo; }
            set { nombreTitulo = value; }
        }

        public string TipoGrado
        {
            get { return tipoGrado; }
            set { tipoGrado = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public DateTime FechaFinal
        {
            get { return fechaFinal; }
            set { fechaFinal = value; }
        }

        public DateTime FechaExpiracion
        {
            get { return fechaExpiracion; }
            set { fechaExpiracion = value; }
        }

        // Constructor vacío
        public Grado() { }

        // Constructor con parámetros
        public Grado(int numeroGrado, string nivelEducativo, string institucion, string nombreTitulo,
                     string tipoGrado, string pais, DateTime fechaInicio, DateTime fechaFinal, DateTime fechaExpiracion)
        {
            this.numeroGrado = numeroGrado;
            this.nivelEducativo = nivelEducativo;
            this.institucion = institucion;
            this.nombreTitulo = nombreTitulo;
            this.tipoGrado = tipoGrado;
            this.pais = pais;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.fechaExpiracion = fechaExpiracion;
        }
    }
}
