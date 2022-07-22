namespace Trabajo_Practico
{
    partial class Store
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_micro = new System.Windows.Forms.GroupBox();
            this.lbl_precio_micro = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_micro = new System.Windows.Forms.ComboBox();
            this.checkBox_amd = new System.Windows.Forms.CheckBox();
            this.checkBox_intel = new System.Windows.Forms.CheckBox();
            this.groupBox_mother = new System.Windows.Forms.GroupBox();
            this.lbl_precio_mother = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_mother = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_precio_memoria = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_memoria = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_precio_placa = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_placa = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_precio_almacenamiento = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox_almacenamiento = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_precio_fuente = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox_fuente = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_impuestos = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_auxiliar = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.groupBox_micro.SuspendLayout();
            this.groupBox_mother.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arma tu PC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Elige tus componentes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Microprocesadores:";
            // 
            // groupBox_micro
            // 
            this.groupBox_micro.Controls.Add(this.lbl_precio_micro);
            this.groupBox_micro.Controls.Add(this.label9);
            this.groupBox_micro.Controls.Add(this.comboBox_micro);
            this.groupBox_micro.Controls.Add(this.checkBox_amd);
            this.groupBox_micro.Controls.Add(this.checkBox_intel);
            this.groupBox_micro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_micro.Location = new System.Drawing.Point(12, 95);
            this.groupBox_micro.Name = "groupBox_micro";
            this.groupBox_micro.Size = new System.Drawing.Size(287, 95);
            this.groupBox_micro.TabIndex = 12;
            this.groupBox_micro.TabStop = false;
            this.groupBox_micro.Text = "Seleccione una opcion:";
            this.groupBox_micro.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_precio_micro
            // 
            this.lbl_precio_micro.AutoSize = true;
            this.lbl_precio_micro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_precio_micro.Location = new System.Drawing.Point(53, 71);
            this.lbl_precio_micro.Name = "lbl_precio_micro";
            this.lbl_precio_micro.Size = new System.Drawing.Size(58, 13);
            this.lbl_precio_micro.TabIndex = 4;
            this.lbl_precio_micro.Text = "000000.00";
            this.lbl_precio_micro.Visible = false;
            this.lbl_precio_micro.TextChanged += new System.EventHandler(this.lbl_precio_micro_TextChanged);
            this.lbl_precio_micro.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(7, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Precio:";
            // 
            // comboBox_micro
            // 
            this.comboBox_micro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_micro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox_micro.FormattingEnabled = true;
            this.comboBox_micro.Location = new System.Drawing.Point(7, 43);
            this.comboBox_micro.Name = "comboBox_micro";
            this.comboBox_micro.Size = new System.Drawing.Size(273, 21);
            this.comboBox_micro.TabIndex = 2;
            this.comboBox_micro.Text = "Seleccione una opcion";
            this.comboBox_micro.SelectedIndexChanged += new System.EventHandler(this.combobox_micro_SelectedIndexChanged);
            // 
            // checkBox_amd
            // 
            this.checkBox_amd.AutoSize = true;
            this.checkBox_amd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_amd.Location = new System.Drawing.Point(94, 20);
            this.checkBox_amd.Name = "checkBox_amd";
            this.checkBox_amd.Size = new System.Drawing.Size(48, 17);
            this.checkBox_amd.TabIndex = 1;
            this.checkBox_amd.Text = "AMD";
            this.checkBox_amd.UseVisualStyleBackColor = true;
            this.checkBox_amd.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox_intel
            // 
            this.checkBox_intel.AutoSize = true;
            this.checkBox_intel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_intel.Location = new System.Drawing.Point(7, 20);
            this.checkBox_intel.Name = "checkBox_intel";
            this.checkBox_intel.Size = new System.Drawing.Size(44, 17);
            this.checkBox_intel.TabIndex = 0;
            this.checkBox_intel.Text = "Intel";
            this.checkBox_intel.UseVisualStyleBackColor = true;
            this.checkBox_intel.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox_mother
            // 
            this.groupBox_mother.Controls.Add(this.lbl_precio_mother);
            this.groupBox_mother.Controls.Add(this.label11);
            this.groupBox_mother.Controls.Add(this.comboBox_mother);
            this.groupBox_mother.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_mother.Location = new System.Drawing.Point(12, 209);
            this.groupBox_mother.Name = "groupBox_mother";
            this.groupBox_mother.Size = new System.Drawing.Size(287, 68);
            this.groupBox_mother.TabIndex = 14;
            this.groupBox_mother.TabStop = false;
            this.groupBox_mother.Text = "Seleccione una opcion:";
            // 
            // lbl_precio_mother
            // 
            this.lbl_precio_mother.AutoSize = true;
            this.lbl_precio_mother.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_precio_mother.Location = new System.Drawing.Point(52, 43);
            this.lbl_precio_mother.Name = "lbl_precio_mother";
            this.lbl_precio_mother.Size = new System.Drawing.Size(58, 13);
            this.lbl_precio_mother.TabIndex = 4;
            this.lbl_precio_mother.Text = "000000.00";
            this.lbl_precio_mother.Visible = false;
            this.lbl_precio_mother.TextChanged += new System.EventHandler(this.lbl_precio_mother_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(6, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Precio:";
            // 
            // comboBox_mother
            // 
            this.comboBox_mother.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_mother.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox_mother.FormattingEnabled = true;
            this.comboBox_mother.Location = new System.Drawing.Point(6, 19);
            this.comboBox_mother.Name = "comboBox_mother";
            this.comboBox_mother.Size = new System.Drawing.Size(274, 21);
            this.comboBox_mother.TabIndex = 2;
            this.comboBox_mother.Text = "Seleccione una opcion";
            this.comboBox_mother.SelectedIndexChanged += new System.EventHandler(this.comboBox_mother_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(9, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Motherboards";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_precio_memoria);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboBox_memoria);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 65);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una opcion:";
            // 
            // lbl_precio_memoria
            // 
            this.lbl_precio_memoria.AutoSize = true;
            this.lbl_precio_memoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_precio_memoria.Location = new System.Drawing.Point(52, 43);
            this.lbl_precio_memoria.Name = "lbl_precio_memoria";
            this.lbl_precio_memoria.Size = new System.Drawing.Size(58, 13);
            this.lbl_precio_memoria.TabIndex = 4;
            this.lbl_precio_memoria.Text = "000000.00";
            this.lbl_precio_memoria.Visible = false;
            this.lbl_precio_memoria.TextChanged += new System.EventHandler(this.lbl_precio_memoria_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Precio:";
            // 
            // comboBox_memoria
            // 
            this.comboBox_memoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_memoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox_memoria.FormattingEnabled = true;
            this.comboBox_memoria.Location = new System.Drawing.Point(6, 19);
            this.comboBox_memoria.Name = "comboBox_memoria";
            this.comboBox_memoria.Size = new System.Drawing.Size(274, 21);
            this.comboBox_memoria.TabIndex = 2;
            this.comboBox_memoria.Text = "Seleccione una opcion";
            this.comboBox_memoria.SelectedIndexChanged += new System.EventHandler(this.comboBox_memoria_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(9, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Memoria RAM:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_precio_placa);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.comboBox_placa);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(12, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 63);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione una opcion:";
            // 
            // lbl_precio_placa
            // 
            this.lbl_precio_placa.AutoSize = true;
            this.lbl_precio_placa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_precio_placa.Location = new System.Drawing.Point(52, 43);
            this.lbl_precio_placa.Name = "lbl_precio_placa";
            this.lbl_precio_placa.Size = new System.Drawing.Size(58, 13);
            this.lbl_precio_placa.TabIndex = 4;
            this.lbl_precio_placa.Text = "000000.00";
            this.lbl_precio_placa.Visible = false;
            this.lbl_precio_placa.TextChanged += new System.EventHandler(this.lbl_precio_placa_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(6, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Precio:";
            // 
            // comboBox_placa
            // 
            this.comboBox_placa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_placa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox_placa.FormattingEnabled = true;
            this.comboBox_placa.Location = new System.Drawing.Point(6, 19);
            this.comboBox_placa.Name = "comboBox_placa";
            this.comboBox_placa.Size = new System.Drawing.Size(274, 21);
            this.comboBox_placa.TabIndex = 2;
            this.comboBox_placa.Text = "Seleccione una opcion";
            this.comboBox_placa.SelectedIndexChanged += new System.EventHandler(this.comboBox_placa_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(9, 364);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Placas de video:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_precio_almacenamiento);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.comboBox_almacenamiento);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(12, 462);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 63);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccione una opcion:";
            // 
            // lbl_precio_almacenamiento
            // 
            this.lbl_precio_almacenamiento.AutoSize = true;
            this.lbl_precio_almacenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_precio_almacenamiento.Location = new System.Drawing.Point(52, 43);
            this.lbl_precio_almacenamiento.Name = "lbl_precio_almacenamiento";
            this.lbl_precio_almacenamiento.Size = new System.Drawing.Size(58, 13);
            this.lbl_precio_almacenamiento.TabIndex = 4;
            this.lbl_precio_almacenamiento.Text = "000000.00";
            this.lbl_precio_almacenamiento.Visible = false;
            this.lbl_precio_almacenamiento.TextChanged += new System.EventHandler(this.lbl_precio_almacenamiento_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label17.Location = new System.Drawing.Point(6, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Precio:";
            // 
            // comboBox_almacenamiento
            // 
            this.comboBox_almacenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_almacenamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox_almacenamiento.FormattingEnabled = true;
            this.comboBox_almacenamiento.Location = new System.Drawing.Point(6, 19);
            this.comboBox_almacenamiento.Name = "comboBox_almacenamiento";
            this.comboBox_almacenamiento.Size = new System.Drawing.Size(274, 21);
            this.comboBox_almacenamiento.TabIndex = 2;
            this.comboBox_almacenamiento.Text = "Seleccione una opcion";
            this.comboBox_almacenamiento.SelectedIndexChanged += new System.EventHandler(this.comboBox_almacenamiento_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label18.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label18.Location = new System.Drawing.Point(9, 446);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Almacenamiento:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_precio_fuente);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.comboBox_fuente);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(12, 544);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 63);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccione una opcion:";
            // 
            // lbl_precio_fuente
            // 
            this.lbl_precio_fuente.AutoSize = true;
            this.lbl_precio_fuente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_precio_fuente.Location = new System.Drawing.Point(52, 43);
            this.lbl_precio_fuente.Name = "lbl_precio_fuente";
            this.lbl_precio_fuente.Size = new System.Drawing.Size(58, 13);
            this.lbl_precio_fuente.TabIndex = 4;
            this.lbl_precio_fuente.Text = "000000.00";
            this.lbl_precio_fuente.Visible = false;
            this.lbl_precio_fuente.TextChanged += new System.EventHandler(this.lbl_precio_fuente_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label20.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label20.Location = new System.Drawing.Point(6, 43);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Precio:";
            // 
            // comboBox_fuente
            // 
            this.comboBox_fuente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_fuente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBox_fuente.FormattingEnabled = true;
            this.comboBox_fuente.Location = new System.Drawing.Point(6, 19);
            this.comboBox_fuente.Name = "comboBox_fuente";
            this.comboBox_fuente.Size = new System.Drawing.Size(274, 21);
            this.comboBox_fuente.TabIndex = 2;
            this.comboBox_fuente.Text = "Seleccione una opcion";
            this.comboBox_fuente.SelectedIndexChanged += new System.EventHandler(this.comboBox_fuente_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label21.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label21.Location = new System.Drawing.Point(9, 528);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 22;
            this.label21.Text = "Fuente";
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enviar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_enviar.Location = new System.Drawing.Point(18, 694);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(281, 23);
            this.btn_enviar.TabIndex = 24;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_total.Location = new System.Drawing.Point(78, 675);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(19, 13);
            this.lbl_total.TabIndex = 41;
            this.lbl_total.Text = "$0";
            // 
            // lbl_impuestos
            // 
            this.lbl_impuestos.AutoSize = true;
            this.lbl_impuestos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_impuestos.Location = new System.Drawing.Point(78, 646);
            this.lbl_impuestos.Name = "lbl_impuestos";
            this.lbl_impuestos.Size = new System.Drawing.Size(19, 13);
            this.lbl_impuestos.TabIndex = 40;
            this.lbl_impuestos.Text = "$0";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_subtotal.Location = new System.Drawing.Point(78, 617);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(19, 13);
            this.lbl_subtotal.TabIndex = 39;
            this.lbl_subtotal.Text = "$0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(18, 675);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(15, 646);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Impuestos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(15, 617);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Subtota:";
            // 
            // lbl_auxiliar
            // 
            this.lbl_auxiliar.AutoSize = true;
            this.lbl_auxiliar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_auxiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auxiliar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_auxiliar.Location = new System.Drawing.Point(172, 624);
            this.lbl_auxiliar.Name = "lbl_auxiliar";
            this.lbl_auxiliar.Size = new System.Drawing.Size(120, 16);
            this.lbl_auxiliar.TabIndex = 42;
            this.lbl_auxiliar.Text = "Correo electronico:";
            this.lbl_auxiliar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(160, 643);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(139, 20);
            this.txt_email.TabIndex = 43;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(319, 729);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_auxiliar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_impuestos);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox_mother);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox_micro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Store";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            this.groupBox_micro.ResumeLayout(false);
            this.groupBox_micro.PerformLayout();
            this.groupBox_mother.ResumeLayout(false);
            this.groupBox_mother.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_micro;
        private System.Windows.Forms.CheckBox checkBox_amd;
        private System.Windows.Forms.CheckBox checkBox_intel;
        private System.Windows.Forms.ComboBox comboBox_micro;
        private System.Windows.Forms.Label lbl_precio_micro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox_mother;
        private System.Windows.Forms.Label lbl_precio_mother;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_mother;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_precio_memoria;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_memoria;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_precio_placa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_placa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_precio_almacenamiento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox_almacenamiento;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_precio_fuente;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox_fuente;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_impuestos;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_auxiliar;
        private System.Windows.Forms.TextBox txt_email;
    }
}