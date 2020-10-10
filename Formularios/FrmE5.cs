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
    public partial class FrmE5 : Form
    {
        public FrmE5()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double discos, preciodiscos, descuento, totalpagar,subtotal;
            String descuentona;
            discos = double.Parse(txtdiscos.Text);
            preciodiscos = double.Parse(txtprecio.Text);
            if(discos>=3)
            {
                subtotal = preciodiscos * discos;
                descuento =  subtotal* 0.20;
                totalpagar = subtotal - descuento;
                txtdescuento.Text = descuento.ToString();
                txtpagar.Text = totalpagar.ToString();
                
            }
            else
            {
                subtotal = preciodiscos * discos;
                descuentona = "N/A";
                MessageBox.Show("No aplica tu descuento debido a que tu cómpra es menor a 3 productos");
                txtdescuento.Text = descuentona;
                txtpagar.Text = subtotal.ToString();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtpagar.Text = "";
            txtdiscos.Text = "";
            txtdescuento.Text = "";
            txtprecio.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
