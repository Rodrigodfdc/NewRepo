using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }

        private string[] listaUsuariosNombre = new string[6];
        private string[] listaUsuariosClave = new string[6];
        int contador = 0;
        private void cargarUsuarios()
        {
            listaUsuariosNombre[0] = "root";
            listaUsuariosNombre[1] = "juan";
            listaUsuariosNombre[2] = "jaime";
            listaUsuariosNombre[3] = "jose";
            listaUsuariosNombre[4] = "javier";
            listaUsuariosNombre[5] = "jorge";
            listaUsuariosClave[0] = "1234";
            listaUsuariosClave[1] = "4321";
            listaUsuariosClave[2] = "4444";
            listaUsuariosClave[3] = "1111";
            listaUsuariosClave[4] = "2222";
            listaUsuariosClave[5] = "3333";
        }

        private bool validarLogin(string usuario, string clave)
        {
            int i = 0;
            while (i < listaUsuariosNombre.Length && listaUsuariosNombre[i] != usuario.ToLower())
            {
                i++;
            }
            if ((i < listaUsuariosNombre.Length && listaUsuariosClave[i] == clave))
            {
                return true;
            }
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarUsuarios();
            Boolean validacion = validarLogin(textBox1.Text, textBox2.Text);
            if (validacion)
            {

                textBox1.Clear();
                textBox2.Clear();
                Form2 menu = new Form2();
                menu.ShowDialog();
                return;

            }
            else
            {
                contador++;
                if (contador < 3)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                    MessageBox.Show("Usuario o clave incorrecta");
                }
                else
                {
                    MessageBox.Show("Ha superado el limite de intentos");
                    Application.Exit();
                }
            }

        }
        private void boxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has pulsado Cancelar");
        }

        private void FrmProyectos_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    }

