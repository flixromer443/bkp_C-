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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        persona felix = new persona();

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vendedor vendedor = new vendedor();
            ventas ventas = new ventas();
            vendedor.ShowDialog();

                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            try
            {
                //Agregegar otra \ a la ruta de conexion,sino no funciona
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-J7EBE14\\SQLEXPRESS;Initial Catalog=prueba;Integrated Security=True");
                con.Open();
                string consulta = "INSERT  INTO datos(nombre,apellido) VALUES(@nombre,@apellido)";
                SqlCommand comando = new SqlCommand(consulta, con);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                SqlDataReader datos = comando.ExecuteReader();
                while (datos.Read()) {
                    if (datos.GetValue(1).ToString() == nombre)
                    {
                        MessageBox.Show(datos.GetValue(2).ToString());
                    }
                }
            }catch(Exception error)
            {
                MessageBox.Show("Ha ocurrido un error" + error);
            }
            
        }
    }
}
