using FluentValidation.Results;
using paradas.models;
using paradas.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paradas
{
    public partial class Form1 : Form
    {
        List<String> horarios = new List<String>();
        List<String> horarios2 = new List<String>();
        List<String> sector = new List<String>() {"Preseleccion","Empaque" };
        BuscarTurnos buscar = new BuscarTurnos();
        List<String> turnos = new List<String>() {"Mañana","Tarde-Noche" };
        String hora;
        String minutos;
        String fecha = "";
        public Form1()
        {
            InitializeComponent(); 
            cargarCombo();
            horarios2.AddRange(horarios);
            Generales generales= new Generales();
            string time = DateTime.Now.ToString("T");
            time = (generales.RellenarCadena(time, '0', 8, true)).Substring(0, 5);

            //MessageBox.Show(time);
             hora = time.Substring(0, 2);
             minutos= time.Substring(3, 2);
           this.txt_inicio_horas.Text = hora;
            this.txt_inicio_minutos.Text = minutos;
            //cb_hora_inicio.DataSource= horarios;
            //cb_hora_fin.DataSource= horarios2;
            cb_sector.DataSource= sector;
            cb_turno.DataSource= turnos;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "y-MM-dd";

       




 


           //cb_hora_fin.DropDownStyle = ComboBoxStyle.DropDownList;
            //cb_hora_inicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_turno.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sector.DropDownStyle = ComboBoxStyle.DropDownList;
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_turno_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* foreach(var index in turnos)
            {
                if(this.cb_turno.Text == index.Turno)
                {
                    this.txt_turno.Text = $" de {index.Hora_inicio} a {index.Hora_fin}";
                }
            }*/
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Paradas paradas= new Paradas();
            paradas.setSector(cb_sector.Text);
            paradas.setTurno(cb_turno.Text);
            paradas.Show();
        }

        private void btn_cargar_turno_Click(object sender, EventArgs e)
        {

            String Errores = "";
            ValidacionesTurnos validations = new ValidacionesTurnos(this.txt_inicio_horas.Text, this.txt_inicio_minutos.Text, this.txt_horas_fin.Text, this.txt_minutos_fin.Text, this.txt_personas.Text, this.cb_sector.Text, cb_turno.Text, this.txt_bins.Text);
            ValidationResult result = validations.Validate(hora);

            if (!result.IsValid)
            {

                foreach (var errors in result.Errors)
                {

                    Errores += $"{errors.ErrorMessage}  \n";
                    //MessageBox.Show(errors.ErrorMessage);

                }
                //MessageBox.Show("Welcome to C# Corner", "Learn C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(Errores,"",MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                String horaInicio = $"{this.txt_inicio_horas.Text}:{this.txt_inicio_minutos.Text}";
                String horaFin = $"{this.txt_horas_fin.Text}:{this.txt_minutos_fin.Text}";
                int cantidad_personas = Convert.ToInt32(this.txt_personas.Text);
                int cantidad_bins = Convert.ToInt32(this.txt_bins.Text);
                String turno = this.cb_turno.Text;
                String sector = this.cb_sector.Text;
                fecha = dateTimePicker1.Text;
                Cargar cargar = new Cargar();
                 cargar.setTablaParadasTurnos(horaInicio, horaFin, fecha, cantidad_personas,cantidad_bins,turno,sector);
                MessageBox.Show("Se cargo un turno con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_inicio_horas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_inicio_horas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

      
        }

        private void txt_inicio_minutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_horas_fin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_minutos_fin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_minutos_fin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Informe informe = new Informe();
            informe.Show();
        }
    }
}
