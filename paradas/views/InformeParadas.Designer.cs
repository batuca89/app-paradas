namespace paradas.views
{
    partial class InformeParadas
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_horas = new System.Windows.Forms.TextBox();
            this.adgv_paradas = new Zuby.ADGV.AdvancedDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoParadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioParada1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finParadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasParadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obervacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informeParadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgv_paradas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informeParadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_horas);
            this.panel2.Controls.Add(this.adgv_paradas);
            this.panel2.Location = new System.Drawing.Point(12, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 521);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Total";
            // 
            // txt_horas
            // 
            this.txt_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_horas.Location = new System.Drawing.Point(613, 462);
            this.txt_horas.Name = "txt_horas";
            this.txt_horas.Size = new System.Drawing.Size(116, 26);
            this.txt_horas.TabIndex = 3;
            // 
            // adgv_paradas
            // 
            this.adgv_paradas.AutoGenerateColumns = false;
            this.adgv_paradas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.adgv_paradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgv_paradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.tipoParadaDataGridViewTextBoxColumn,
            this.problemaDataGridViewTextBoxColumn,
            this.inicioParada1DataGridViewTextBoxColumn,
            this.finParadaDataGridViewTextBoxColumn,
            this.horasParadasDataGridViewTextBoxColumn,
            this.sectorDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn,
            this.obervacionesDataGridViewTextBoxColumn});
            this.adgv_paradas.DataSource = this.informeParadasBindingSource;
            this.adgv_paradas.FilterAndSortEnabled = true;
            this.adgv_paradas.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgv_paradas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adgv_paradas.Location = new System.Drawing.Point(24, 15);
            this.adgv_paradas.Name = "adgv_paradas";
            this.adgv_paradas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgv_paradas.Size = new System.Drawing.Size(1169, 413);
            this.adgv_paradas.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgv_paradas.TabIndex = 0;
            this.adgv_paradas.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.adgv_paradas_SortStringChanged);
            this.adgv_paradas.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.adgv_paradas_FilterStringChanged);
            this.adgv_paradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adgv_paradas_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtp_fin);
            this.panel1.Controls.Add(this.dtp_inicio);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 68);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(641, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 51;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "Hasta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "Fecha desde";
            // 
            // dtp_fin
            // 
            this.dtp_fin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Location = new System.Drawing.Point(419, 18);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(186, 29);
            this.dtp_fin.TabIndex = 1;
            this.dtp_fin.ValueChanged += new System.EventHandler(this.dtp_fin_ValueChanged);
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Location = new System.Drawing.Point(145, 18);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(200, 29);
            this.dtp_inicio.TabIndex = 0;
            this.dtp_inicio.ValueChanged += new System.EventHandler(this.dtp_inicio_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(618, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Horas paradas";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1052, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 32);
            this.button2.TabIndex = 53;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tipoParadaDataGridViewTextBoxColumn
            // 
            this.tipoParadaDataGridViewTextBoxColumn.DataPropertyName = "TipoParada";
            this.tipoParadaDataGridViewTextBoxColumn.HeaderText = "TipoParada";
            this.tipoParadaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tipoParadaDataGridViewTextBoxColumn.Name = "tipoParadaDataGridViewTextBoxColumn";
            this.tipoParadaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // problemaDataGridViewTextBoxColumn
            // 
            this.problemaDataGridViewTextBoxColumn.DataPropertyName = "Problema";
            this.problemaDataGridViewTextBoxColumn.HeaderText = "Problema";
            this.problemaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.problemaDataGridViewTextBoxColumn.Name = "problemaDataGridViewTextBoxColumn";
            this.problemaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // inicioParada1DataGridViewTextBoxColumn
            // 
            this.inicioParada1DataGridViewTextBoxColumn.DataPropertyName = "InicioParada1";
            this.inicioParada1DataGridViewTextBoxColumn.HeaderText = "InicioParada1";
            this.inicioParada1DataGridViewTextBoxColumn.MinimumWidth = 22;
            this.inicioParada1DataGridViewTextBoxColumn.Name = "inicioParada1DataGridViewTextBoxColumn";
            this.inicioParada1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // finParadaDataGridViewTextBoxColumn
            // 
            this.finParadaDataGridViewTextBoxColumn.DataPropertyName = "FinParada";
            this.finParadaDataGridViewTextBoxColumn.HeaderText = "FinParada";
            this.finParadaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.finParadaDataGridViewTextBoxColumn.Name = "finParadaDataGridViewTextBoxColumn";
            this.finParadaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // horasParadasDataGridViewTextBoxColumn
            // 
            this.horasParadasDataGridViewTextBoxColumn.DataPropertyName = "HorasParadas";
            this.horasParadasDataGridViewTextBoxColumn.HeaderText = "HorasParadas";
            this.horasParadasDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.horasParadasDataGridViewTextBoxColumn.Name = "horasParadasDataGridViewTextBoxColumn";
            this.horasParadasDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // sectorDataGridViewTextBoxColumn
            // 
            this.sectorDataGridViewTextBoxColumn.DataPropertyName = "Sector";
            this.sectorDataGridViewTextBoxColumn.HeaderText = "Sector";
            this.sectorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.sectorDataGridViewTextBoxColumn.Name = "sectorDataGridViewTextBoxColumn";
            this.sectorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // obervacionesDataGridViewTextBoxColumn
            // 
            this.obervacionesDataGridViewTextBoxColumn.DataPropertyName = "Obervaciones";
            this.obervacionesDataGridViewTextBoxColumn.HeaderText = "Obervaciones";
            this.obervacionesDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.obervacionesDataGridViewTextBoxColumn.Name = "obervacionesDataGridViewTextBoxColumn";
            this.obervacionesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // informeParadasBindingSource
            // 
            this.informeParadasBindingSource.DataSource = typeof(paradas.models.ReporteParadas);
            // 
            // InformeParadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 716);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InformeParadas";
            this.Text = "InformeParadas";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgv_paradas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.informeParadasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_horas;
        private Zuby.ADGV.AdvancedDataGridView adgv_paradas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoParadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioParada1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finParadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasParadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obervacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource informeParadasBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}