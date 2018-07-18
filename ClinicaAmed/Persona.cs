using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaAmed
{
     abstract class Persona
    {
        //Atributos de la clase
        private string nombre;
        private string apellido;
        private DateTime fecha_nacimiento;
        private int edad;

        //Constructores
        public Persona()
        {
            this.nombre = "";
            this.apellido = "";
            this.fecha_nacimiento = DateTime.Today;
            this.edad = 0;
        }

        public Persona(string nom, string ape, DateTime nac)
        {
            this.nombre = nom;
            this.apellido = ape;
            this.fecha_nacimiento = nac;
            this.edad = 0;
        }

        //Propiedades
        public string pNombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }
        public string pApellido
        {
            set { this.apellido = value; }
            get { return this.apellido; }
        }
        public DateTime pNacimiento
        {
            set { this.fecha_nacimiento = value; }
            get { return this.fecha_nacimiento; }
        }

        //Metodos
        public int calcularEdad(DateTime fecha)
        {
            int año = DateTime.Now.Year - fecha_nacimiento.Year;
            int mes = DateTime.Now.Month - fecha_nacimiento.Month;
            int dia = DateTime.Now.Day - fecha_nacimiento.Day;

            if (mes < 0)
            {
                return año - 1;
            }
            else if (mes == 1)
            {
                return dia <= 0 ? año : año - 1;
            }
            else
            {
                return año;
            }
        }
        
        public string toStringPersona()
        {
            return "Nombre: " + this.nombre + "\n" + "Apellido: " + this.apellido + "\n" + "Fecha Nacimiento: " + this.fecha_nacimiento + 
                   "\n" + "Edad: " + calcularEdad(fecha_nacimiento) + " años";
        }
    }
}
