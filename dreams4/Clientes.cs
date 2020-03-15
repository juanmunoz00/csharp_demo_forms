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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            List<string> lista_de_clientes = new List<string>();

            lista_de_clientes = Proveedores.lstNombres;
            ////int iElemento = 0;

            foreach (string cliente in lista_de_clientes)
                lstB_ListaClientes.Items.Add(cliente);

        }
    }
}
