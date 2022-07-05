namespace MathQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.labelTmepoRestante = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.soma = new System.Windows.Forms.NumericUpDown();
            this.menosLeftLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.diferenca = new System.Windows.Forms.NumericUpDown();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelRespostaSoma = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.produto = new System.Windows.Forms.NumericUpDown();
            this.quociente = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCorAdicao = new System.Windows.Forms.Label();
            this.labelCorMultiplicacao = new System.Windows.Forms.Label();
            this.labelCorSubtracao = new System.Windows.Forms.Label();
            this.labelCorDivisao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.soma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diferenca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quociente)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(272, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // labelTmepoRestante
            // 
            this.labelTmepoRestante.AutoSize = true;
            this.labelTmepoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTmepoRestante.Location = new System.Drawing.Point(165, 9);
            this.labelTmepoRestante.Name = "labelTmepoRestante";
            this.labelTmepoRestante.Size = new System.Drawing.Size(101, 25);
            this.labelTmepoRestante.TabIndex = 1;
            this.labelTmepoRestante.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(18, 59);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(160, 59);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 3;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // soma
            // 
            this.soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soma.Location = new System.Drawing.Point(316, 68);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(100, 35);
            this.soma.TabIndex = 1;
            this.soma.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // menosLeftLabel
            // 
            this.menosLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menosLeftLabel.Location = new System.Drawing.Point(18, 123);
            this.menosLeftLabel.Name = "menosLeftLabel";
            this.menosLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.menosLeftLabel.TabIndex = 8;
            this.menosLeftLabel.Text = "?";
            this.menosLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 9;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(160, 123);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 10;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 11;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diferenca
            // 
            this.diferenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diferenca.Location = new System.Drawing.Point(316, 132);
            this.diferenca.Name = "diferenca";
            this.diferenca.Size = new System.Drawing.Size(100, 35);
            this.diferenca.TabIndex = 2;
            this.diferenca.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.Location = new System.Drawing.Point(18, 187);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 13;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(18, 251);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel.TabIndex = 14;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 15;
            this.label7.Text = "x";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRespostaSoma
            // 
            this.labelRespostaSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRespostaSoma.Location = new System.Drawing.Point(84, 251);
            this.labelRespostaSoma.Name = "labelRespostaSoma";
            this.labelRespostaSoma.Size = new System.Drawing.Size(60, 50);
            this.labelRespostaSoma.TabIndex = 16;
            this.labelRespostaSoma.Text = "÷";
            this.labelRespostaSoma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.Location = new System.Drawing.Point(160, 187);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 17;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightLabel.Location = new System.Drawing.Point(160, 251);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLabel.TabIndex = 18;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(235, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 19;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(235, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 20;
            this.label12.Text = "=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // produto
            // 
            this.produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produto.Location = new System.Drawing.Point(316, 196);
            this.produto.Name = "produto";
            this.produto.Size = new System.Drawing.Size(100, 35);
            this.produto.TabIndex = 3;
            this.produto.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // quociente
            // 
            this.quociente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quociente.Location = new System.Drawing.Point(316, 260);
            this.quociente.Name = "quociente";
            this.quociente.Size = new System.Drawing.Size(100, 35);
            this.quociente.TabIndex = 4;
            this.quociente.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(170, 315);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(129, 34);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "iniciar o teste";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelCorAdicao
            // 
            this.labelCorAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorAdicao.Location = new System.Drawing.Point(422, 59);
            this.labelCorAdicao.Name = "labelCorAdicao";
            this.labelCorAdicao.Size = new System.Drawing.Size(60, 50);
            this.labelCorAdicao.TabIndex = 21;
            this.labelCorAdicao.Text = "X";
            this.labelCorAdicao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCorMultiplicacao
            // 
            this.labelCorMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorMultiplicacao.Location = new System.Drawing.Point(422, 187);
            this.labelCorMultiplicacao.Name = "labelCorMultiplicacao";
            this.labelCorMultiplicacao.Size = new System.Drawing.Size(60, 50);
            this.labelCorMultiplicacao.TabIndex = 22;
            this.labelCorMultiplicacao.Text = "X";
            this.labelCorMultiplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCorSubtracao
            // 
            this.labelCorSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorSubtracao.Location = new System.Drawing.Point(422, 123);
            this.labelCorSubtracao.Name = "labelCorSubtracao";
            this.labelCorSubtracao.Size = new System.Drawing.Size(60, 50);
            this.labelCorSubtracao.TabIndex = 23;
            this.labelCorSubtracao.Text = "X";
            this.labelCorSubtracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCorDivisao
            // 
            this.labelCorDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorDivisao.Location = new System.Drawing.Point(422, 251);
            this.labelCorDivisao.Name = "labelCorDivisao";
            this.labelCorDivisao.Size = new System.Drawing.Size(60, 50);
            this.labelCorDivisao.TabIndex = 24;
            this.labelCorDivisao.Text = "X";
            this.labelCorDivisao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.labelCorDivisao);
            this.Controls.Add(this.labelCorSubtracao);
            this.Controls.Add(this.labelCorMultiplicacao);
            this.Controls.Add(this.labelCorAdicao);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quociente);
            this.Controls.Add(this.produto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.labelRespostaSoma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.diferenca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menosLeftLabel);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.labelTmepoRestante);
            this.Controls.Add(this.timeLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Teste de Matemática do Dani";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diferenca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quociente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label labelTmepoRestante;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown soma;
        private System.Windows.Forms.Label menosLeftLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown diferenca;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelRespostaSoma;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown produto;
        private System.Windows.Forms.NumericUpDown quociente;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelCorAdicao;
        private System.Windows.Forms.Label labelCorMultiplicacao;
        private System.Windows.Forms.Label labelCorSubtracao;
        private System.Windows.Forms.Label labelCorDivisao;
    }
}

