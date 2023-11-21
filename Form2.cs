using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void listadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 menu = new Form3();
            menu.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

     
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {


            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?", "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogo == DialogResult.No)
            {
                e.Cancel = true;
            }

            else
            {
                e.Cancel = false;

            }


        }


        private void Form2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

    }
}
