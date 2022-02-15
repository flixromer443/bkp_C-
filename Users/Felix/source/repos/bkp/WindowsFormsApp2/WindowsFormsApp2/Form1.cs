using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(usuario.Text=="")
            {
                MessageBox.Show("Por favor ingrese su usuario");
       
            }
            if (contraseña.Text == "")
            {
                MessageBox.Show("Por favor ingrese su contraseña");

            }
            else
            {
               
                if(usuario.TextLength<4 || contraseña.TextLength<4)
                {
                    MessageBox.Show("Su usuario y/o contraseña son incorrectos");
                }
                else
                {
                    MessageBox.Show("Usted ha iniciado sesion correctamente");
                    this.Close();

                }
               
            }
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
