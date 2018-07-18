using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaAmed
{
    class Paciente : Persona
    {
        //Atributos de la clase
        private long nro_documento;
        private bool sexo;
        private string telefono;
        private int obraSocial;

        //Constructores
        public Paciente() : base()
        {
            this.nro_documento = 0;
            this.sexo = false;
            this.telefono = "";
            this.obraSocial = 0;
        }

        public Paciente(string nom, string ape, int doc, bool sex, string tel, DateTime nac, int obra)
                        : base(nom, ape, nac)
        {
            this.nro_documento = doc;
            this.sexo = sex;
            this.telefono = tel;
            this.obraSocial = obra;
        }

        //Propiedades

        //Las propiedades de nombre y apellido
        //ya estan heredadas de Persona, no hace falta escribirlas
        public long pDocumento
        {
            set { this.nro_documento = value; }
            get { return this.nro_documento; }
        }
        public bool pSexo
        {
            set { this.sexo = value; }
            get { return this.sexo; }
        }
        public string pTelefono
        {
            set { this.telefono = value; }
            get { return this.telefono; }
        }
        public int pObraSocial
        {
            set { this.obraSocial = value; }
            get { return this.obraSocial; }
        }

        //Metodos
        public string toStringPaciente()
        {
            string obras = null;
            string sex = null;

            if (this.sexo == true)
            {
                sex = "Masculino";
            }
            else
            {
                sex = "Femenino";
            }

            switch (this.obraSocial)
            {
                case 1: obras = "Particular";
                    break;
                case 2: obras = "Appros";
                    break;
                case 3: obras = "Pami";
                    break;
                case 4: obras = "Ospid";
                    break;
                default: obras = "xxx";
                    break;
            }

            return base.toStringPersona() + "\n" + "Nro documento: " + this.nro_documento + "\n" + "Sexo: " + sex + "\n" +
                   "Telefono: " + this.telefono + "\n" + "Obra social: " + obras;
        }
    }
}
