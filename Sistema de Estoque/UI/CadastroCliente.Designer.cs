﻿namespace Sistema_de_Estoque
{
    partial class cadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Gravar_Dados = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mTCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBPessoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mTdataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mTContato = new System.Windows.Forms.MaskedTextBox();
            this.mTdataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mTCEP = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mTRG = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mTTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mTCelular = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Cliente.:";
            // 
            // Gravar_Dados
            // 
            this.Gravar_Dados.Location = new System.Drawing.Point(12, 496);
            this.Gravar_Dados.Name = "Gravar_Dados";
            this.Gravar_Dados.Size = new System.Drawing.Size(127, 23);
            this.Gravar_Dados.TabIndex = 1;
            this.Gravar_Dados.Text = "Gravar Dados";
            this.Gravar_Dados.UseVisualStyleBackColor = true;
            this.Gravar_Dados.Click += new System.EventHandler(this.gravar_Dados);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(403, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF.:";
            // 
            // mTCPF
            // 
            this.mTCPF.Location = new System.Drawing.Point(15, 268);
            this.mTCPF.Mask = "000.000.000-00";
            this.mTCPF.Name = "mTCPF";
            this.mTCPF.Size = new System.Drawing.Size(113, 20);
            this.mTCPF.TabIndex = 4;
            this.mTCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo.:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pessoa.:";
            // 
            // cBPessoa
            // 
            this.cBPessoa.FormattingEnabled = true;
            this.cBPessoa.Items.AddRange(new object[] {
            "Física",
            "Júridica"});
            this.cBPessoa.Location = new System.Drawing.Point(101, 33);
            this.cBPessoa.Name = "cBPessoa";
            this.cBPessoa.Size = new System.Drawing.Size(107, 21);
            this.cBPessoa.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data Nascimento.:";
            // 
            // mTdataNascimento
            // 
            this.mTdataNascimento.Location = new System.Drawing.Point(230, 34);
            this.mTdataNascimento.Mask = "00/00/0000";
            this.mTdataNascimento.Name = "mTdataNascimento";
            this.mTdataNascimento.Size = new System.Drawing.Size(107, 20);
            this.mTdataNascimento.TabIndex = 10;
            this.mTdataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTdataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Cadastro.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Contato.:";
            // 
            // mTContato
            // 
            this.mTContato.Location = new System.Drawing.Point(434, 87);
            this.mTContato.Mask = "(00) 0 0000-0000";
            this.mTContato.Name = "mTContato";
            this.mTContato.Size = new System.Drawing.Size(120, 20);
            this.mTContato.TabIndex = 14;
            this.mTContato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mTdataCadastro
            // 
            this.mTdataCadastro.Location = new System.Drawing.Point(446, 34);
            this.mTdataCadastro.Mask = "00/00/0000";
            this.mTdataCadastro.Name = "mTdataCadastro";
            this.mTdataCadastro.Size = new System.Drawing.Size(107, 20);
            this.mTdataCadastro.TabIndex = 15;
            this.mTdataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTdataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "CEP.:";
            // 
            // mTCEP
            // 
            this.mTCEP.Location = new System.Drawing.Point(15, 149);
            this.mTCEP.Mask = "00000-9999";
            this.mTCEP.Name = "mTCEP";
            this.mTCEP.Size = new System.Drawing.Size(113, 20);
            this.mTCEP.TabIndex = 17;
            this.mTCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Endereço.:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(149, 149);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(403, 20);
            this.txtEndereco.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Bairro.:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(15, 215);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(113, 20);
            this.txtBairro.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cidade.:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(149, 215);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(188, 20);
            this.txtCidade.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(362, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Estado.:";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Acre ",
            "Alagoas ",
            "Amapá ",
            "Amazonas ",
            "Bahia ",
            "Ceará ",
            "Distrito Federal ",
            "Espírito Santo ",
            "Goiás ",
            "Maranhão ",
            "Mato Grosso ",
            "Mato Grosso do Sul ",
            "Minas Gerais ",
            "Pará ",
            "Paraíba ",
            "Paraná ",
            "Pernambuco ",
            "Piauí ",
            "Rio de Janeiro ",
            "Rio Grande do Norte ",
            "Rio Grande do Sul ",
            "Rondônia ",
            "Roraima ",
            "Santa Catarina ",
            "São Paulo",
            "Sergipe ",
            "Tocantins "});
            this.cbEstado.Location = new System.Drawing.Point(365, 215);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(107, 21);
            this.cbEstado.TabIndex = 25;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(146, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "RG.:";
            // 
            // mTRG
            // 
            this.mTRG.Location = new System.Drawing.Point(149, 268);
            this.mTRG.Mask = "00.000.000-00";
            this.mTRG.Name = "mTRG";
            this.mTRG.Size = new System.Drawing.Size(188, 20);
            this.mTRG.TabIndex = 27;
            this.mTRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(362, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "CNPJ.:";
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(364, 268);
            this.maskedTextBox6.Mask = "00.000.000/0000-00";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(188, 20);
            this.maskedTextBox6.TabIndex = 29;
            this.maskedTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Telefone.:";
            // 
            // mTTelefone
            // 
            this.mTTelefone.Location = new System.Drawing.Point(15, 335);
            this.mTTelefone.Mask = "(00) 0 0000-0000";
            this.mTTelefone.Name = "mTTelefone";
            this.mTTelefone.Size = new System.Drawing.Size(131, 20);
            this.mTTelefone.TabIndex = 31;
            this.mTTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(165, 319);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Celular.:";
            // 
            // mTCelular
            // 
            this.mTCelular.Location = new System.Drawing.Point(168, 335);
            this.mTCelular.Mask = "(00) 0 0000-0000";
            this.mTCelular.Name = "mTCelular";
            this.mTCelular.Size = new System.Drawing.Size(131, 20);
            this.mTCelular.TabIndex = 33;
            this.mTCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(326, 319);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Email.:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(329, 335);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 20);
            this.txtEmail.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 376);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Observação.:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Histórico Cliente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "Imprimir Dados";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(425, 496);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 23);
            this.button4.TabIndex = 40;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(12, 392);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(540, 98);
            this.txtObservacao.TabIndex = 41;
            // 
            // cadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 524);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.mTCelular);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.mTTelefone);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.mTRG);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mTCEP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mTdataCadastro);
            this.Controls.Add(this.mTContato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mTdataNascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBPessoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mTCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Gravar_Dados);
            this.Controls.Add(this.label1);
            this.Name = "cadastroCliente";
            this.Text = "Cliente - Novo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Gravar_Dados;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mTCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBPessoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mTdataNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mTContato;
        private System.Windows.Forms.MaskedTextBox mTdataCadastro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mTCEP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mTRG;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox mTTelefone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox mTCelular;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtObservacao;
    }
}