using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2.Formularios
{
    public partial class FrmE7 : Form
    {
        public FrmE7()
        {
            InitializeComponent();
        }

        private void btnordenar_Click(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = double.Parse(txtnumero1.Text);
            n2 = double.Parse(txtnumero2.Text);
            if (n1 < n2)
            {
                txtmenor.Text = n1.ToString();
                txtmayor.Text = n2.ToString();
            }
            else
            {
                txtmenor.Text = n2.ToString();
                txtmayor.Text = n1.ToString();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtmayor.Text = "";
            txtmenor.Text = "";
            txtnumero1.Text = "";
            txtnumero2.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
