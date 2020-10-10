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
    public partial class FrmE8 : Form
    {
        public FrmE8()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            double nota1;
            String obsera, repro;
            obsera = "aprobado";
            repro = "reprobado";
            nota1 = double.Parse(txtnota.Text);
            lstnombre.Items.Add(txtnombre.Text);
            lstnota.Items.Add(txtnota.Text);
            if (nota1 >= 65)
            {
                lstobservacion.Items.Add(obsera);
            }
            else
            {
                lstobservacion.Items.Add(repro);
            }

            txtnombre.Text = String.Empty;
            txtnota.Text = String.Empty;
        }
    }
}
