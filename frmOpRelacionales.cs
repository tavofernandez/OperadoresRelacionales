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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnmayor_Click(object sender, EventArgs e)
        {
            Mayorque();
        }

        private void Mayorque()
        {
            Asignacion();

            if (numero1 > numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            //se mostrara en la pantalla mediante un label
            lblresultado.Text = resultado.ToString();
        }

        private void btnmenor_Click(object sender, EventArgs e)
        {
            Menorque();
        }

        private void Menorque()
        {
            Asignacion();

            if (numero1 < numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblresultado.Text = resultado.ToString();
        }

        private void btnmenorigual_Click(object sender, EventArgs e)
        {
            Menorigual();
        }

        private void Menorigual()
        {
            Asignacion();

            if (numero1 <= numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblresultado.Text = resultado.ToString();
        }

        private void btnmayorigual_Click(object sender, EventArgs e)
        {

        }

        private void Mayorigual()
        {
            Asignacion();

            if (numero1 >= numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblresultado.Text = resultado.ToString();
        }

        private void frmOpRelacionales_Load(object sender, EventArgs e)
        {

        }
    }
}
