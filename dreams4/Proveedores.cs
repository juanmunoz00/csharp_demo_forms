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
    public partial class Proveedores : Form
    {
        Form1 form1 = new Form1();
        Clientes frmClientes = new Clientes();

        /// <summary>
        /// La sintaxis de la lista es:
        /// List<tipo_de_dato> nombre_lista = new List<tipo_de_dato>
        /// </summary>

        public static List<string> lstNombres = new List<string>();
        public static List<string> lstDirecciones = new List<string>();

        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

            this.FormClosing += new FormClosingEventHandler(Inicio_FormClosing_1);
            this.FormClosed += new FormClosedEventHandler(Inicio_FormClosed_1);
        }


        private void Inicio_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //Things while closing
            this.Close();
        }

        private void Inicio_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            //Things when closed
            form1.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDir.Text = "";
            txtTel.Text = "";
            txtCorreo.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ////declaramos la variable y le asignamos el valor
            string nombre = txtNombre.Text;
            string direccion = txtDir.Text;

            ////agregamos el nombre al list box
            lstBNombres.Items.Add(nombre);

            ////agregamos el nombre al arreglo de nombres
            lstNombres.Add(nombre);
            ////agregamos la direccion al arreglo de direcicones
            lstDirecciones.Add(direccion);

            ////limpiamos el campo y le devolvemos el foco
            LimpiarCampos();
            txtNombre.Focus();
        }

        private void lstBNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////Decalramos variables
            int intSelectedIndex = lstBNombres.SelectedIndex; ////este es el indice del elemento seleccionado de la list box
            ////convertimos el indice del elemento a string para poder manipularlo
            string selectedIndex = Convert.ToString(intSelectedIndex);

            ////Extraemos el valor del indice de cada lista
            string nombre = lstNombres[intSelectedIndex];
            string direccion = lstDirecciones[intSelectedIndex];

            lblSelIndx.Text = "Selected Index de: " + lstBNombres.Text + " es: " + selectedIndex;

            ////desplegamos los valores de la lista
            lblNombre.Text = nombre;
            lblDir.Text = direccion;



        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmClientes.ShowDialog();
        }
    }
}
