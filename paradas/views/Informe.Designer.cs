namespace paradas.views
{
    partial class Informe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoIniciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadBinsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPersonas1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasTurnosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informeTurnoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_horas = new System.Windows.Forms.TextBox();
            this.txt_personas = new System.Windows.Forms.TextBox();
            this.txt_bins = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.informeTurnoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.informeTurnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.validacionesTurnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.validacionesTurnosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeTurnoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeTurnoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeTurnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validacionesTurnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validacionesTurnosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtp_fin);
            this.panel1.Controls.Add(this.dtp_inicio);
            this.panel1.Location = new System.Drawing.Point(106, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 68);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(623, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 47);
            this.button1.TabIndex = 51;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(304, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "Hasta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "Fecha desde";
            // 
            // dtp_fin
            // 
            this.dtp_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Location = new System.Drawing.Point(372, 20);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(147, 26);
            this.dtp_fin.TabIndex = 1;
            this.dtp_fin.ValueChanged += new System.EventHandler(this.dtp_fin_ValueChanged);
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Location = new System.Drawing.Point(145, 18);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(153, 26);
            this.dtp_inicio.TabIndex = 0;
            this.dtp_inicio.ValueChanged += new System.EventHandler(this.dtp_inicio_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.advancedDataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_horas);
            this.panel2.Controls.Add(this.txt_personas);
            this.panel2.Controls.Add(this.txt_bins);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(2, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 484);
            this.panel2.TabIndex = 1;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.turnoIniciaDataGridViewTextBoxColumn,
            this.turnoFinDataGridViewTextBoxColumn,
            this.cantidadBinsDataGridViewTextBoxColumn,
            this.cantidadPersonas1DataGridViewTextBoxColumn,
            this.horasTurnosDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn,
            this.sectorDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.informeTurnoBindingSource2;
            this.advancedDataGridView1.FilterAndSortEnabled = true;
            this.advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.advancedDataGridView1.Location = new System.Drawing.Point(10, 12);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView1.Size = new System.Drawing.Size(995, 409);
            this.advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.advancedDataGridView1.TabIndex = 55;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.advancedDataGridView1_SortStringChanged_1);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.advancedDataGridView1_FilterStringChanged_1);
            this.advancedDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellContentClick_1);
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // turnoIniciaDataGridViewTextBoxColumn
            // 
            this.turnoIniciaDataGridViewTextBoxColumn.DataPropertyName = "TurnoInicia";
            this.turnoIniciaDataGridViewTextBoxColumn.HeaderText = "TurnoInicia";
            this.turnoIniciaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.turnoIniciaDataGridViewTextBoxColumn.Name = "turnoIniciaDataGridViewTextBoxColumn";
            this.turnoIniciaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // turnoFinDataGridViewTextBoxColumn
            // 
            this.turnoFinDataGridViewTextBoxColumn.DataPropertyName = "TurnoFin";
            this.turnoFinDataGridViewTextBoxColumn.HeaderText = "TurnoFin";
            this.turnoFinDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.turnoFinDataGridViewTextBoxColumn.Name = "turnoFinDataGridViewTextBoxColumn";
            this.turnoFinDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cantidadBinsDataGridViewTextBoxColumn
            // 
            this.cantidadBinsDataGridViewTextBoxColumn.DataPropertyName = "CantidadBins";
            this.cantidadBinsDataGridViewTextBoxColumn.HeaderText = "CantidadBins";
            this.cantidadBinsDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cantidadBinsDataGridViewTextBoxColumn.Name = "cantidadBinsDataGridViewTextBoxColumn";
            this.cantidadBinsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cantidadPersonas1DataGridViewTextBoxColumn
            // 
            this.cantidadPersonas1DataGridViewTextBoxColumn.DataPropertyName = "CantidadPersonas1";
            this.cantidadPersonas1DataGridViewTextBoxColumn.HeaderText = "CantidadPersonas1";
            this.cantidadPersonas1DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cantidadPersonas1DataGridViewTextBoxColumn.Name = "cantidadPersonas1DataGridViewTextBoxColumn";
            this.cantidadPersonas1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // horasTurnosDataGridViewTextBoxColumn
            // 
            this.horasTurnosDataGridViewTextBoxColumn.DataPropertyName = "HorasTurnos";
            this.horasTurnosDataGridViewTextBoxColumn.HeaderText = "HorasTurnos";
            this.horasTurnosDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.horasTurnosDataGridViewTextBoxColumn.Name = "horasTurnosDataGridViewTextBoxColumn";
            this.horasTurnosDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // sectorDataGridViewTextBoxColumn
            // 
            this.sectorDataGridViewTextBoxColumn.DataPropertyName = "Sector";
            this.sectorDataGridViewTextBoxColumn.HeaderText = "Sector";
            this.sectorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.sectorDataGridViewTextBoxColumn.Name = "sectorDataGridViewTextBoxColumn";
            this.sectorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // informeTurnoBindingSource2
            // 
            this.informeTurnoBindingSource2.DataSource = typeof(paradas.models.InformeTurno);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(631, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Cant. horas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(484, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Cant. Personas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(380, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Cant. Bines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(276, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Totales";
            // 
            // txt_horas
            // 
            this.txt_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_horas.Location = new System.Drawing.Point(609, 455);
            this.txt_horas.Name = "txt_horas";
            this.txt_horas.Size = new System.Drawing.Size(116, 26);
            this.txt_horas.TabIndex = 3;
            // 
            // txt_personas
            // 
            this.txt_personas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_personas.Location = new System.Drawing.Point(487, 455);
            this.txt_personas.Name = "txt_personas";
            this.txt_personas.Size = new System.Drawing.Size(116, 26);
            this.txt_personas.TabIndex = 2;
            // 
            // txt_bins
            // 
            this.txt_bins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bins.Location = new System.Drawing.Point(365, 455);
            this.txt_bins.Name = "txt_bins";
            this.txt_bins.Size = new System.Drawing.Size(116, 26);
            this.txt_bins.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(878, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 42);
            this.button2.TabIndex = 52;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // informeTurnoBindingSource1
            // 
            this.informeTurnoBindingSource1.DataSource = typeof(paradas.models.InformeTurno);
            // 
            // informeTurnoBindingSource
            // 
            this.informeTurnoBindingSource.DataSource = typeof(paradas.models.InformeTurno);
            // 
            // validacionesTurnosBindingSource
            // 
            this.validacionesTurnosBindingSource.DataSource = typeof(paradas.models.ValidacionesTurnos);
            // 
            // validacionesTurnosBindingSource1
            // 
            this.validacionesTurnosBindingSource1.DataSource = typeof(paradas.models.ValidacionesTurnos);
            // 
            // Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 633);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Informe";
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.Informe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeTurnoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeTurnoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeTurnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validacionesTurnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validacionesTurnosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource validacionesTurnosBindingSource;
        private System.Windows.Forms.BindingSource informeTurnoBindingSource;
        private System.Windows.Forms.BindingSource validacionesTurnosBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_horas;
        private System.Windows.Forms.TextBox txt_personas;
        private System.Windows.Forms.TextBox txt_bins;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource informeTurnoBindingSource1;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoIniciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadBinsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPersonas1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasTurnosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource informeTurnoBindingSource2;
    }
}