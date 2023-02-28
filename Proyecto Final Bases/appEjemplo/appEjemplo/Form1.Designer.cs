namespace appEjemplo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcGestion = new System.Windows.Forms.TabControl();
            this.tpRegistroEmp = new System.Windows.Forms.TabPage();
            this.pnlResgistroEmpresa = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnGuardarEmpresa = new System.Windows.Forms.Button();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lbNit = new System.Windows.Forms.Label();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.tpRegistroComp = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTipoDisco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardarComputadora = new System.Windows.Forms.Button();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tpRegistroRepara = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNoExiste = new System.Windows.Forms.RadioButton();
            this.rbExiste = new System.Windows.Forms.RadioButton();
            this.dtpEgreso = new System.Windows.Forms.DateTimePicker();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSerialRep = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRep = new System.Windows.Forms.Button();
            this.txtNitRep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tpConsultar = new System.Windows.Forms.TabPage();
            this.dtpCons = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNitCons = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnConsultarPersonas = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.tpBusqueda = new System.Windows.Forms.TabPage();
            this.lbMostrarCons = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.tbcGestion.SuspendLayout();
            this.tpRegistroEmp.SuspendLayout();
            this.pnlResgistroEmpresa.SuspendLayout();
            this.tpRegistroComp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpRegistroRepara.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tpBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcGestion
            // 
            this.tbcGestion.Controls.Add(this.tpRegistroEmp);
            this.tbcGestion.Controls.Add(this.tpRegistroComp);
            this.tbcGestion.Controls.Add(this.tpRegistroRepara);
            this.tbcGestion.Controls.Add(this.tpConsultar);
            this.tbcGestion.Controls.Add(this.tpBusqueda);
            this.tbcGestion.Location = new System.Drawing.Point(40, 35);
            this.tbcGestion.Name = "tbcGestion";
            this.tbcGestion.SelectedIndex = 0;
            this.tbcGestion.Size = new System.Drawing.Size(645, 390);
            this.tbcGestion.TabIndex = 0;
            // 
            // tpRegistroEmp
            // 
            this.tpRegistroEmp.Controls.Add(this.pnlResgistroEmpresa);
            this.tpRegistroEmp.Location = new System.Drawing.Point(4, 24);
            this.tpRegistroEmp.Name = "tpRegistroEmp";
            this.tpRegistroEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistroEmp.Size = new System.Drawing.Size(637, 362);
            this.tpRegistroEmp.TabIndex = 0;
            this.tpRegistroEmp.Text = "Registro Empresa";
            this.tpRegistroEmp.UseVisualStyleBackColor = true;
            // 
            // pnlResgistroEmpresa
            // 
            this.pnlResgistroEmpresa.Controls.Add(this.txtNombre);
            this.pnlResgistroEmpresa.Controls.Add(this.lbNombre);
            this.pnlResgistroEmpresa.Controls.Add(this.btnGuardarEmpresa);
            this.pnlResgistroEmpresa.Controls.Add(this.txtNit);
            this.pnlResgistroEmpresa.Controls.Add(this.lbNit);
            this.pnlResgistroEmpresa.Controls.Add(this.lbMensaje);
            this.pnlResgistroEmpresa.Location = new System.Drawing.Point(23, 22);
            this.pnlResgistroEmpresa.Name = "pnlResgistroEmpresa";
            this.pnlResgistroEmpresa.Size = new System.Drawing.Size(364, 240);
            this.pnlResgistroEmpresa.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(17, 113);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(54, 15);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre:";
            // 
            // btnGuardarEmpresa
            // 
            this.btnGuardarEmpresa.Location = new System.Drawing.Point(261, 196);
            this.btnGuardarEmpresa.Name = "btnGuardarEmpresa";
            this.btnGuardarEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarEmpresa.TabIndex = 3;
            this.btnGuardarEmpresa.Text = "Guardar";
            this.btnGuardarEmpresa.UseVisualStyleBackColor = true;
            this.btnGuardarEmpresa.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(105, 66);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(159, 23);
            this.txtNit.TabIndex = 2;
            // 
            // lbNit
            // 
            this.lbNit.AutoSize = true;
            this.lbNit.Location = new System.Drawing.Point(17, 69);
            this.lbNit.Name = "lbNit";
            this.lbNit.Size = new System.Drawing.Size(28, 15);
            this.lbNit.TabIndex = 1;
            this.lbNit.Text = "NIT:";
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMensaje.Location = new System.Drawing.Point(17, 25);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(196, 17);
            this.lbMensaje.TabIndex = 0;
            this.lbMensaje.Text = "Digite los datos de la empresa";
            // 
            // tpRegistroComp
            // 
            this.tpRegistroComp.Controls.Add(this.panel1);
            this.tpRegistroComp.Location = new System.Drawing.Point(4, 24);
            this.tpRegistroComp.Name = "tpRegistroComp";
            this.tpRegistroComp.Size = new System.Drawing.Size(637, 362);
            this.tpRegistroComp.TabIndex = 3;
            this.tpRegistroComp.Text = "Registro Computadora";
            this.tpRegistroComp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTipoDisco);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxMarca);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCapacidad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnGuardarComputadora);
            this.panel1.Controls.Add(this.txtSerial);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(22, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 275);
            this.panel1.TabIndex = 1;
            // 
            // txtTipoDisco
            // 
            this.txtTipoDisco.Location = new System.Drawing.Point(163, 179);
            this.txtTipoDisco.Name = "txtTipoDisco";
            this.txtTipoDisco.Size = new System.Drawing.Size(159, 23);
            this.txtTipoDisco.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo Disco Duro:";
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Items.AddRange(new object[] {
            "Lenovo ",
            "Asus",
            "Dell"});
            this.cbxMarca.Location = new System.Drawing.Point(163, 101);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(159, 23);
            this.cbxMarca.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Capacidad Disco Duro:";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(163, 140);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(159, 23);
            this.txtCapacidad.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Marca:";
            // 
            // btnGuardarComputadora
            // 
            this.btnGuardarComputadora.Location = new System.Drawing.Point(286, 236);
            this.btnGuardarComputadora.Name = "btnGuardarComputadora";
            this.btnGuardarComputadora.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarComputadora.TabIndex = 3;
            this.btnGuardarComputadora.Text = "Guardar";
            this.btnGuardarComputadora.UseVisualStyleBackColor = true;
            this.btnGuardarComputadora.Click += new System.EventHandler(this.btnGuardarComputadora_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(163, 59);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(159, 23);
            this.txtSerial.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Número Serial:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(17, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Digite los datos de la computadora";
            // 
            // tpRegistroRepara
            // 
            this.tpRegistroRepara.Controls.Add(this.panel2);
            this.tpRegistroRepara.Location = new System.Drawing.Point(4, 24);
            this.tpRegistroRepara.Name = "tpRegistroRepara";
            this.tpRegistroRepara.Size = new System.Drawing.Size(637, 362);
            this.tpRegistroRepara.TabIndex = 4;
            this.tpRegistroRepara.Text = "Registro Reparación";
            this.tpRegistroRepara.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNoExiste);
            this.panel2.Controls.Add(this.rbExiste);
            this.panel2.Controls.Add(this.dtpEgreso);
            this.panel2.Controls.Add(this.dtpIngreso);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtSerialRep);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnRep);
            this.panel2.Controls.Add(this.txtNitRep);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(40, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 262);
            this.panel2.TabIndex = 1;
            // 
            // rbNoExiste
            // 
            this.rbNoExiste.AutoSize = true;
            this.rbNoExiste.Location = new System.Drawing.Point(215, 186);
            this.rbNoExiste.Name = "rbNoExiste";
            this.rbNoExiste.Size = new System.Drawing.Size(74, 19);
            this.rbNoExiste.TabIndex = 13;
            this.rbNoExiste.TabStop = true;
            this.rbNoExiste.Text = "No Existe";
            this.rbNoExiste.UseVisualStyleBackColor = true;
            // 
            // rbExiste
            // 
            this.rbExiste.AutoSize = true;
            this.rbExiste.Location = new System.Drawing.Point(122, 186);
            this.rbExiste.Name = "rbExiste";
            this.rbExiste.Size = new System.Drawing.Size(55, 19);
            this.rbExiste.TabIndex = 12;
            this.rbExiste.TabStop = true;
            this.rbExiste.Text = "Existe";
            this.rbExiste.UseVisualStyleBackColor = true;
            this.rbExiste.Click += new System.EventHandler(this.rbExiste_Click);
            // 
            // dtpEgreso
            // 
            this.dtpEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEgreso.Location = new System.Drawing.Point(122, 182);
            this.dtpEgreso.Name = "dtpEgreso";
            this.dtpEgreso.Size = new System.Drawing.Size(177, 23);
            this.dtpEgreso.TabIndex = 11;
            this.dtpEgreso.Value = new System.DateTime(2023, 1, 28, 10, 16, 58, 0);
            this.dtpEgreso.Visible = false;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(122, 142);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(177, 23);
            this.dtpIngreso.TabIndex = 10;
            this.dtpIngreso.Value = new System.DateTime(2023, 1, 28, 11, 15, 9, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Fecha de Egreso:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Fecha de Ingreso:";
            // 
            // txtSerialRep
            // 
            this.txtSerialRep.Location = new System.Drawing.Point(122, 105);
            this.txtSerialRep.Name = "txtSerialRep";
            this.txtSerialRep.Size = new System.Drawing.Size(177, 23);
            this.txtSerialRep.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Número Serial:";
            // 
            // btnRep
            // 
            this.btnRep.Location = new System.Drawing.Point(284, 221);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(75, 23);
            this.btnRep.TabIndex = 3;
            this.btnRep.Text = "Guardar";
            this.btnRep.UseVisualStyleBackColor = true;
            this.btnRep.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNitRep
            // 
            this.txtNitRep.Location = new System.Drawing.Point(122, 66);
            this.txtNitRep.Name = "txtNitRep";
            this.txtNitRep.Size = new System.Drawing.Size(177, 23);
            this.txtNitRep.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "NIT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(17, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Digite los datos de la reparación";
            // 
            // tpConsultar
            // 
            this.tpConsultar.Controls.Add(this.dtpCons);
            this.tpConsultar.Controls.Add(this.label16);
            this.tpConsultar.Controls.Add(this.label15);
            this.tpConsultar.Controls.Add(this.txtNitCons);
            this.tpConsultar.Controls.Add(this.label14);
            this.tpConsultar.Controls.Add(this.btnConsultarPersonas);
            this.tpConsultar.Controls.Add(this.dgvDatos);
            this.tpConsultar.Location = new System.Drawing.Point(4, 24);
            this.tpConsultar.Name = "tpConsultar";
            this.tpConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsultar.Size = new System.Drawing.Size(637, 362);
            this.tpConsultar.TabIndex = 1;
            this.tpConsultar.Text = "Consulta #1";
            this.tpConsultar.UseVisualStyleBackColor = true;
            // 
            // dtpCons
            // 
            this.dtpCons.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCons.Location = new System.Drawing.Point(152, 114);
            this.dtpCons.Name = "dtpCons";
            this.dtpCons.Size = new System.Drawing.Size(177, 23);
            this.dtpCons.TabIndex = 11;
            this.dtpCons.Value = new System.DateTime(2023, 1, 28, 11, 15, 9, 0);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(44, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(209, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "Digite los datos de la reparación";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "Fecha de ingreso:";
            // 
            // txtNitCons
            // 
            this.txtNitCons.Location = new System.Drawing.Point(152, 75);
            this.txtNitCons.Name = "txtNitCons";
            this.txtNitCons.Size = new System.Drawing.Size(177, 23);
            this.txtNitCons.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Nit de la empresa:";
            // 
            // btnConsultarPersonas
            // 
            this.btnConsultarPersonas.Location = new System.Drawing.Point(477, 142);
            this.btnConsultarPersonas.Name = "btnConsultarPersonas";
            this.btnConsultarPersonas.Size = new System.Drawing.Size(110, 23);
            this.btnConsultarPersonas.TabIndex = 2;
            this.btnConsultarPersonas.Text = "Consultar ";
            this.btnConsultarPersonas.UseVisualStyleBackColor = true;
            this.btnConsultarPersonas.Click += new System.EventHandler(this.btnConsultarPersonas_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(39, 182);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowTemplate.Height = 25;
            this.dgvDatos.Size = new System.Drawing.Size(548, 150);
            this.dgvDatos.TabIndex = 1;
            // 
            // tpBusqueda
            // 
            this.tpBusqueda.Controls.Add(this.lbMostrarCons);
            this.tpBusqueda.Controls.Add(this.label1);
            this.tpBusqueda.Controls.Add(this.btnBuscar);
            this.tpBusqueda.Controls.Add(this.lbBuscar);
            this.tpBusqueda.Location = new System.Drawing.Point(4, 24);
            this.tpBusqueda.Name = "tpBusqueda";
            this.tpBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tpBusqueda.Size = new System.Drawing.Size(637, 362);
            this.tpBusqueda.TabIndex = 2;
            this.tpBusqueda.Text = "Búsqueda";
            this.tpBusqueda.UseVisualStyleBackColor = true;
            // 
            // lbMostrarCons
            // 
            this.lbMostrarCons.AutoSize = true;
            this.lbMostrarCons.Location = new System.Drawing.Point(100, 121);
            this.lbMostrarCons.Name = "lbMostrarCons";
            this.lbMostrarCons.Size = new System.Drawing.Size(12, 15);
            this.lbMostrarCons.TabIndex = 4;
            this.lbMostrarCons.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(469, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBuscar.Location = new System.Drawing.Point(35, 62);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(350, 17);
            this.lbBuscar.TabIndex = 0;
            this.lbBuscar.Text = "¿Cuántos computadores registrados son de marca Dell?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcGestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbcGestion.ResumeLayout(false);
            this.tpRegistroEmp.ResumeLayout(false);
            this.pnlResgistroEmpresa.ResumeLayout(false);
            this.pnlResgistroEmpresa.PerformLayout();
            this.tpRegistroComp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpRegistroRepara.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpConsultar.ResumeLayout(false);
            this.tpConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tpBusqueda.ResumeLayout(false);
            this.tpBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbcGestion;
        private TabPage tpRegistroEmp;
        private TabPage tpConsultar;
        private Panel pnlResgistroEmpresa;
        private Label lbMensaje;
        private Label lbNit;
        private TextBox txtNit;
        private Button btnGuardarEmpresa;
        private TextBox txtNombre;
        private Label lbNombre;
        private DataGridView dgvDatos;
        private Button btnConsultarPersonas;
        private TabPage tpBusqueda;
        private Label lbBuscar;
        private Button btnBuscar;
        private Label label1;
        private Label lbMostrarCons;
        private TabPage tpRegistroComp;
        private TabPage tpRegistroRepara;
        private Panel panel1;
        private ComboBox cbxMarca;
        private Label label5;
        private TextBox txtCapacidad;
        private Label label6;
        private Button btnGuardarComputadora;
        private TextBox txtSerial;
        private Label label7;
        private Label label8;
        private Label label4;
        private TextBox txtTipoDisco;
        private Panel panel2;
        private TextBox txtSerialRep;
        private Label label9;
        private Button btnRep;
        private TextBox txtNitRep;
        private Label label10;
        private Label label11;
        private DateTimePicker dtpEgreso;
        private DateTimePicker dtpIngreso;
        private Label label13;
        private Label label12;
        private RadioButton rbNoExiste;
        private RadioButton rbExiste;
        private Label label16;
        private Label label15;
        private TextBox txtNitCons;
        private Label label14;
        private DateTimePicker dtpCons;
    }
}