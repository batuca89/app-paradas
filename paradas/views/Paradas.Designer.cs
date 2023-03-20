namespace paradas.views
{
    partial class Paradas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.r_parcial = new System.Windows.Forms.RadioButton();
            this.r_total = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_problemas = new System.Windows.Forms.TextBox();
            this.panel_problemas = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.dgv_problemas = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_minutos_fin = new System.Windows.Forms.TextBox();
            this.txt_horas_fin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_inicio_minutos = new System.Windows.Forms.TextBox();
            this.txt_inicio_horas = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_turno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cb_sector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_informe = new System.Windows.Forms.Button();
            this.problemasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel_problemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_problemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_informe);
            this.panel1.Controls.Add(this.r_parcial);
            this.panel1.Controls.Add(this.r_total);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_problemas);
            this.panel1.Controls.Add(this.panel_problemas);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txt_minutos_fin);
            this.panel1.Controls.Add(this.txt_horas_fin);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_inicio_minutos);
            this.panel1.Controls.Add(this.txt_inicio_horas);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cb_turno);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.cb_sector);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_observaciones);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 581);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // r_parcial
            // 
            this.r_parcial.AutoSize = true;
            this.r_parcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_parcial.Location = new System.Drawing.Point(536, 280);
            this.r_parcial.Name = "r_parcial";
            this.r_parcial.Size = new System.Drawing.Size(142, 24);
            this.r_parcial.TabIndex = 61;
            this.r_parcial.TabStop = true;
            this.r_parcial.Text = "Parada parcial";
            this.r_parcial.UseVisualStyleBackColor = true;
            this.r_parcial.CheckedChanged += new System.EventHandler(this.r_parcial_CheckedChanged);
            // 
            // r_total
            // 
            this.r_total.AutoSize = true;
            this.r_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_total.Location = new System.Drawing.Point(536, 253);
            this.r_total.Name = "r_total";
            this.r_total.Size = new System.Drawing.Size(129, 24);
            this.r_total.TabIndex = 60;
            this.r_total.TabStop = true;
            this.r_total.Text = "Parada Total";
            this.r_total.UseVisualStyleBackColor = true;
            this.r_total.CheckedChanged += new System.EventHandler(this.r_total_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Fecha";
            // 
            // txt_problemas
            // 
            this.txt_problemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_problemas.Location = new System.Drawing.Point(163, 315);
            this.txt_problemas.Name = "txt_problemas";
            this.txt_problemas.Size = new System.Drawing.Size(597, 26);
            this.txt_problemas.TabIndex = 56;
            this.txt_problemas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.txt_problemas.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // panel_problemas
            // 
            this.panel_problemas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_problemas.Controls.Add(this.label17);
            this.panel_problemas.Controls.Add(this.txt_filtro);
            this.panel_problemas.Controls.Add(this.dgv_problemas);
            this.panel_problemas.Location = new System.Drawing.Point(163, 315);
            this.panel_problemas.Name = "panel_problemas";
            this.panel_problemas.Size = new System.Drawing.Size(603, 231);
            this.panel_problemas.TabIndex = 55;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(47, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 24);
            this.label17.TabIndex = 48;
            this.label17.Text = "Filtro:";
            // 
            // txt_filtro
            // 
            this.txt_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro.Location = new System.Drawing.Point(168, 9);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(358, 26);
            this.txt_filtro.TabIndex = 1;
            this.txt_filtro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv_problemas
            // 
            this.dgv_problemas.AllowUserToAddRows = false;
            this.dgv_problemas.AllowUserToDeleteRows = false;
            this.dgv_problemas.AllowUserToResizeColumns = false;
            this.dgv_problemas.AllowUserToResizeRows = false;
            this.dgv_problemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_problemas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_problemas.GridColor = System.Drawing.Color.SlateGray;
            this.dgv_problemas.Location = new System.Drawing.Point(0, 43);
            this.dgv_problemas.MultiSelect = false;
            this.dgv_problemas.Name = "dgv_problemas";
            this.dgv_problemas.ReadOnly = true;
            this.dgv_problemas.Size = new System.Drawing.Size(597, 173);
            this.dgv_problemas.TabIndex = 0;
            this.dgv_problemas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_problemas_CellContentClick);
            this.dgv_problemas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_problemas_CellContentDoubleClick);
            this.dgv_problemas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_problemas_CellMouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(200, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 24);
            this.label12.TabIndex = 54;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(210, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 24);
            this.label13.TabIndex = 53;
            this.label13.Text = "Minutos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(144, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 24);
            this.label14.TabIndex = 52;
            this.label14.Text = "Hora";
            // 
            // txt_minutos_fin
            // 
            this.txt_minutos_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minutos_fin.Location = new System.Drawing.Point(222, 206);
            this.txt_minutos_fin.MaxLength = 2;
            this.txt_minutos_fin.Name = "txt_minutos_fin";
            this.txt_minutos_fin.Size = new System.Drawing.Size(33, 26);
            this.txt_minutos_fin.TabIndex = 51;
            // 
            // txt_horas_fin
            // 
            this.txt_horas_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_horas_fin.Location = new System.Drawing.Point(167, 206);
            this.txt_horas_fin.MaxLength = 2;
            this.txt_horas_fin.Name = "txt_horas_fin";
            this.txt_horas_fin.Size = new System.Drawing.Size(32, 26);
            this.txt_horas_fin.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(200, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 24);
            this.label10.TabIndex = 49;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(210, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 24);
            this.label9.TabIndex = 48;
            this.label9.Text = "Minutos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(144, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 24);
            this.label11.TabIndex = 47;
            this.label11.Text = "Hora";
            // 
            // txt_inicio_minutos
            // 
            this.txt_inicio_minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inicio_minutos.Location = new System.Drawing.Point(222, 130);
            this.txt_inicio_minutos.MaxLength = 2;
            this.txt_inicio_minutos.Name = "txt_inicio_minutos";
            this.txt_inicio_minutos.Size = new System.Drawing.Size(33, 26);
            this.txt_inicio_minutos.TabIndex = 46;
            // 
            // txt_inicio_horas
            // 
            this.txt_inicio_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inicio_horas.Location = new System.Drawing.Point(167, 130);
            this.txt_inicio_horas.MaxLength = 2;
            this.txt_inicio_horas.Name = "txt_inicio_horas";
            this.txt_inicio_horas.Size = new System.Drawing.Size(32, 26);
            this.txt_inicio_horas.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(109, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 20);
            this.label15.TabIndex = 44;
            this.label15.Text = "Fin";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(109, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "Inicio";
            // 
            // cb_turno
            // 
            this.cb_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_turno.FormattingEnabled = true;
            this.cb_turno.Location = new System.Drawing.Point(167, 271);
            this.cb_turno.Name = "cb_turno";
            this.cb_turno.Size = new System.Drawing.Size(267, 28);
            this.cb_turno.TabIndex = 42;
            this.cb_turno.SelectedIndexChanged += new System.EventHandler(this.cb_turno_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Turno";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(493, 159);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(267, 26);
            this.txt_nombre.TabIndex = 40;
            // 
            // cb_sector
            // 
            this.cb_sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sector.FormattingEnabled = true;
            this.cb_sector.Location = new System.Drawing.Point(493, 208);
            this.cb_sector.Name = "cb_sector";
            this.cb_sector.Size = new System.Drawing.Size(267, 28);
            this.cb_sector.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Sector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Observaciones";
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_observaciones.Location = new System.Drawing.Point(167, 358);
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(593, 79);
            this.txt_observaciones.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Problema";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Paradas";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(192, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 52);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cargar Parada";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(602, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 52);
            this.button1.TabIndex = 24;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(493, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btn_informe
            // 
            this.btn_informe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_informe.Location = new System.Drawing.Point(400, 460);
            this.btn_informe.Name = "btn_informe";
            this.btn_informe.Size = new System.Drawing.Size(142, 52);
            this.btn_informe.TabIndex = 62;
            this.btn_informe.Text = "Informe";
            this.btn_informe.UseVisualStyleBackColor = true;
            this.btn_informe.Click += new System.EventHandler(this.button3_Click);
            // 
            // problemasBindingSource
            // 
            this.problemasBindingSource.DataSource = typeof(paradas.models.Problemas);
            // 
            // Paradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.panel1);
            this.Name = "Paradas";
            this.Text = "Paradas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_problemas.ResumeLayout(false);
            this.panel_problemas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_problemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cb_sector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_turno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_minutos_fin;
        private System.Windows.Forms.TextBox txt_horas_fin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_inicio_minutos;
        private System.Windows.Forms.TextBox txt_inicio_horas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel_problemas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.DataGridView dgv_problemas;
        private System.Windows.Forms.BindingSource problemasBindingSource;
        private System.Windows.Forms.TextBox txt_problemas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton r_total;
        private System.Windows.Forms.RadioButton r_parcial;
        private System.Windows.Forms.Button btn_informe;
    }
}