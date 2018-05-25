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
    public partial class FormSuperHumano : Form
    {
        public FormSuperHumano()
        {
            InitializeComponent();
            llenaComboBoxEstado();
            llenaComboBoxPoderes();
            llenarComboBoxCategorias();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void llenaComboBoxEstado()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta = "Select descripcion from Estado";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                comboBoxEstado.Items.Add(leerDatos[0].ToString());
            }
        }
        private void llenaComboBoxPoderes()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta = "Select descripcion from Poderes";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                comboBoxSeleccionePoder.Items.Add(leerDatos[0].ToString());
            }
        }

        private void llenarComboBoxCategorias()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta = "Select nombreCategoria from Categoria";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                comboBoxSeleccioneCategoria.Items.Add(leerDatos[0].ToString());
            }
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            SqlCommand cmd = new SqlCommand("dbo.crearSuperHumano", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var parametro1 = new SqlParameter("@DNI", SqlDbType.Int);
            parametro1.Direction = ParameterDirection.Input;
            parametro1.Value = textBoxDNI.Text;
            cmd.Parameters.Add(parametro1);

            var param2 = new SqlParameter("@nombre", SqlDbType.VarChar);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxNombre.Text;
            param2.Size = 30;
            cmd.Parameters.Add(param2);

            var param3 = new SqlParameter("@apellido1", SqlDbType.VarChar);
            param3.Direction = ParameterDirection.Input;
            param3.Value = textBoxApellido1.Text;
            param3.Size = 30;
            cmd.Parameters.Add(param3);

            var param4 = new SqlParameter("@apellido2", SqlDbType.VarChar);
            param4.Direction = ParameterDirection.Input;
            param4.Value = textBoxApellido2.Text;
            param4.Size = 30;
            cmd.Parameters.Add(param4);

            var param6 = new SqlParameter("pais", SqlDbType.Int);
            param6.Direction = ParameterDirection.Input;
            param6.Value = textBoxPais.Text;
            cmd.Parameters.Add(param6);

            var param5 = new SqlParameter("@ciudad", SqlDbType.VarChar);
            param5.Direction = ParameterDirection.Input;
            param5.Value = textBoxCiudad.Text;
            param5.Size = 30;
            cmd.Parameters.Add(param5);

            var param7 = new SqlParameter("@correoElectronico", SqlDbType.VarChar);
            param7.Direction = ParameterDirection.Input;
            param7.Value = textBoxCorreoElectronico.Text;
            param7.Size = 30;
            cmd.Parameters.Add(param7);

            var param8 = new SqlParameter("@nombreClave", SqlDbType.VarChar);
            param8.Direction = ParameterDirection.Input;
            param8.Value = textBoxNombreClave.Text;
            param8.Size = 30;
            cmd.Parameters.Add(param8);


            var fechaFormat = dateTimePickerFechaCumpleannos.Value.ToString("yyyy/MM/dd");
            var param9 = new SqlParameter("@cumpleannos", SqlDbType.Date);
            param9.Direction = ParameterDirection.Input;
            param9.Value = fechaFormat;
            cmd.Parameters.Add(param9);



            var parametro10 = new SqlParameter("@estado", SqlDbType.Int);
            parametro10.Direction = ParameterDirection.Input;
            String estado ="1";
            if (comboBoxEstado.Text == "vivo")
                estado = "1";
            if (comboBoxEstado.Text == "activo")
                estado = "2";
            if (comboBoxEstado.Text == "retirado")
                estado = "3";
            if (comboBoxEstado.Text == "cuidando a Martha")
                estado = "4";
            if (comboBoxEstado.Text == "destruido por Thanos")
                estado = "5";
            parametro10.Value = estado;
            cmd.Parameters.Add(parametro10);


            var parametro11 = new SqlParameter("@salario", SqlDbType.Float);
            parametro11.Direction = ParameterDirection.Input;
            parametro11.Value = textBoxSalario.Text;
            cmd.Parameters.Add(parametro11);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("SuperHumano creado correctamente");





        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta = "Select * from SuperHumano where DNI=" + textBoxDNI.Text;
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            if (leerDatos.Read() == true)
            {
                textBoxNombre.Text = leerDatos["nombre"].ToString();
                textBoxApellido1.Text = leerDatos["apellido1"].ToString();
                textBoxApellido2.Text = leerDatos["apellido2"].ToString();
                textBoxPais.Text = leerDatos["pais"].ToString();
                textBoxCiudad.Text = leerDatos["ciudad"].ToString();
                textBoxCorreoElectronico.Text = leerDatos["correoElectronico"].ToString();
                textBoxNombreClave.Text = leerDatos["nombreClave"].ToString();
                dateTimePickerFechaCumpleannos.Text = leerDatos["cumpleannos"].ToString();
                comboBoxEstado.Text = leerDatos["estado"].ToString();
                textBoxSalario.Text = leerDatos["salario"].ToString();

            }
            else
            {
                MessageBox.Show("No existe el cliente");
            }
        }

        private void buttonAsignarPoder_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta = "select idPoder from Poderes where descripcion='" + comboBoxSeleccionePoder.Text + "'";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

            if (leerDatos.Read() == true)
            {
                textBoxGeneraIdPoder.Text = leerDatos["idPoder"].ToString();

            }
            else
            {
                MessageBox.Show("No existe el servicio");
            }
            leerDatos.Close();

            SqlCommand cmd = new SqlCommand("dbo.asignarPoder", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var param1 = new SqlParameter("@DNI", SqlDbType.Int);
            param1.Direction = ParameterDirection.Input;
            param1.Value = textBoxDNI.Text;
            cmd.Parameters.Add(param1);

            var param2 = new SqlParameter("@idPoder", SqlDbType.Int);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxGeneraIdPoder.Text;
            cmd.Parameters.Add(param2);

            var param3 = new SqlParameter("@estadoPoder", SqlDbType.VarChar);
            param3.Direction = ParameterDirection.Input;
            param3.Value = textBoxEstadoPoder.Text;
            param3.Size = 30;
            cmd.Parameters.Add(param3);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Poder asignado correctamente");
        }

        private void buttonAsignarCategoria_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta = "select idCategoria from Categoria where nombreCategoria='" + comboBoxSeleccioneCategoria.Text + "'";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

            if (leerDatos.Read() == true)
            {
                textBoxGeneraIdCategoria.Text = leerDatos["idCategoria"].ToString();

            }
            else
            {
                MessageBox.Show("No existe la categoria");
            }
            leerDatos.Close();

            SqlCommand cmd = new SqlCommand("dbo.asignarCategoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var param1 = new SqlParameter("@DNI", SqlDbType.Int);
            param1.Direction = ParameterDirection.Input;
            param1.Value = textBoxDNI.Text;
            cmd.Parameters.Add(param1);

            var param2 = new SqlParameter("@idCategoria", SqlDbType.Int);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxGeneraIdCategoria.Text;
            cmd.Parameters.Add(param2);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Categoria asignada correctamente");
        }

        private void buttonConsultaCategoria_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta = "Select * from Categoria where idCategoria=" + textBoxGeneraIdCategoria.Text;
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            if (leerDatos.Read() == true)
            {
                textBoxConsultaCategoria.Text = leerDatos["descripcion"].ToString();
            }
            else
            {
                MessageBox.Show("No existe la categoria");
            }

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            SqlCommand cmd = new SqlCommand("dbo.actualizarSuperHumano", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                var parametro1 = new SqlParameter("@DNI", SqlDbType.Int);
                parametro1.Direction = ParameterDirection.Input;
                parametro1.Value = textBoxDNI.Text;
                cmd.Parameters.Add(parametro1);

                var param2 = new SqlParameter("@nombre", SqlDbType.VarChar);
                param2.Direction = ParameterDirection.Input;
                param2.Value = textBoxNombre.Text;
                param2.Size = 30;
                cmd.Parameters.Add(param2);

                var param3 = new SqlParameter("@apellido1", SqlDbType.VarChar);
                param3.Direction = ParameterDirection.Input;
                param3.Value = textBoxApellido1.Text;
                param3.Size = 30;
                cmd.Parameters.Add(param3);

                var param4 = new SqlParameter("@apellido2", SqlDbType.VarChar);
                param4.Direction = ParameterDirection.Input;
                param4.Value = textBoxApellido2.Text;
                param4.Size = 30;
                cmd.Parameters.Add(param4);

                var param6 = new SqlParameter("pais", SqlDbType.Int);
                param6.Direction = ParameterDirection.Input;
                param6.Value = textBoxPais.Text;
                cmd.Parameters.Add(param6);

                var param5 = new SqlParameter("@ciudad", SqlDbType.VarChar);
                param5.Direction = ParameterDirection.Input;
                param5.Value = textBoxCiudad.Text;
                param5.Size = 30;
                cmd.Parameters.Add(param5);

                var param7 = new SqlParameter("@correoElectronico", SqlDbType.VarChar);
                param7.Direction = ParameterDirection.Input;
                param7.Value = textBoxCorreoElectronico.Text;
                param7.Size = 30;
                cmd.Parameters.Add(param7);

                var param8 = new SqlParameter("@nombreClave", SqlDbType.VarChar);
                param8.Direction = ParameterDirection.Input;
                param8.Value = textBoxNombreClave.Text;
                param8.Size = 30;
                cmd.Parameters.Add(param8);


                var fechaFormat = dateTimePickerFechaCumpleannos.Value.ToString("yyyy/MM/dd");
                var param9 = new SqlParameter("@cumpleannos", SqlDbType.Date);
                param9.Direction = ParameterDirection.Input;
                param9.Value = fechaFormat;
                cmd.Parameters.Add(param9);



                var parametro10 = new SqlParameter("@estado", SqlDbType.Int);
                parametro10.Direction = ParameterDirection.Input;
                String estado = "1";
                if (comboBoxEstado.Text == "vivo")
                    estado = "1";
                if (comboBoxEstado.Text == "activo")
                    estado = "2";
                if (comboBoxEstado.Text == "retirado")
                    estado = "3";
                if (comboBoxEstado.Text == "cuidando a Martha")
                    estado = "4";
                if (comboBoxEstado.Text == "destruido por Thanos")
                    estado = "5";
                parametro10.Value = estado;
                cmd.Parameters.Add(parametro10);


                var parametro11 = new SqlParameter("@salario", SqlDbType.Float);
                parametro11.Direction = ParameterDirection.Input;
                parametro11.Value = textBoxSalario.Text;
                cmd.Parameters.Add(parametro11);

                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("SuperHumano actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
                conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
                conexion.Open();

                SqlCommand cmd = new SqlCommand("dbo.borrarSuperHumano", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                var param1 = new SqlParameter("@DNI", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = textBoxDNI.Text;
                cmd.Parameters.Add(param1);

                cmd.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Se ha borrado el Super Humano");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
