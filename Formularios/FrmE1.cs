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
    public partial class FrmE1 : Form
    {
        public FrmE1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnota1.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Ingrese una nota válida");
                txtnota1.Focus();
                return;
            }
            if(txtnota2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese una nota válida");
                txtnota2.Focus();
                return;
            }
            if(txtnota3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese una nota válida");
                txtnota3.Focus();
                return;
            }
            double n1, n2, n3, prom;
            n1 = double.Parse(txtnota1.Text);
            n2 = double.Parse(txtnota2.Text);
            n3 = double.Parse(txtnota3.Text);
            prom = (n1 + n2 + n3) / 3;
            txtpromedio.Text = prom.ToString();
            if (prom >= 60)
            {
                MessageBox.Show("Aprobado");
                
               
            }
            else
            {
                MessageBox.Show("Reprobado");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnota1.Text = "";
            txtnota2.Text = "";
            txtnota3.Text = "";
            txtpromedio.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
