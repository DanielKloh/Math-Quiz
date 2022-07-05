using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{

    public partial class Form1 : Form
    {
        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();

        // These integer variables store the numbers 
        // for the addition problem. 
        int addend1;
        int addend2;


        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer.
        /// </summary>
        /// 

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;

        // Essas variáveis ​​inteiras armazenam os números
        // para o problema de multiplicação.
        int multiplicand;
        int multiplier;

        // Essas variáveis ​​inteiras armazenam os números
        // para o problema de divisão.
        int dividend;
        int divisor;

        // Esta variável inteira mantém o controle do
        // tempo restante.
        int timeLeft;


        public void StartTheQuiz()
        {

            // Preencha o problema de adição.
            // Gera dois números aleatórios para adicionar.
            // Armazena os valores nas variáveis ​​'addend1' e 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Converta os dois números gerados aleatoriamente
            // em strings para que possam ser exibidos
            // nos controles de rótulo.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' é o nome do controle NumericUpDown.
            // Este passo garante que seu valor seja zero antes
            // adicionando quaisquer valores a ele.
            soma.Value = 0;

            // Preencha o problema de subtração.
            minuend = randomizer.Next(1,101);
            subtrahend = randomizer.Next(1,minuend);
            menosLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            diferenca.Value = 0;

            // Preencha o problema de multiplicação.
            multiplicand = randomizer.Next(2,11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            produto.Value = 0;

            //Preencha o problema de divisão.
            divisor = randomizer.Next(2,11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quociente.Value = 0;

            //Inicia  o cronometro.
            timeLeft = 30;
            timeLabel.Text = "30 segundos";
            timer1.Start();
            timeLabel.BackColor = Color.Green;

            
        }

        private bool CheckTheAnswer()
        {
            if (addend1 + addend2 == soma.Value)
            {
                labelCorAdicao.BackColor = Color.Green;
            }
            if (minuend - subtrahend == diferenca.Value)
            {
                labelCorSubtracao.BackColor = Color.Green;
            }
            if (multiplicand * multiplier == produto.Value)
            {
                labelCorMultiplicacao.BackColor = Color.Green;
            }
            if (dividend / divisor == quociente.Value)
            {
                labelCorDivisao.BackColor = Color.Green;
            }
            if ((addend1 + addend2 == soma.Value)
        && (minuend - subtrahend == diferenca.Value)
        && (multiplicand * multiplier == produto.Value)
        && (dividend / divisor == quociente.Value))
                return true;
            else
                return false;
        }







        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
            labelCorAdicao.Text = "X"; 
            labelCorSubtracao.Text = "X";
            labelCorMultiplicacao.Text = "X";
            labelCorDivisao.Text = "X";

            labelCorAdicao.BackColor = Color.Red;
            labelCorSubtracao.BackColor = Color.Red;
            labelCorMultiplicacao.BackColor = Color.Red;
            labelCorDivisao.BackColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(CheckTheAnswer())
    {
                // Se CheckTheAnswer() retornar true, então o usuário
                // acertou a resposta. Pare o temporizador
                // e mostra um MessageBox.
                timer1.Stop();
                MessageBox.Show("Você acertou todas as respostas!",
                                "Parabéns!");
                startButton.Enabled = true;
                labelCorAdicao.BackColor = Color.Green;
                labelCorSubtracao.BackColor = Color.Green;
                labelCorMultiplicacao.BackColor = Color.Green;
                labelCorDivisao.BackColor = Color.Green;
                timeLabel.BackColor = Color.White;
            }
    else if (timeLeft > 0)
            {
                // Se CheckTheAnswer() retornar false, continue contando
                // baixa. Diminua o tempo restante em um segundo e
                // exibe o novo tempo restante atualizando o
                // Etiqueta de tempo restante.
                timeLeft -= 1;
                timeLabel.Text = timeLeft + " segundos";
            }
            else
            {
                // Se o tempo do usuário ficou sem tempo, pare o cronômetro, mostre
                // um MessageBox e preencha as respostas e muda a cor para branco.
                timer1.Stop();
                timeLabel.Text = "Acabou o tempo!";
                MessageBox.Show("Você não acabou a tempo.", "Lamento");
                
                labelCorAdicao.Text = (addend1 + addend2).ToString();
                
                labelCorSubtracao.Text = (minuend - subtrahend).ToString();
                
                labelCorMultiplicacao.Text = (multiplicand * multiplier).ToString();
                
                labelCorDivisao.Text = (dividend / divisor).ToString();
                startButton.Enabled = true;
                timeLabel.BackColor = Color.White;

                /* exibe o resultado correto no lugar onde digita os valore:
                soma.Value = addend1 + addend2;
                diferenca.Value = minuend - subtrahend;
                produto.Value = multiplicand * multiplier;
                quociente.Value = dividend / divisor;
                */
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Selecione a resposta inteira no controle NumericUpDown.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }


