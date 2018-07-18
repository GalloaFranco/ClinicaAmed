namespace ClinicaAmed
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMontoConsulta = new System.Windows.Forms.TextBox();
            this.lblFechaConsulta = new System.Windows.Forms.Label();
            this.lblMontoConsulta = new System.Windows.Forms.Label();
            this.cboTipoConsulta = new System.Windows.Forms.ComboBox();
            this.lblTipoConsulta = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.txtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.txtTelefonoPaciente = new System.Windows.Forms.TextBox();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.dpckNacimientoPaciente = new System.Windows.Forms.DateTimePicker();
            this.cboObraSocial = new System.Windows.Forms.ComboBox();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblApellidoPaciente = new System.Windows.Forms.Label();
            this.lblSexoPaciente = new System.Windows.Forms.Label();
            this.lblTelefonoPaciente = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblTipoObraSocial = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCalculos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpckMedico = new System.Windows.Forms.DateTimePicker();
            this.txtTelefonoMedico = new System.Windows.Forms.TextBox();
            this.txtApellidoMedico = new System.Windows.Forms.TextBox();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpckConsulta = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMontoConsulta
            // 
            this.txtMontoConsulta.Location = new System.Drawing.Point(887, 390);
            this.txtMontoConsulta.Name = "txtMontoConsulta";
            this.txtMontoConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtMontoConsulta.TabIndex = 15;
            // 
            // lblFechaConsulta
            // 
            this.lblFechaConsulta.AutoSize = true;
            this.lblFechaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaConsulta.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFechaConsulta.Location = new System.Drawing.Point(788, 349);
            this.lblFechaConsulta.Name = "lblFechaConsulta";
            this.lblFechaConsulta.Size = new System.Drawing.Size(92, 15);
            this.lblFechaConsulta.TabIndex = 3;
            this.lblFechaConsulta.Text = "Fecha Consulta";
            // 
            // lblMontoConsulta
            // 
            this.lblMontoConsulta.AutoSize = true;
            this.lblMontoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoConsulta.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMontoConsulta.Location = new System.Drawing.Point(791, 392);
            this.lblMontoConsulta.Name = "lblMontoConsulta";
            this.lblMontoConsulta.Size = new System.Drawing.Size(42, 15);
            this.lblMontoConsulta.TabIndex = 4;
            this.lblMontoConsulta.Text = "Monto";
            // 
            // cboTipoConsulta
            // 
            this.cboTipoConsulta.FormattingEnabled = true;
            this.cboTipoConsulta.Items.AddRange(new object[] {
            "Primera vez",
            "Paciente del profesional"});
            this.cboTipoConsulta.Location = new System.Drawing.Point(887, 437);
            this.cboTipoConsulta.Name = "cboTipoConsulta";
            this.cboTipoConsulta.Size = new System.Drawing.Size(121, 21);
            this.cboTipoConsulta.TabIndex = 16;
            // 
            // lblTipoConsulta
            // 
            this.lblTipoConsulta.AutoSize = true;
            this.lblTipoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConsulta.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTipoConsulta.Location = new System.Drawing.Point(791, 440);
            this.lblTipoConsulta.Name = "lblTipoConsulta";
            this.lblTipoConsulta.Size = new System.Drawing.Size(82, 15);
            this.lblTipoConsulta.TabIndex = 6;
            this.lblTipoConsulta.Text = "Tipo Consulta";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(142, 326);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(121, 20);
            this.txtNombrePaciente.TabIndex = 0;
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.Location = new System.Drawing.Point(142, 369);
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoPaciente.TabIndex = 1;
            // 
            // txtTelefonoPaciente
            // 
            this.txtTelefonoPaciente.Location = new System.Drawing.Point(142, 489);
            this.txtTelefonoPaciente.Name = "txtTelefonoPaciente";
            this.txtTelefonoPaciente.Size = new System.Drawing.Size(121, 20);
            this.txtTelefonoPaciente.TabIndex = 5;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(142, 456);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtnFemenino.TabIndex = 3;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(251, 456);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 4;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // dpckNacimientoPaciente
            // 
            this.dpckNacimientoPaciente.Location = new System.Drawing.Point(142, 535);
            this.dpckNacimientoPaciente.Name = "dpckNacimientoPaciente";
            this.dpckNacimientoPaciente.Size = new System.Drawing.Size(200, 20);
            this.dpckNacimientoPaciente.TabIndex = 6;
            // 
            // cboObraSocial
            // 
            this.cboObraSocial.FormattingEnabled = true;
            this.cboObraSocial.Items.AddRange(new object[] {
            "PARTICULAR",
            "APPROS",
            "PAMI",
            "OSPID"});
            this.cboObraSocial.Location = new System.Drawing.Point(142, 576);
            this.cboObraSocial.Name = "cboObraSocial";
            this.cboObraSocial.Size = new System.Drawing.Size(121, 21);
            this.cboObraSocial.TabIndex = 7;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePaciente.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNombrePaciente.Location = new System.Drawing.Point(31, 333);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(52, 15);
            this.lblNombrePaciente.TabIndex = 14;
            this.lblNombrePaciente.Text = "Nombre";
            // 
            // lblApellidoPaciente
            // 
            this.lblApellidoPaciente.AutoSize = true;
            this.lblApellidoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaciente.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblApellidoPaciente.Location = new System.Drawing.Point(31, 376);
            this.lblApellidoPaciente.Name = "lblApellidoPaciente";
            this.lblApellidoPaciente.Size = new System.Drawing.Size(51, 15);
            this.lblApellidoPaciente.TabIndex = 15;
            this.lblApellidoPaciente.Text = "Apellido";
            // 
            // lblSexoPaciente
            // 
            this.lblSexoPaciente.AutoSize = true;
            this.lblSexoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoPaciente.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSexoPaciente.Location = new System.Drawing.Point(31, 460);
            this.lblSexoPaciente.Name = "lblSexoPaciente";
            this.lblSexoPaciente.Size = new System.Drawing.Size(35, 15);
            this.lblSexoPaciente.TabIndex = 16;
            this.lblSexoPaciente.Text = "Sexo";
            // 
            // lblTelefonoPaciente
            // 
            this.lblTelefonoPaciente.AutoSize = true;
            this.lblTelefonoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoPaciente.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTelefonoPaciente.Location = new System.Drawing.Point(31, 496);
            this.lblTelefonoPaciente.Name = "lblTelefonoPaciente";
            this.lblTelefonoPaciente.Size = new System.Drawing.Size(55, 15);
            this.lblTelefonoPaciente.TabIndex = 17;
            this.lblTelefonoPaciente.Text = "Telefono";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNacimiento.Location = new System.Drawing.Point(29, 540);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(107, 15);
            this.lblNacimiento.TabIndex = 18;
            this.lblNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblTipoObraSocial
            // 
            this.lblTipoObraSocial.AutoSize = true;
            this.lblTipoObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoObraSocial.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTipoObraSocial.Location = new System.Drawing.Point(29, 582);
            this.lblTipoObraSocial.Name = "lblTipoObraSocial";
            this.lblTipoObraSocial.Size = new System.Drawing.Size(69, 15);
            this.lblTipoObraSocial.TabIndex = 19;
            this.lblTipoObraSocial.Text = "Obra social";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitulo2.Location = new System.Drawing.Point(138, 281);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(132, 20);
            this.lblTitulo2.TabIndex = 20;
            this.lblTitulo2.Text = "Datos Paciente";
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitulo1.Location = new System.Drawing.Point(865, 290);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(133, 20);
            this.lblTitulo1.TabIndex = 21;
            this.lblTitulo1.Text = "Datos Consulta";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(785, 593);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(90, 68);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(883, 593);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(90, 68);
            this.btnMostrar.TabIndex = 18;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCalculos
            // 
            this.btnCalculos.FlatAppearance.BorderSize = 0;
            this.btnCalculos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculos.Location = new System.Drawing.Point(979, 593);
            this.btnCalculos.Name = "btnCalculos";
            this.btnCalculos.Size = new System.Drawing.Size(90, 68);
            this.btnCalculos.TabIndex = 19;
            this.btnCalculos.Text = "Ver Calculos";
            this.btnCalculos.UseVisualStyleBackColor = true;
            this.btnCalculos.Click += new System.EventHandler(this.btnCalculos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(396, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fecha Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(396, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(396, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(396, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nombre";
            // 
            // dtpckMedico
            // 
            this.dtpckMedico.Location = new System.Drawing.Point(512, 454);
            this.dtpckMedico.Name = "dtpckMedico";
            this.dtpckMedico.Size = new System.Drawing.Size(200, 20);
            this.dtpckMedico.TabIndex = 11;
            // 
            // txtTelefonoMedico
            // 
            this.txtTelefonoMedico.Location = new System.Drawing.Point(512, 498);
            this.txtTelefonoMedico.Name = "txtTelefonoMedico";
            this.txtTelefonoMedico.Size = new System.Drawing.Size(121, 20);
            this.txtTelefonoMedico.TabIndex = 12;
            // 
            // txtApellidoMedico
            // 
            this.txtApellidoMedico.Location = new System.Drawing.Point(512, 371);
            this.txtApellidoMedico.Name = "txtApellidoMedico";
            this.txtApellidoMedico.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoMedico.TabIndex = 9;
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(512, 328);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(121, 20);
            this.txtNombreMedico.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(399, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Especialidad";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Items.AddRange(new object[] {
            "Pediatria",
            "Clinica",
            "Traumatologia",
            "Cardiologia"});
            this.cboEspecialidad.Location = new System.Drawing.Point(512, 537);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cboEspecialidad.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(396, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(512, 411);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(121, 20);
            this.txtMatricula.TabIndex = 10;
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitulo3.Location = new System.Drawing.Point(491, 281);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(119, 20);
            this.lblTitulo3.TabIndex = 38;
            this.lblTitulo3.Text = "Datos Medico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-33, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 120);
            this.panel1.TabIndex = 40;
            // 
            // dtpckConsulta
            // 
            this.dtpckConsulta.Location = new System.Drawing.Point(887, 342);
            this.dtpckConsulta.Name = "dtpckConsulta";
            this.dtpckConsulta.Size = new System.Drawing.Size(200, 20);
            this.dtpckConsulta.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(142, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(495, 199);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDocumento.Location = new System.Drawing.Point(31, 418);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(92, 15);
            this.lblDocumento.TabIndex = 44;
            this.lblDocumento.Text = "Nro documento";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(142, 417);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(121, 20);
            this.txtNroDocumento.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1109, 684);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dtpckConsulta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCalculos);
            this.Controls.Add(this.lblTitulo3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboEspecialidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpckMedico);
            this.Controls.Add(this.txtTelefonoMedico);
            this.Controls.Add(this.txtApellidoMedico);
            this.Controls.Add(this.txtNombreMedico);
            this.Controls.Add(this.lblTitulo1);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblTipoObraSocial);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblTelefonoPaciente);
            this.Controls.Add(this.lblSexoPaciente);
            this.Controls.Add(this.lblApellidoPaciente);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.cboObraSocial);
            this.Controls.Add(this.dpckNacimientoPaciente);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.txtTelefonoPaciente);
            this.Controls.Add(this.txtApellidoPaciente);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.lblTipoConsulta);
            this.Controls.Add(this.cboTipoConsulta);
            this.Controls.Add(this.lblMontoConsulta);
            this.Controls.Add(this.lblFechaConsulta);
            this.Controls.Add(this.txtMontoConsulta);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Amed";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMontoConsulta;
        private System.Windows.Forms.Label lblFechaConsulta;
        private System.Windows.Forms.Label lblMontoConsulta;
        private System.Windows.Forms.ComboBox cboTipoConsulta;
        private System.Windows.Forms.Label lblTipoConsulta;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.TextBox txtApellidoPaciente;
        private System.Windows.Forms.TextBox txtTelefonoPaciente;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.DateTimePicker dpckNacimientoPaciente;
        private System.Windows.Forms.ComboBox cboObraSocial;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblApellidoPaciente;
        private System.Windows.Forms.Label lblSexoPaciente;
        private System.Windows.Forms.Label lblTelefonoPaciente;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblTipoObraSocial;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCalculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpckMedico;
        private System.Windows.Forms.TextBox txtTelefonoMedico;
        private System.Windows.Forms.TextBox txtApellidoMedico;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpckConsulta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtNroDocumento;
    }
}

