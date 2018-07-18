using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaAmed
{
    class Consulta
    {
        //Atributos de la clase
        private DateTime fecha;
        private double montoPagado;
        private int tipoConsulta;
        private Paciente paciente;

        //Constructores
        public Consulta()
        {
            this.fecha = DateTime.Today;
            this.montoPagado = 0;
            this.tipoConsulta = 0;
            this.paciente = null;
        }
        public Consulta(DateTime fec, double monto, int tip, Paciente pac)
        {
            this.fecha = fec;
            this.montoPagado = monto;
            this.tipoConsulta = tip;
            this.paciente = pac;
        }

        //Propiedades
        public DateTime pFecha
        {
            set { this.fecha = value; }
            get { return this.fecha; }
        }
        public double pMonto
        {
            set { this.montoPagado = value; }
            get { return this.montoPagado; }
        }
        public int pTipo
        {
            set { this.tipoConsulta = value; }
            get { return this.tipoConsulta; }
        }
        public Paciente pPaciente
        {
            set { this.paciente = value; }
            get { return this.paciente; }
        }

        //Metodos
        public string toStringConsulta()
        {
            string tip = null;

            if (this.tipoConsulta == 1)
            {
                tip = "Nuevo";
            } else
                tip = "Paciente regular";

            return "Fecha Consulta: " + this.fecha + "\n" + "Monto: " + this.montoPagado +
                   "\n" + "Tipo Consulta: " + tip + "\n" + "Paciente: " + paciente.toStringPaciente();
        }
    }
}
