using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperadoresRelacionales
{
    public partial class frmOpRelacionales : Form
    {
        public frmOpRelacionales()
        {
            InitializeComponent();
        }

        //Declaramos las variables y sus tipos de datos
        int numero1, numero2;
        bool resultado;

        private void Asignacion()
        {
            numero1 = Convert.ToInt32(txtnumero1.Text);
            numero2 = Convert.ToInt32(txtnumero2.Text);
        }

        private void frmOpRelacionales_Load(object sender, EventArgs e)
        {

        }
    }
}
