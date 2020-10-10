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
    public partial class FrmE2 : Form
    {
        public FrmE2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = double.Parse(txtnumero1.Text);
            n2 = double.Parse(txtnumero2.Text);
            if (n1 > n2)
            {
                MessageBox.Show("Elnumero 1 es mayor");
            }
            if (n1 == n2)
            {
                MessageBox.Show("Son iguales");
            }
            else
            {
                MessageBox.Show("Elnumero 2 es mayor");
            }
            
            

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero1.Text = "";
            txtnumero2.Text = "";
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
