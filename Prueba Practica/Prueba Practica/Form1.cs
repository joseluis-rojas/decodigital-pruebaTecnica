using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Practica
{
   
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        static string InvertirTexto(string texto)
        {
            char[] caracteres = texto.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }

        static void EvaluarParidad(int numero)
        {
            if (numero % 2 == 0)
            {
                MessageBox.Show("El número " + numero + " es par");
            }
            else
            {
                MessageBox.Show("El número " + numero + " es impar");
            }
        }
        private void btnInvertir_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text;
            string textoInvertido = InvertirTexto(texto);
            txtTextoInvertido.Text = textoInvertido;
        }
        public void GenerarTabla(int numero)
        {
            txtResultado.Clear();

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                txtResultado.AppendText(numero + "x" + i + " = " + resultado + Environment.NewLine);
            }
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            int numero = 0;
            if (int.TryParse(txtNumero.Text, out numero))
            {
                EvaluarParidad(numero);
            }
            else
            {
                MessageBox.Show("Ingrese un número válido");
            }
        }

      
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            string colorSeleccionado = cmbColores.SelectedItem as string;

            if (colorSeleccionado != null)
            {
                switch (colorSeleccionado)
                {
                    case "Amarillo":
                        GenerarTabla(2);
                        break;
                    case "Morado":
                        GenerarTabla(7);
                        break;
                    case "Rosa":
                        GenerarTabla(9);
                        break;
                    case "Azul":
                        GenerarTabla(6);
                        break;
                    case "Blanco":
                        GenerarTabla(12);
                        break;
                }
            }
        }

        private void btnIf_Click(object sender, EventArgs e)
        {
            string colorSeleccionado = cmbColores.SelectedItem as string;

            if (colorSeleccionado != null)
            {
                if (colorSeleccionado == "Amarillo")
                {
                    GenerarTabla(2);
                }
                else if (colorSeleccionado == "Morado")
                {
                    GenerarTabla(7);
                }
                else if (colorSeleccionado == "Rosa")
                {
                    GenerarTabla(9);
                }
                else if (colorSeleccionado == "Azul")
                {
                    GenerarTabla(6);
                }
                else if (colorSeleccionado == "Blanco")
                {
                    GenerarTabla(12);
                }
            }
        }
    }
}
