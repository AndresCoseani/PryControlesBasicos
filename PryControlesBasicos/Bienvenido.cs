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
    public partial class Bienvenido : Form
    {
        Secundario sec=new Secundario();
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
             sec.Show();
            this. Hide();
        }
    }
}
