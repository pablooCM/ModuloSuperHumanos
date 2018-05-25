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
    public partial class FormGestionEquipos : Form
    {
        public FormGestionEquipos()
        {
            InitializeComponent();
            llenarComboBoxSuperHumano();
        }

        private void llenarComboBoxSuperHumano()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta = "select nombreClave from SuperHumano";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                comboBoxSuperHumano.Items.Add(leerDatos[0].ToString());
            }
        }

        private void buttonCrearEquipo_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            SqlCommand cmd = new SqlCommand("dbo.crearEquipo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var parametro1 = new SqlParameter("@idEquipo", SqlDbType.Int);
            parametro1.Direction = ParameterDirection.Input;
            parametro1.Value = textBoxIdEquipo.Text;
            cmd.Parameters.Add(parametro1);

            var param2 = new SqlParameter("@nombreEquipo", SqlDbType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxNombreEquipo.Text;
            param2.Size = 30;
            cmd.Parameters.Add(param2);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Equipo creado correctamente");
        }

        private void buttonConsultarEquipo_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta = "Select * from EquipoTrabajo where idEquipo=" + textBoxIdEquipo.Text;
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            if (leerDatos.Read() == true)
            {
                textBoxNombreEquipo.Text = leerDatos["nombreEquipo"].ToString();
            }
            else
            {
                MessageBox.Show("No existe el equipo");
            }
        }

        private void buttonActualizarEquipo_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            SqlCommand cmd = new SqlCommand("dbo.actualizarEquipo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var parametro1 = new SqlParameter("@idEquipo", SqlDbType.Int);
            parametro1.Direction = ParameterDirection.Input;
            parametro1.Value = textBoxIdEquipo.Text;
            cmd.Parameters.Add(parametro1);

            var param2 = new SqlParameter("@nombreEquipo", SqlDbType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxNombreEquipo.Text;
            param2.Size = 30;
            cmd.Parameters.Add(param2);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Equipo actualizado correctamente");
        }

        private void buttonBorrarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
                conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
                conexion.Open();

                SqlCommand cmd = new SqlCommand("dbo.borrarEquipo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param1 = new SqlParameter("@idEquipo", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = textBoxIdEquipo.Text;
                cmd.Parameters.Add(param1);

                cmd.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Se ha borrado el Equipo de Trabajo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();


            SqlCommand cmd = new SqlCommand("dbo.asignarSuperHumanoaEquipo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            String consulta2 = "select DNI from SuperHumano where nombreClave='" + comboBoxSuperHumano.Text + "'";
            SqlCommand consultaEnBD2 = new SqlCommand(consulta2, conexion);

            SqlDataReader leerDatos2 = consultaEnBD2.ExecuteReader();

            if (leerDatos2.Read() == true)
            {
                textBoxGeneraDNISuperHumano.Text = leerDatos2["DNI"].ToString();
            }
            else
            {
                MessageBox.Show("No existe el super humano");
            }
            leerDatos2.Close();

            var param2 = new SqlParameter("@DNI", SqlDbType.Int);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxGeneraDNISuperHumano.Text;
            cmd.Parameters.Add(param2);

            var parametro1 = new SqlParameter("@idEquipo", SqlDbType.Int);
            parametro1.Direction = ParameterDirection.Input;
            parametro1.Value = textBoxIdEquipo.Text;
            cmd.Parameters.Add(parametro1);



            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Super Humano asignadocorrectamente");
        }

        private void buttonQuitardeEquipo_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta2 = "select DNI from SuperHumano where nombreClave='" + comboBoxSuperHumano.Text + "'";
            SqlCommand consultaEnBD2 = new SqlCommand(consulta2, conexion);

            SqlDataReader leerDatos2 = consultaEnBD2.ExecuteReader();

            if (leerDatos2.Read() == true)
            {
                textBoxGeneraDNISuperHumano.Text = leerDatos2["DNI"].ToString();
            }
            else
            {
                MessageBox.Show("No existe el super humano");
            }
            leerDatos2.Close();
            try
            {

                SqlCommand cmd = new SqlCommand("dbo.quitarSuperHumanodeEquipo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param2 = new SqlParameter("@DNI", SqlDbType.Int);
                param2.Direction = ParameterDirection.Input;
                param2.Value = textBoxGeneraDNISuperHumano.Text;
                cmd.Parameters.Add(param2);

                var parametro1 = new SqlParameter("@idEquipo", SqlDbType.Int);
                parametro1.Direction = ParameterDirection.Input;
                parametro1.Value = textBoxIdEquipo.Text;
                cmd.Parameters.Add(parametro1);

                cmd.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Se ha borrado Super humano de Equipo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
