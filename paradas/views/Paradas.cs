using FluentValidation.Results;
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
using System.Xml.Linq;
using static System.Resources.ResXFileRef;

namespace paradas.views
{
    public partial class Paradas : Form
    {
        List<String> horarios = new List<String>();
        List<String> horarios2 = new List<String>();
        List<String> horarios3 = new List<String>();
        List<String> horarios4 = new List<String>();
        List<String> sectores= new List<String>() {"Empaque","Preseleccion","Otro" };
        //BuscarTurnos turnos = new BuscarTurnos() { "Mañana", "Tarde-Noche" };
        List<String> listaTurnos= new List<String>() { "Mañana", "Tarde-Noche" };
        List<Problemas>listaProblemas= new List<Problemas>();
        String hora;
        String minutos;
        String tipoParada = "";
        Generales generales= new Generales();
        public Paradas()
        {
            InitializeComponent();
            cargarCombo();
            horarios2.AddRange(horarios);
            horarios3.AddRange(horarios);
            horarios4.AddRange(horarios);
            //cb_hora_fin_parada.DataSource = horarios3;
            //cb_hora_inicio_parada.DataSource = horarios4;
            panel_problemas.Visible= false;
           r_total.Checked = true;

            Errores error = new Errores();

            listaProblemas = error.getErrores();
            DataTable dt = generales.ToDataTable(listaProblemas);

            dgv_problemas.AutoGenerateColumns = true;
            dgv_problemas.DataSource= dt;
            dgv_problemas.RowHeadersVisible = false;
            dgv_problemas.Columns[1].Width = 700;
            dgv_problemas.Columns[0].Visible= false;


            cb_sector.DataSource = sectores;
            string time = DateTime.Now.ToString("T");
            time = (generales.RellenarCadena(time, '0', 8, true)).Substring(0, 5);
            hora = time.Substring(0, 2);
            minutos = time.Substring(3, 2);
            this.txt_inicio_horas.Text = hora;
            this.txt_inicio_minutos.Text = minutos;


            cb_turno.DataSource = listaTurnos;

            cb_sector.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_turno.DropDownStyle = ComboBoxStyle.DropDownList;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "y-MM-dd";


        }

        public void setSector(String _sector)
        {
            int i = 0;
            foreach(var index in sectores)
            {
                if (_sector == index) {
                cb_sector.SelectedIndex = i;
                }
                i++;
            }
        }

        public void setTurno(String _turno)
        {
            int i = 0;
            foreach (var index in listaTurnos)
            {
                if (_turno == index)
                {
                    cb_turno.SelectedIndex = i;
                }
                i++;
            }
        }

        private void cargarCombo()
        {
            int i, j;

            for (i = 0; i < 24; i++)
            {
                for (j = 0; j < 60; j++)
                {
                    var hora = i.ToString("D2");
                    var minutos = j.ToString("D2");
                    if (i > 11)
                        horarios.Add($"{hora}:{minutos} PM");
                    else
                        horarios.Add($"{hora}:{minutos} AM");
                    j = j + 4;
                }
            }
            i++;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String inicioFecha = "";
            String finFecha = "";
            String nombre = "";
            String sector = "";
            String  turno = "";
            String problema = "";
            String obervaciones = "";
            String fecha = "";
           

            inicioFecha = "";
            finFecha = "";
            sector = cb_sector.Text;
            turno = cb_turno.Text;
            nombre = this.txt_nombre.Text;
            problema = this.txt_problemas.Text;
            obervaciones = this.txt_observaciones.Text;
            fecha = dateTimePicker1.Text;

            Validaciones validations = new Validaciones(this.txt_inicio_horas.Text,this.txt_inicio_minutos.Text,this.txt_horas_fin.Text, this.txt_minutos_fin.Text, nombre, sector, turno, problema);
            ValidationResult result = validations.Validate(nombre);

            if (!result.IsValid)
            {
                String errores = "";
                foreach (var errors in result.Errors)
                {
                    errores += $"{errors.ErrorMessage}  \n";
                    //MessageBox.Show(errors.ErrorMessage);
                    //pintarErrores(errors.ErrorMessage, errors.PropertyName);

                }
                MessageBox.Show(errores, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
               
                inicioFecha = $"{this.txt_inicio_horas.Text}:{this.txt_inicio_minutos.Text}";
                finFecha = $"{this.txt_horas_fin.Text}:{this.txt_minutos_fin.Text}";
                //MessageBox.Show(finFecha);
                Cargar cargar = new Cargar();
                cargar.setTablaRegistrosParadas(tipoParada,problema, inicioFecha, finFecha, sector, nombre, obervaciones, turno,fecha);
                MessageBox.Show("Se cargo un turno con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            

        }

        private void cb_turno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(this.txt_filtro.Text != "")
            {
                //listaTurnos = listaTurnos.Where(d => d.Contains(this.txt_filtro.Text));
                var list = listaProblemas.Where(d => d.Errores.ToUpper().Trim().Contains(this.txt_filtro.Text.ToUpper().Trim()));
                dgv_problemas.DataSource = list.ToList();
                
            }
            else
            {
                dgv_problemas.DataSource = listaProblemas.ToList();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            panel_problemas.Visible = true;
            this.txt_problemas.Visible = false;
            this.btn_informe.Visible= false;
            
        }

        private void ch_parcial_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ch_total_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void r_total_CheckedChanged(object sender, EventArgs e)
        {
            if (r_total.Checked == true) {
                tipoParada = "Total";
            }
        }

        private void dgv_problemas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.txt_problemas.Text = dgv_problemas.Rows[e.RowIndex].Cells[1].Value.ToString();
            panel_problemas.Visible = false;
            this.txt_problemas.Visible = true;
            this.btn_informe.Visible= true;
        }

        private void dgv_problemas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void r_parcial_CheckedChanged(object sender, EventArgs e)
        {
            if (r_parcial.Checked == true)
            {
                tipoParada = "Parcial";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InformeParadas informeParadas   = new InformeParadas();
            informeParadas.Show();
        }

        private void dgv_problemas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
