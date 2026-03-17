using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio1
{
    public partial class AppEscritorio1 : Form
    {
        public AppEscritorio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.PaleTurquoise;
            if (txtNombre.Text != "")
            {
                txtNombre.BackColor = Color.MintCream;
                MessageBox.Show("Bienvenido/a " + txtNombre.Text, "Atencion");
            }
            else
                txtNombre.BackColor = Color.LightCoral;
            txtNombre.Text = "";
            btnAceptar.BackColor = Color.MintCream;
        }

        private void AppEscritorio1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void AppEscritorio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau ...");
        }

        private void AppEscritorio1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }

        private void LabelNombre_MouseMove(object sender, MouseEventArgs e)
        {
            LabelNombre.BackColor = Color.PaleTurquoise;
            LabelNombre.Cursor = Cursors.Hand;
        }

        private void LabelNombre_MouseLeave(object sender, EventArgs e)
        {
            LabelNombre.BackColor = Color.MintCream;
            LabelNombre.Cursor = Cursors.Cross;
        }

        private void btnAceptar_KeyUp(object sender, KeyEventArgs e)
        {
             
        }

        private void btnAceptar_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
