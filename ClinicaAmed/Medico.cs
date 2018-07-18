using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaAmed
{
    class Medico : Persona
    {
        //Atributos de la clase
        private int matricula;
        private string telefono;
        private int especialidad;

        //Constructores
        public Medico() : base ()
        {
            this.matricula = 0;
            this.telefono = "";
            this.especialidad = 0;
        }

        public Medico(string nom, string ape, DateTime nac, int mat, string tel, int espe)
                     : base(nom,ape,nac)
        {
            this.matricula = mat;
            this.telefono = tel;
            this.especialidad = espe;
        }

        //Propiedades
        public int pMatricula
        {
            set { this.matricula = value; }
            get { return this.matricula; }
        }
        public string pTelefono
        {
            set { this.telefono = value; }
            get { return this.telefono; }
        }
        public int pEspecialidad
        {
            set { this.especialidad = value; }
            get { return this.especialidad; }
        }

        //Metodos
        public string toStringMedico()
        {
            string esp = null;
            switch (this.especialidad)
            {
                case 1: esp = "Pediatra";
                    break;
                case 2: esp = "Clinico";
                    break;
                case 3: esp = "Traumatologo";
                    break;
                case 4: esp = "Cardiologo";
                    break;
                default:  esp = "xxx";
                    break;
            }
            return base.toStringPersona() + "Matricula: " + this.matricula + "\n" + "Telefono: " + this.telefono + "\n" + "Epecialidad: " + esp;
        }
    }
}
