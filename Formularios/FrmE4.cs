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
    public partial class FrmE4 : Form
    {
        public FrmE4()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double n1,cuadrado,cubo;
            n1 = double.Parse(txtnumero.Text);
            if(n1>=10)
            {
                MessageBox.Show("El numero ingresado es mayor a 10 por lo tanto se calculará el cuadrado");
                cuadrado = n1 * n1;
                txtcu.Text = cuadrado.ToString();
            }
            else
            {
                MessageBox.Show("El numero ingresado es mayor a 10 por lo tanto se calculará el cubo");
                    cubo = n1 * n1 * n1;
                txtcu.Text = cubo.ToString();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcu.Text = "";
            txtnumero.Text = "";
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
