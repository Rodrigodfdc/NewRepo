using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            cargarProyectos();
            int posicion = 15;
            int contadorNombre = 15;
            foreach(string proyecto in arrayProyecto)
            {


                crearEtiqueta(proyecto, posicion, contadorNombre);
                posicion += 25;
                contadorNombre += 1;

            }


        }


        private string[] arrayProyecto = new string[6];

        private void cargarProyectos()
        {
            arrayProyecto[0] = "Hielo";
            arrayProyecto[1] = "Desierto";
            arrayProyecto[2] = "Bosque";
            arrayProyecto[3] = "Montañas";
            arrayProyecto[4] = "Sector 5";
            arrayProyecto[5] = "Mar Digital";
        }
        private void crearEtiqueta(string proyecto, int posicion, int contadorNombre)
        {
            Label LblProyecto = new
            System.Windows.Forms.Label();
            LblProyecto.AutoSize = true;
            LblProyecto.Font = new
            System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LblProyecto.Location = new
            System.Drawing.Point(75, posicion);
            LblProyecto.Name = "lblProyecto"
            + contadorNombre;
            LblProyecto.Size = new System.Drawing.Size(291,
            20);
            LblProyecto.TabIndex = 1;
            LblProyecto.Text = proyecto;
            groupBox1.Controls.Add(LblProyecto);
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            Array.Sort(arrayProyecto);
            groupBox1.Controls.Clear();
            int posicion = 15;
            int contadorNombre = 15;
            foreach (string proyecto in arrayProyecto)
            {


                crearEtiqueta(proyecto, posicion, contadorNombre);
                posicion += 25;
                contadorNombre += 1;

            }




        }
    }
}




