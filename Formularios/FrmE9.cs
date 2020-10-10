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
    public partial class FrmE9 : Form
    {
        public FrmE9()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            double precio,total;
            precio = double.Parse(txtprecio.Text);
            lstproducto.Items.Add(txtproducto.Text);
            lstprecio.Items.Add(txtprecio.Text);
            foreach(object item in lstprecio.Items)
            {
                total+= Convert.ToDouble(item);
                txttotal.Text = total.ToString();
            }

            txtprecio.Text = String.Empty;
            txtproducto.Text = String.Empty;
            
        }
    }
}
