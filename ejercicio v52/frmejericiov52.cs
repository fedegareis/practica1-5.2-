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
    public partial class frmejericiov52 : Form
    {
        public frmejericiov52()
        {
            InitializeComponent();
                     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Menu menu = new Menu();
            menu.Show();  
        }

        private void frmejericiov52_Load(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            timer1.Start();
        }
    }
}
