using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumConsecutivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txtcantidad.Text);
            int contador = 0;
            int resta = 0;

            lsbconsecutivos.Items.Clear();

            while (contador <= cantidad){

                if (contador <= cantidad){

                    lsbconsecutivos.Items.Add(contador.ToString());

                }

                
                lblmensaje.Text = " Muestra Finalizada";
                lblmensaje.Visible = true;
                contador++;
                txtcantidad.Text = "";
                txtcantidad.Focus();
            }

            
        }

       

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {

                MessageBox.Show("Solo se pueden numeros"
                    , "Mensaje de advertencia"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);

                e.Handled = true;
                return;
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            lsbconsecutivos.Items.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
