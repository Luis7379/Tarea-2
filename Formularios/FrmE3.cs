using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2.Formularios
{
    public partial class FrmE3 : Form
    {
        public FrmE3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            String pos, neg;
            double n1;
            n1 = double.Parse(txtnumero.Text);
            pos = "positivo";
            neg = "negativo";
            if (n1 <= 0)
            {
                txtpos.Text = neg;
            }
            else
            {
                txtpos.Text = pos;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero.Text = "";
            txtpos.Text = "";
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
