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

namespace WindowsFormsApp4
{
    public partial class vendedor : Form
    {
        public vendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            try
            {
                //si o si debe haber \  en la conexion y se debe llamar al datareader.
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-J7EBE14\\SQLEXPRESS;Initial Catalog=prueba;Integrated Security=True");
                con.Open();
                string consulta1 = "SELECT * FROM datos";
                string consulta2 = "INSERT INTO datos(nombre,apellido) VALUES(@nombre,@apellido)";
                SqlCommand comando = new SqlCommand(consulta1, con);
                comando.Parameters.AddWithValue("@nombre",nombre);
                comando.Parameters.AddWithValue("@apellido",apellido);
                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    if (datos.GetValue(1).ToString() == nombre && datos.GetValue(2).ToString()==apellido)
                    {
                        datos.Close();
                        MessageBox.Show("El vendedor ya se encuentra registrado");
                        return;
                    }
                   
                }

                datos.Close();
                SqlCommand insertar = new SqlCommand(consulta2, con);
                insertar.Parameters.AddWithValue("@nombre", nombre);
                insertar.Parameters.AddWithValue("@apellido", apellido);
                SqlDataReader datos2 = insertar.ExecuteReader();
                MessageBox.Show("Se ha añadido un nuevo vendedor");
                this.Close();

            }
            catch(Exception err)
            {
                MessageBox.Show("Error : " + err);
            }




        }

        private void vendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
