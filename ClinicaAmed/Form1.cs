using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaAmed
{
    public partial class Form1 : Form
    {
        //Atributos de nuestro Form1, variables auxiliares
        Consulta mayorFemenino70años;
        Consulta mayorFemenino70añosBox;
        Consulta auxC;
        Medico auxM;

        int contadorConsultas = 0;
        int contadorPediatria = 0;
        int contadorClinico = 0;
        int contadorTraumatologo = 0;
        int contadorCardiologo = 0;
        int contadorMenor16 = 0;
        int contadorConsultaPami = 0;
        double porcentajePami = 0;
        double montoPami = 0;//Acumulador del monto de consultas que sean del Pami
        double montoTotalConsulta = 0;
        double montoPed = 0;
        double montoCli = 0;
        double montoTra = 0;
        double montoCar = 0;
        double promedioPed = 0;
        double promedioCli = 0;
        double promedioTra = 0;
        double promedioCar = 0;
        double porcentajeMenor16 = 0;//Variable que se le asigna el valor del calculo del porcentaje de menores de 16 que se atienden de manera particular por NO pediatras
        double promedioConsultasPami = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();//Nueva instancia de consulta
            Medico medico = new Medico();//Nueva instancia de medico
            //Asignamos valor a nuetros objetos auxiliares
            auxC = consulta;
            auxM = medico;

            ++contadorConsultas;//Consultas totales realizadas
            consulta.pPaciente = new Paciente();//Nueva instancia del atributo Paciente de nuestra Consulta

            //Cargamos datos del paciente
            consulta.pPaciente.pNombre = txtNombrePaciente.Text;
            consulta.pPaciente.pApellido = txtApellidoPaciente.Text;
            consulta.pPaciente.pDocumento = Convert.ToInt64(txtNroDocumento.Text);
            consulta.pPaciente.pSexo = rbtnMasculino.Checked;
            consulta.pPaciente.pTelefono = txtTelefonoPaciente.Text;
            consulta.pPaciente.pNacimiento = dpckNacimientoPaciente.Value;
            consulta.pPaciente.pObraSocial = cboObraSocial.SelectedIndex + 1;

            //cargamos datos del medico
            medico.pNombre = txtNombreMedico.Text;
            medico.pApellido = txtApellidoMedico.Text;
            medico.pMatricula = Convert.ToInt32(txtMatricula.Text);
            medico.pNacimiento = dtpckMedico.Value;
            medico.pTelefono = txtTelefonoMedico.Text;
            medico.pEspecialidad = cboEspecialidad.SelectedIndex + 1;

            //cargamos datos de la consulta en si
            consulta.pFecha = dtpckConsulta.Value;
            consulta.pMonto = Convert.ToDouble(txtMontoConsulta.Text);
            consulta.pTipo = cboTipoConsulta.SelectedIndex + 1;

            //Monto total de las consultas realizadas
            montoTotalConsulta += consulta.pMonto;

            //Verificamos la especialidad de nuestro medico para sumar al contador correspondiente
            //y acumular los montos por especialidad
            if (medico.pEspecialidad == 1)
            {
                contadorPediatria++;
                montoPed += consulta.pMonto;
            }
            else if (medico.pEspecialidad == 2)
            {
                contadorClinico++;
                montoCli += consulta.pMonto;
            }
            else if (medico.pEspecialidad == 3)
            {
                contadorTraumatologo++;
                montoTra += consulta.pMonto;
            }
            else
            {
                contadorCardiologo++;
                montoCar += consulta.pMonto;
            }
            //Realizamos los calculos del promedio por especialidad
            promedioPed = Math.Round(montoPed / contadorPediatria);
            promedioCli = Math.Round(montoCli / contadorClinico);
            promedioTra = Math.Round(montoTra / contadorTraumatologo);
            promedioCar = Math.Round(montoCar / contadorCardiologo);

            //Calculamos la consulta mas cara del paciente femenino mayor a 70 años
            if (contadorConsultas == 1)
            {
                mayorFemenino70años = consulta;
            }
                
            if ((consulta.pMonto > mayorFemenino70años.pMonto))
            {
                mayorFemenino70años.pMonto = consulta.pMonto;
            }
            if ((consulta.pPaciente.calcularEdad(consulta.pPaciente.pNacimiento) > 70) &&
                (consulta.pPaciente.pSexo == false))
            {

                    mayorFemenino70años.pPaciente = consulta.pPaciente;
                    mayorFemenino70añosBox = mayorFemenino70años;

            }
            

            //Calculamos niños -16 que se atienden de forma particular con NO pediatras
            if ((consulta.pPaciente.calcularEdad(consulta.pPaciente.pNacimiento) < 16) &&
                (consulta.pPaciente.pObraSocial == 1) &&
                (medico.pEspecialidad != 1))
            {
                contadorMenor16++;
            }
            porcentajeMenor16 = (contadorMenor16 * 100) / contadorConsultas;

            //Porcentaje en monto y cantidad de consulta pami
            if (consulta.pPaciente.pObraSocial == 3)
            {
                ++contadorConsultaPami;
                montoPami += consulta.pMonto;
            }
            porcentajePami = (contadorConsultaPami * 100) / contadorConsultas;
            promedioConsultasPami = Math.Round(montoPami / contadorConsultaPami);

            MessageBox.Show("Se realizo el registro con exito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string mostrar = "PACIENTE y CONSULTA" + "\n\n" +
                            auxC.pPaciente.toStringPaciente() + "\n\n" + 
                            "MEDICO" + "\n\n" +
                            auxM.toStringMedico();

            MessageBox.Show(mostrar, "Datos de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCalculos_Click(object sender, EventArgs e)
        {
            string puntoA1 = "-Cantidad de consultas: " + contadorConsultas + "\n";
            string puntoA2 = "-Monto total de las consultas: " + montoTotalConsulta + "$" + "\n";
            string puntoB = "-Promedio del monto por especialidad: " + "\n";
            string puntoB1 = "*Pediatria: " + promedioPed + "$" + "\n";
            string puntoB2 = "*Clinica: " + promedioCli + "$" + "\n";
            string puntoB3 = "*Traumatologia: " + promedioTra + "$" + "\n";
            string puntoB4 = "*Cardiologia: " + promedioCar + "$" + "\n";
            string puntoD = "-Menores 16 años, particular, no pediatras: " + porcentajeMenor16 + "%" + "\n";
            string puntoE = "-Porcentaje consultas Pami: " + porcentajePami + "%" + "\n";
            string puntoE1 = "-Promedio consultas Pami: " + promedioConsultasPami + "$" + "\n";

            if (mayorFemenino70añosBox != null)
            {
                string puntoC = mayorFemenino70añosBox.pPaciente.toStringPaciente() + "\n";
                string total = puntoA1 + puntoA2 + puntoB + puntoB1 + puntoB2 + puntoB3 + puntoB4 + puntoC + puntoD + puntoE + puntoE1;

                MessageBox.Show(total, "Calculos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (mayorFemenino70añosBox == null)
            {
            string total2 = puntoA1 + puntoA2 + puntoB + puntoB1 + puntoB2 + puntoB3 + puntoB4 + puntoD + puntoE + puntoE1;
            MessageBox.Show(total2, "Calculos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
