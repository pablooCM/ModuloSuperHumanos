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
    public partial class FormPoderes : Form
    {
        public FormPoderes()
        {
            InitializeComponent();
            llenarListBoxPaises();
            llenarComboBoxTipoPoder();
        }

        private void llenarListBoxPaises()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta = "select nombrePais from Pais";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                listBoxPaises.Items.Add(leerDatos[0].ToString());
            }
        }

        private void llenarComboBoxTipoPoder()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta = "Select descripcionTipo from TiposDePoder";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                comboBoxTipoPoder.Items.Add(leerDatos[0].ToString());
            }
        }
        private void buttonCrearPoder_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            SqlCommand cmd = new SqlCommand("dbo.crearPoder", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var parametro1 = new SqlParameter("@idPoder", SqlDbType.Int);
            parametro1.Direction = ParameterDirection.Input;
            parametro1.Value = textBoxIdPoder.Text;
            cmd.Parameters.Add(parametro1);

            var param2 = new SqlParameter("@descripcion", SqlDbType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value =  textBoxDescripcionPoder.Text;
            param2.Size = 30;
            cmd.Parameters.Add(param2);

            String consulta = "select idTipo from TiposDePoder where descripcionTipo='" + comboBoxTipoPoder.Text + "'";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

            if (leerDatos.Read() == true)
            {
                textBoxGeneraIdTipoPoder.Text = leerDatos["idTipo"].ToString();
            }
            else
            {
                MessageBox.Show("No existe el tipo de poder");
            }
            leerDatos.Close();

            var param3 = new SqlParameter("@tipoPoder", SqlDbType.Int);
            param3.Direction = ParameterDirection.Input;
            param3.Value = textBoxGeneraIdTipoPoder.Text;
            cmd.Parameters.Add(param3);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Poder creado correctamente");
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            foreach (var item in listBoxPaises.SelectedItems)
            {
                MessageBox.Show(item.ToString());
                listBoxPaisesCobertura.Items.Add(item);

                String consulta = "select idPais from Pais where nombrePais='" + item + "'";
                SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

                SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

                if (leerDatos.Read() == true)
                {
                    textBoxGeneraIdPais.Text = leerDatos["idPais"].ToString();

                }
                else
                {
                    MessageBox.Show("No existe el pais");
                }
                leerDatos.Close();


                SqlCommand cmd = new SqlCommand("dbo.asignarPaisaPoderes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param1 = new SqlParameter("@idPoder", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = textBoxIdPoder.Text;
                cmd.Parameters.Add(param1);

                var param2 = new SqlParameter("@idPais", SqlDbType.Int);
                param2.Direction = ParameterDirection.Input;
                param2.Value = textBoxGeneraIdPais.Text;
                cmd.Parameters.Add(param2);

                cmd.ExecuteNonQuery();
                conexion.Close();
            }
        }

        private void buttonConsultarPoder_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta = "Select * from Poderes where idPoder=" + textBoxIdPoder.Text;
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            if (leerDatos.Read() == true)
            {
                textBoxDescripcionPoder.Text = leerDatos["descripcion"].ToString();
                comboBoxTipoPoder.Text = leerDatos["tipoPoder"].ToString();


            }
            else
            {
                MessageBox.Show("No existe el cliente");
            }
        }

        private void buttonActualizarPoder_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            SqlCommand cmd = new SqlCommand("dbo.actualizarPoder", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var parametro1 = new SqlParameter("@idPoder", SqlDbType.Int);
            parametro1.Direction = ParameterDirection.Input;
            parametro1.Value = textBoxIdPoder.Text;
            cmd.Parameters.Add(parametro1);

            var param2 = new SqlParameter("@descripcion", SqlDbType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxDescripcionPoder.Text;
            param2.Size = 30;
            cmd.Parameters.Add(param2);

            String consulta = "select idTipo from TiposDePoder where descripcionTipo='" + comboBoxTipoPoder.Text + "'";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

            if (leerDatos.Read() == true)
            {
                textBoxGeneraIdTipoPoder.Text = leerDatos["idTipo"].ToString();
            }
            else
            {
                MessageBox.Show("No existe el tipo de poder");
            }
            leerDatos.Close();

            var param3 = new SqlParameter("@tipoPoder", SqlDbType.Int);
            param3.Direction = ParameterDirection.Input;
            param3.Value = textBoxGeneraIdTipoPoder.Text;
            cmd.Parameters.Add(param3);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Poder actualizado correctamente");
        }

        private void buttonBorrarPoder_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
                conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
                conexion.Open();

                SqlCommand cmd = new SqlCommand("dbo.borrarPoder", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param1 = new SqlParameter("@idPoder", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = textBoxIdPoder.Text;
                cmd.Parameters.Add(param1);

                cmd.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Se ha borrado el Poder");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
    
}
