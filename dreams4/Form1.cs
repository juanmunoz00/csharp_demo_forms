using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dreams4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHola_Click(object sender, EventArgs e)
        {
            ////Aqui se almacenan los valores que el usuario capturo
            string nombre = txtNombre.Text;
            string contrasena = txtContrasena.Text;

            ////Aqui se definen los valores a comparara
            string nombre_correcto = "diana";
            string contrasena_correcta = "1234";

            if (nombre == nombre_correcto)
            {
                if (contrasena == contrasena_correcta)
                {
                    ///MessageBox.Show("Hola " + nombre);
                    ///
                    Proveedores proveedores = new Proveedores();
                    proveedores.Show();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Contrasena incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }

        }
    }
}
