using paradas.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paradas.views
{
    public partial class Informe : Form
    {
        String fechaMenor;
        String selectDateAsStringBefore;
        String selectDateAsStringAfter;
        Generales generales = new Generales();
        Informes informes = new Informes();
        public Informe()
        {
            InitializeComponent();
           

            dtp_inicio.Format = DateTimePickerFormat.Custom;
            dtp_inicio.CustomFormat = "yyyyy-MM-dd ";
            dtp_fin.Format = DateTimePickerFormat.Custom;
            dtp_fin.CustomFormat = "yyyyy-MM-dd ";
            int diaActual = Convert.ToInt16(DateTime.Now.ToString("dd"));
            advancedDataGridView1.ForeColor= Color.Black;

            Console.WriteLine(diaActual);
            if (diaActual >= 11)
            {
                diaActual = diaActual - 10;
            }
            String mes = DateTime.Now.ToString("MM");
            String anio = DateTime.Now.ToString("yyyy");
            fechaMenor = anio + "-" + mes + "-" + generales.RellenarCadena(diaActual.ToString(), '0', 2, true);
            selectDateAsStringBefore = fechaMenor;
            selectDateAsStringAfter = (DateTime.Now.ToString("yyyy-MM-dd"));
            dtp_inicio.Text= selectDateAsStringBefore;
            cargarDataGrid(informes.getInformeTurnos(selectDateAsStringBefore, selectDateAsStringAfter));
            cargarTotales();
            ConfigDataGrid();
        }

        private void ConfigDataGrid()
        {
            advancedDataGridView1.RowHeadersVisible = false;
            advancedDataGridView1.Columns[0].Width = 100;
            advancedDataGridView1.Columns[1].Width = 130;
            advancedDataGridView1.Columns[2].Width = 140;
            advancedDataGridView1.Columns[3].Width = 130;
            advancedDataGridView1.Columns[4].Width = 140;
            advancedDataGridView1.Columns[5].Width = 110;
            advancedDataGridView1.Columns[6].Width = 120;
            advancedDataGridView1.Columns[7].Width = 120;
            advancedDataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            advancedDataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
        }
        private void cargarDataGrid(List<InformeTurno> lista)
        {
            DataTable dt = generales.ToDataTable(lista);
            this.informeTurnoBindingSource.DataSource = dt;
            advancedDataGridView1.DataSource= dt;
            
        }

        private void cargarTotales()
        {
            int totalBins = 0;
            int totalPersonas = 0;
            decimal totalHoras = 0;
            foreach (DataGridViewRow rowp in advancedDataGridView1.Rows)
            {
                int kia = rowp.Index -1;

                if (kia >= 0)
                {
                    totalBins = totalBins + Convert.ToInt32(advancedDataGridView1.Rows[kia].Cells[3].Value.ToString());
                    totalPersonas = totalPersonas + Convert.ToInt32(advancedDataGridView1.Rows[kia].Cells[4].Value.ToString());
                    totalHoras = totalHoras + Convert.ToDecimal(advancedDataGridView1.Rows[kia].Cells[5].Value.ToString());
                }
              
            }

            this.txt_bins.Text = totalBins.ToString();
            this.txt_personas.Text = totalPersonas.ToString();
            this.txt_horas.Text = totalHoras.ToString();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void advancedDataGridView1_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            this.informeTurnoBindingSource.Filter = this.advancedDataGridView1.FilterString;
            advancedDataGridView1.DataSource.ToString();
            cargarTotales();
        }

        private void advancedDataGridView1_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            //this.informeTurnoBindingSource.Sort= this.advancedDataGridView1.SortString;
            //cargarTotales();
        }

        private void dtp_inicio_ValueChanged(object sender, EventArgs e)
        {
            selectDateAsStringBefore = this.dtp_inicio.Text.ToString();
;           //MessageBox.Show(selectDateAsStringBefore);
        }

        private void dtp_fin_ValueChanged(object sender, EventArgs e)
        {
          
            selectDateAsStringAfter = dtp_fin.Text.ToString();
     
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cargarDataGrid(informes.getInformeTurnos(selectDateAsStringBefore, selectDateAsStringAfter));
            cargarTotales();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Informe_Load(object sender, EventArgs e)
        {

        }

        private void advancedDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void advancedDataGridView1_SortStringChanged_1(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            this.informeTurnoBindingSource.Sort = this.advancedDataGridView1.SortString;
            cargarTotales();
        }

        private void advancedDataGridView1_FilterStringChanged_1(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            this.informeTurnoBindingSource.Filter = this.advancedDataGridView1.FilterString;
            advancedDataGridView1.DataSource.ToString();
            cargarTotales();
        }
    }
}
