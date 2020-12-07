using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUMEROS
{
    public partial class frmEmisionDeCheque : Form
    {
        public frmEmisionDeCheque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            //NUMEROS.classNumerosLetras.TestUnidades();
            int num = int.Parse(this.txtCantidad.Text);
            this.txtResultado.Text = NUMEROS.NumerosLetras.getDecenas(num);
        }
    }
}
