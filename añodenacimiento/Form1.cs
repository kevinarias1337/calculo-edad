using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace añodenacimiento
{
    public partial class programa : Form
    {
        public programa()
        {
            InitializeComponent();
        }

       

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            int añoactualtxt2 = int.Parse(añoactualtxt.Text);
            int añonacimientotxt2 = int.Parse(añonacimientotxt.Text);

          int btncalcular = añoactualtxt2 - añonacimientotxt2;
            MessageBox.Show("Su edad es de: " + btncalcular + " años.");
            añonacimientotxt.Text = "";
            añoactualtxt.Text = "";
            añonacimientotxt.Focus();
        }

        private void Programa_Load(object sender, EventArgs e)
        {
            añonacimientotxt.Focus();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si tiene dudas acerca del uso del programa envíe un email al siguiente correo:                                                      kevinlh1337@gmail.com");
        }
    }
}
