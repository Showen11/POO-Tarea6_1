using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioEmp.Clases
{
    internal class Cargo
    {
        private int numeroCargo;
        private string titulo, empresa, detalles;
        private decimal salario;
        private DateTime fechaInicio, fechaFinal;
        private bool empleoActual;

        // Getters y Setters
        public int NumeroCargo
        {
            get { return numeroCargo; }
            set { numeroCargo = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public string Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }

        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
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

        public bool EmpleoActual
        {
            get { return empleoActual; }
            set { empleoActual = value; }
        }

        // Constructor vacío
        public Cargo() { }

        // Constructor con parámetros
        public Cargo(int numeroCargo, string titulo, string empresa, string detalles,
                     decimal salario, DateTime fechaInicio, DateTime fechaFinal, bool empleoActual)
        {
            this.numeroCargo = numeroCargo;
            this.titulo = titulo;
            this.empresa = empresa;
            this.detalles = detalles;
            this.salario = salario;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.empleoActual = empleoActual;
        }
    }
}
    

