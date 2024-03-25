using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_v52
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                lsvdatos.Items.Add(txtnombre.Text);
                lsvdatos.Items[0].SubItems.Add(txtapellido.Text);
                lsvdatos.Items[0].SubItems.Add(txtdni.Text);
                lsvdatos.Items[0].SubItems.Add(txtcantidad.Text);
                lsvdatos.Items[0].SubItems.Add(cbestado.Text);
                lsvdatos.Items[0].SubItems.Add(dtpnac.Text);
            }
        }
        
        public bool verificar()
        {
            int valor;
            bool ok=false;

            if (txtnombre.Text.Trim() != string.Empty ) 
            {
                if (int.TryParse(txtnombre.Text, out valor))
                {
                    MessageBox.Show("El nombre no debe contrener numeros ni simbolos");
                }
                else 
                {
                    ok = true; 
                }
            }
            else
            {
                MessageBox.Show("La casilla 'Nombre' se encuentra vacia"); 
            }


            if (ok)
            {
                ok = false;
                if (txtapellido.Text.Trim() != string.Empty)
                {

                    if (int.TryParse(txtapellido.Text, out valor))
                    {
                        MessageBox.Show("El apellido no debe contrener numeros ni simbolos");
                    }
                    else
                    {
                        ok = true;
                    }
                }
                else
                {
                    MessageBox.Show("La casilla 'apellido' se encuentra vacia");
                }
            }

          
            if (ok)
            { 
                ok = false;
                if (txtdni.Text.Trim() != string.Empty)
                {
                    if (int.TryParse(txtdni.Text, out valor))
                    {
                        ok = true;
                    }
                    else 
                    {
                        MessageBox.Show("DNI solo admite valores numericos sin letras ni signos");
                    }
                }
                else
                {
                    MessageBox.Show("La casilla 'DNI' se encuentra vacia");
                }
            }

            if (ok)
            {
                ok = false;
                if (txtcantidad.Text.Trim() != string.Empty)
                {
                    if (int.TryParse(txtcantidad.Text, out valor))
                    {
                        ok = true;
                    }
                    else
                    {
                        MessageBox.Show("Cant de Hijos solo admite valores numericos sin letras ni signos");
                    }
                }
                else
                {
                    MessageBox.Show("La casilla 'Cant de Hijos' se encuentra vacia");
                }
            }
            return ok;
        }

        private void lsvdatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            cbestado.Items.Add("Soltero");
            cbestado.Items.Add("Casado");
            cbestado.Items.Add("Divorciado");
            cbestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbestado.SelectedIndex = 0;
           
           
            lsvdatos.Columns.Add("Nombre");
            lsvdatos.Columns.Add("Apellido");
            lsvdatos.Columns.Add("DNI");
            lsvdatos.Columns.Add("Cant de Hijos");
            lsvdatos.Columns.Add("Estado civil");
            lsvdatos.Columns.Add("Fecha Nac");
            lsvdatos.View = View.Details;
            lsvdatos.GridLines = true;




        }
    }
}
