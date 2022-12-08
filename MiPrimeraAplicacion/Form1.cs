using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicacion
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("BIENVENIDOS A C#");
        }

        private void Formulario_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
            {
                MessageBox.Show("se apreto el boton izquierdo");
            }
            else if (click.Button == MouseButtons.Right)
            {
                MessageBox.Show("se apreto el boton derecho");
            }
            else if (click.Button == MouseButtons.Middle)
            {
                MessageBox.Show("se apreto el boton del medio");
            }
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("chau chau..");
        }

        private void boton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se activo el evento click");
            //this.BackColor = Color.Beige;
            if(caja.Text == "")
            {
                caja.BackColor = Color.Red;
            }
            else
            {
                caja.BackColor = System.Drawing.SystemColors.Control;
            }

        }

        private void Comentario_MouseMove(object sender, EventArgs e)
        {

        }

        private void Comentario_MouseMove(object sender, MouseEventArgs e)
        {
            Comentario.BackColor= Color.Blue;
            Comentario.Cursor = Cursors.Hand;
        }

        private void Comentario_MouseLeave(object sender, EventArgs e)
        {
            Comentario.BackColor = System.Drawing.SystemColors.ControlDark;
            Comentario.Cursor = Cursors.Arrow;
        }

        private void caja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void caja2_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + caja2.Text.Length + " Caracteres");
        }
    }
}
