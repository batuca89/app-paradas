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
using Zuby.ADGV;

namespace paradas.views
{
    public partial class InformeParadas : Form
    {
        String fechaMenor;
        String selectDateAsStringBefore;
        String selectDateAsStringAfter;
        Generales generales = new Generales();
        Informes informes = new Informes();
        public InformeParadas()
        {
            InitializeComponent();
            dtp_inicio.Format = DateTimePickerFormat.Custom;
            dtp_inicio.CustomFormat = "yyyyy-MM-dd ";
            dtp_fin.Format = DateTimePickerFormat.Custom;
            dtp_fin.CustomFormat = "yyyyy-MM-dd ";
            int diaActual = Convert.ToInt16(DateTime.Now.ToString("dd"));

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
            dtp_inicio.Text = selectDateAsStringBefore;
            cargarDataGrid(informes.getInformeParadas(selectDateAsStringBefore, selectDateAsStringAfter));
            cargarTotales();
            ConfigDataGrid();
        }
        private void cargarTotales()
        {

            decimal totalHoras = 0;
            foreach (DataGridViewRow rowp in adgv_paradas.Rows)
            {
                int kia = rowp.Index - 1;

                if (kia >= 0)
                {

                    totalHoras = totalHoras + Convert.ToDecimal(adgv_paradas.Rows[kia].Cells[5].Value.ToString());
                }
                this.txt_horas.Text = totalHoras.ToString();
            }
        }
            private void cargarDataGrid(List<ReporteParadas> lista)
        {
            DataTable dt = generales.ToDataTable(lista);
            this.informeParadasBindingSource.DataSource = dt;
            adgv_paradas.DataSource = dt;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        
        }
        private void ConfigDataGrid()
        {
            adgv_paradas.RowHeadersVisible = false;
            adgv_paradas.Columns[0].Width = 100;
            adgv_paradas.Columns[1].Width = 130;
            adgv_paradas.Columns[2].Width = 140;
            adgv_paradas.Columns[3].Width = 115;
            adgv_paradas.Columns[4].Width = 110;
            adgv_paradas.Columns[5].Width = 115;
            adgv_paradas.Columns[6].Width = 120;
            adgv_paradas.Columns[7].Width = 130;
            adgv_paradas.Columns[8].Width = 200;
            adgv_paradas.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            adgv_paradas.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adgv_paradas_FilterStringChanged(object sender, AdvancedDataGridView.FilterEventArgs e)
        {
            this.informeParadasBindingSource.Filter = this.adgv_paradas.FilterString;
            adgv_paradas.DataSource.ToString();
            cargarTotales();
        }

        private void adgv_paradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adgv_paradas_SortStringChanged(object sender, AdvancedDataGridView.SortEventArgs e)
        {
            this.informeParadasBindingSource.Sort = this.adgv_paradas.SortString;
            cargarTotales();
        }

        private void dtp_inicio_ValueChanged(object sender, EventArgs e)
        {
            selectDateAsStringBefore = this.dtp_inicio.Text.ToString();
        }

        private void dtp_fin_ValueChanged(object sender, EventArgs e)
        {
            selectDateAsStringAfter = dtp_fin.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarDataGrid(informes.getInformeParadas(selectDateAsStringBefore, selectDateAsStringAfter));
            cargarTotales();
        }
    }
}
