using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";
        string excluir = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //aqui vamos pegar o valor1 e armazena o texto do TxtResultado dentro dela
            //para converter os numeros de strings para decimais é necessario conveter no Parse(CONTEUDO); 
            //CultureInfo - basicamente informações ou custumes de outro pais, e simplesmente o pragrama converte para sua lingua materna
            valor1 = decimal.Parse(TxtResultado.Text, System.Globalization.CultureInfo.InvariantCulture);

            //limpando o campo do valor1 para adicionar o valor2
            TxtResultado.Text = "";

            //informando a operação
            operacao = "SOMA";

            //informar para o usuario a operação que ele esta usando
            labelOperacao.Text = "+";

        }


        private void button6_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            excluir = "";
            TxtResultado.Text = Convert.ToString(excluir);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(TxtResultado.Text, System.Globalization.CultureInfo.InvariantCulture);

            //limpando o campo do valor1 para adicionar o valor2
            TxtResultado.Text = "";

            //informando a operação
            operacao = "SUB";

            //informar para o usuario a operação que ele esta usando
            labelOperacao.Text = "-";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //pegando o valor2
            valor2 = decimal.Parse(TxtResultado.Text, System.Globalization.CultureInfo.InvariantCulture);

            //verificando a operação matematica
            if (operacao == "SOMA")
            {
                /*Colocando a soma de valor1 e valor2 no campo de texto da calculadora,
                 lambrando que a calculadora esta uma string, por isso estamos convertendo
                para string o que tinhamos convertido em decimal*/
                TxtResultado.Text = Convert.ToString(valor1 + valor2);

            }
            if (operacao == "SUB")
            {

                TxtResultado.Text = Convert.ToString(valor1 - valor2);


            }
            if (operacao == "MULTI")
            {

                TxtResultado.Text = Convert.ToString(valor1 * valor2);

            }
            if (operacao == "DIVI")
            {

                TxtResultado.Text = Convert.ToString(valor1 / valor2);

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(TxtResultado.Text, System.Globalization.CultureInfo.InvariantCulture);

            //limpando o campo do valor1 para adicionar o valor2
            TxtResultado.Text = "";

            //informando a operação
            operacao = "MULTI";

            //informar para o usuario a operação que ele esta usando
            labelOperacao.Text = "X";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(TxtResultado.Text, System.Globalization.CultureInfo.InvariantCulture);

            //limpando o campo do valor1 para adicionar o valor2
            TxtResultado.Text = "";

            //informando a operação
            operacao = "DIVI";

            //informar para o usuario a operação que ele esta usando
            labelOperacao.Text = "/";
        }
    }
}
