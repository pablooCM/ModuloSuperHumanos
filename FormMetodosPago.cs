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
    public partial class FormMetodosPago : Form
    {
        public FormMetodosPago()
        {
            InitializeComponent();
            llenarComboboxMetodosPago();
            llenarComboBoxSuperHumano();
        }
        private void llenarComboboxMetodosPago()
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();

            String consulta = "select nombreMetodoPago from MetodoPago";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();
            while (leerDatos.Read())
            {
                comboBoxMetodoDePago.Items.Add(leerDatos[0].ToString());
            }
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
                comboBoxSuperHeroe.Items.Add(leerDatos[0].ToString());
            }
        }

        private void buttonRegistrarPago_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection();
            conexion.ConnectionString = "Data Source=.;Initial Catalog =PlanillaPrueba;Persist Security Info=True;User ID=sa;Password=hardwork13";
            conexion.Open();



            String consulta = "select idMetodoPago from MetodoPago where nombreMetodoPago='" + comboBoxMetodoDePago.Text + "'";
            SqlCommand consultaEnBD = new SqlCommand(consulta, conexion);

            SqlDataReader leerDatos = consultaEnBD.ExecuteReader();

            if (leerDatos.Read() == true)
            {
                textBoxGeneraIdMetodoPago.Text = leerDatos["idMetodoPago"].ToString();
            }
            else
            {
                MessageBox.Show("No existe el metodo de pago");
            }
            leerDatos.Close();

            SqlCommand cmd = new SqlCommand("dbo.registraMetodoPagoconSuper", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            var parametro1 = new SqlParameter("@idMetodoPago", SqlDbType.Int);
            parametro1.Direction = ParameterDirection.Input;
            parametro1.Value = textBoxGeneraIdMetodoPago.Text;
            cmd.Parameters.Add(parametro1);

            String consulta2 = "select DNI from SuperHumano where nombreClave='" + comboBoxSuperHeroe.Text + "'";
            SqlCommand consultaEnBD2 = new SqlCommand(consulta2, conexion);

            SqlDataReader leerDatos2 = consultaEnBD2.ExecuteReader();

            if (leerDatos2.Read() == true)
            {
                textBoxGeneraDNISuperHeroe.Text = leerDatos2["DNI"].ToString();
            }
            else
            {
                MessageBox.Show("No existe el super humano");
            }
            leerDatos2.Close();

            var param2 = new SqlParameter("@DNI", SqlDbType.Int);
            param2.Direction = ParameterDirection.Input;
            param2.Value = textBoxGeneraDNISuperHeroe.Text;
            cmd.Parameters.Add(param2);

            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Metodo de pago registrado correctamente");


        }
    }
}
