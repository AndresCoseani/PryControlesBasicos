using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryControlesBasicos
{
    public partial class Secundario : Form
    {
        public Secundario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkMayonesa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPicante_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string textoConcatenar = "";

            if (chkPicante.Checked == true)
            {
                lblResultado.Text = "Picante";
                textoConcatenar = textoConcatenar + "Picante ";
            }
            if (chkMayonesa.Checked == true)
            {
                lblResultado.Text = "Mayonesa";
                textoConcatenar = textoConcatenar + "Mayonesa ";
            }
            if (chkKetchup.Checked==true) {
                lblResultado.Text = "Ketchup";
                textoConcatenar = textoConcatenar + "Ketchup ";
            }
            lblResultado.Text = textoConcatenar;

            cboagregado.Items.Add(textoConcatenar);
        }

        private void cmdAsignar_Click(object sender, EventArgs e)
        {
            if (optAzul.Checked == true)
            {
                lblTextofinal.ForeColor = Color.Blue;
            }
            if (optRojo.Checked == true)
            {
                lblTextofinal.ForeColor= Color.Red; 
            }
            lblTextofinal.Text= txtIngresar.Text;
        }
    }
}
