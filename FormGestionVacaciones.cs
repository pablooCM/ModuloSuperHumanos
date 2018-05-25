using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ModuloSuperHumanos
{
    public partial class FormGestionVacaciones : Form
    {
        public FormGestionVacaciones()
        {
            InitializeComponent();
        }

        private void buttonRegistrarVacaciones_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrearItinerario_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            SqlCommand cmd = new SqlCommand("dbo.crearItinerario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var parametro1 = new SqlParameter("@idVacaciones", SqlDbType.Int);
            parametro1.Direction = ParameterDirection.Input;
            parametro1.Value = textBoxIdVacaciones.Text;
            cmd.Parameters.Add(parametro1);



            var fechaSalidaFormat = dateTimePickerFechaSalidaVacaciones.Value.ToString("yyyy/MM/dd");
            var param9 = new SqlParameter("@fechaSalida", SqlDbType.Date);
            param9.Direction = ParameterDirection.Input;
            param9.Value = fechaSalidaFormat;
            cmd.Parameters.Add(param9);


            var fechaVueltaFormat = dateTimePickerVueltaVacaciones.Value.ToString("yyyy/MM/dd");
            var param11 = new SqlParameter("@fechaVuelta", SqlDbType.Date);
            param11.Direction = ParameterDirection.Input;
            param11.Value = fechaVueltaFormat;
            cmd.Parameters.Add(param11);

            var param2 = new SqlParameter("@lugares", SqlDbType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxLugaresaVisitar.Text;
            param2.Size = 200;
            cmd.Parameters.Add(param2);


            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Itinerario creado correctamente");
        }

        private void buttonConsultaItinerario_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta = "Select * from Vacaciones where idVacaciones=" + textBoxIdVacaciones.Text;
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            if (leerDatos.Read() == true)
            {
                dateTimePickerFechaSalidaVacaciones.Text = leerDatos["fechaSalida"].ToString();
                dateTimePickerVueltaVacaciones.Text = leerDatos["fechaVuelta"].ToString();
                textBoxLugaresaVisitar.Text = leerDatos["lugares"].ToString();

            }
            else
            {
                MessageBox.Show("No existe el cliente");
            }
        }

        private void buttonAsignarVacaciones_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            SqlCommand cmd = new SqlCommand("dbo.asignaVacacionesSuperHumano", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var param2 = new SqlParameter("@DNI", SqlDbType.Int);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxDNI.Text;
            cmd.Parameters.Add(param2);


            var parametro1 = new SqlParameter("@idVacaciones", SqlDbType.Int);
            parametro1.Direction = ParameterDirection.Input;
            parametro1.Value = textBoxIdVacaciones.Text;
            cmd.Parameters.Add(parametro1);


            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Itinerario asignado correctamente");


        }
    }
}
