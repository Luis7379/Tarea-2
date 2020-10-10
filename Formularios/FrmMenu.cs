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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FrmE1();
            formulario1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario2 = new FrmE2();
            formulario2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario3 = new FrmE3();
            formulario3.Show();
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            Form formulario4 = new FrmE4();
            formulario4.Show();
        }

        private void btnE5_Click(object sender, EventArgs e)
        {
            Form formulario5 = new FrmE5();
            formulario5.Show();
        }

        private void btnE6_Click(object sender, EventArgs e)
        {
            Form formulario6 = new FrmE6();
            formulario6.Show();
        }

        private void btnE7_Click(object sender, EventArgs e)
        {
            Form formulario7 = new FrmE7();
            formulario7.Show();
        }

        private void btnE8_Click(object sender, EventArgs e)
        {
            Form formulario8 = new FrmE8();
            formulario8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario9 = new FrmE9();
            formulario9.Show();
        }
    }
    }

