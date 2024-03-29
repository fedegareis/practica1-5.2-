using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_v52
{
    public partial class Datosarchivo : Form
    {
        public Datosarchivo()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Datosarchivo_Load(object sender, EventArgs e)
        {

            lvarchivo.Columns.Add("Nombre");
            lvarchivo.Columns.Add("Apellido");
            lvarchivo.Columns.Add("DNI");
            lvarchivo.Columns.Add("Cant de Hijos");
            lvarchivo.Columns.Add("Estado civil");
            lvarchivo.Columns.Add("Fecha Nac");
            lvarchivo.View = View.Details;
            lvarchivo.GridLines = true;
            string[] cadena;
            string datos; int cont = 0;
            if(File.Exists("personas.txt"))
            {
                FileStream archivo = new FileStream("personas.txt", FileMode.Open);
                StreamReader leer = new StreamReader(archivo);
                while (leer.EndOfStream == false)
                {
                    datos = leer.ReadLine();
                    cadena = datos.Split(';');
                    lvarchivo.Items.Add(cadena[0]);
                    lvarchivo.Items[cont].SubItems.Add(cadena[1]);
                    lvarchivo.Items[cont].SubItems.Add(cadena[2]);
                    lvarchivo.Items[cont].SubItems.Add(cadena[3]);
                    lvarchivo.Items[cont].SubItems.Add(cadena[4]);
                    lvarchivo.Items[cont].SubItems.Add(cadena[5]);

                    cont++;
                }
                leer.Close();
                archivo.Close();
            }
            else
            {
                MessageBox.Show("El archivo no existe");
            }
        }
    }
}
