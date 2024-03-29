using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_v52
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro regis = new Registro();
            regis.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datosarchivo mostrar = new Datosarchivo();
            mostrar.Show();
        }
    }
}
