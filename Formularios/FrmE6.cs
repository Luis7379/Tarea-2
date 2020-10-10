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
    public partial class FrmE6 : Form
    {
        public FrmE6()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double bol, pb, tp;
            bol = double.Parse(txtboletos.Text);
            if (bol >= 10)
            {
                pb = bol * 80;
                MessageBox.Show("Su boleto tiene un valor de L. 80 porque su compra es mayor a 10 boletos");
                txtprecio.Text = "80".ToString();
                txttotal.Text = pb.ToString();
            }
            else
            {
                pb = bol * 100;
                MessageBox.Show("Su boleto tiene un valor de L. 100 porque su compra es menor a 10 boletos");
                txtprecio.Text = "100".ToString();
                txttotal.Text = pb.ToString();
            }
            

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtprecio.Text = "";
            txtboletos.Text = "";
            txttotal.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
