using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroPrimo100
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            string resultado = "";
            int contador = 0;
            double numero = 2;
            while(contador < 100)
            {
                if (checkPrimo(numero) == true)
                {
                    resultado = resultado + ", " + numero;
                    contador++;
                }
                numero++;
            }
            MessageBox.Show("Resultado: " + resultado);



        }

        private Boolean checkPrimo(double numero)
        {
            Boolean isPrimo = true;
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    isPrimo = false;
                }
            }

            return isPrimo;
        }




    }
}
