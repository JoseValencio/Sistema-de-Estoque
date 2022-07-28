using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Estoque
{
    public partial class cadastroCliente : Form
    {
        public cadastroCliente()
        {
            InitializeComponent();
        }

        private void gravar_Dados(object sender, EventArgs e)
        {
            Pessoa cad = new Pessoa(txtNome.Text, mTCPF.Text, mTRG.Text, mTdataCadastro.Text, mTdataNascimento.Text, txtObservacao.Text);
            MessageBox.Show(cad.message);
            txtNome.Text = " ";
            mTCPF.Text = " ";
            mTRG.Text = " ";
            mTdataCadastro.Text = " ";
            mTdataNascimento.Text = " ";
            txtObservacao.Text = " ";

        }

      
    }
}
