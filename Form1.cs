using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
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

        private void btnCalcular_Click(object sender, EventArgs e)
        // Validação dos campos:
        {
            if (txtBoxPeso.Text == "")
            {
                MessageBox.Show("Preencha o campo Peso! Não Pode Esta vazio",
       "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAltura.Text == "")
            {
                MessageBox.Show("Preencha o campo Altura!",
               "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double peso = double.Parse(txtBoxPeso.Text);
                double altura = double.Parse(txtAltura.Text);

                if   (altura <= 0)
                {
                    MessageBox.Show("Altura inválida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                    


                }
                else
                
                { // Cálculo do IMC
                    double imc = peso / (altura * altura);

                 // Classificação do IMC
                  string classificacao = "";

                  if (imc < 18.5)
                        classificacao = "Abaixo do peso";
                 else if (imc < 24.9)

                        classificacao = "Peso normal";
                  else if (imc < 29.9)
                        classificacao = "Sobrepeso";
                  else if (imc < 34.9)
                        classificacao = "Obesidade Grau I";
                  else if (imc < 39.9)
                        classificacao = "Obesidade Grau II";
                  else
                     classificacao = "Obesidade Grau III (mórbida)";

                lblCondicao.Text = $"{imc} - {classificacao}";

                }
            }


        }




        

        private void txtBoxPeso_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            
        } 
    }
}
