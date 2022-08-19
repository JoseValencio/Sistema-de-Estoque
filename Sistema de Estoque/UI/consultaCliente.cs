using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using Database;
using Business;
namespace Sistema_de_Estoque
{
    public partial class ConsultaCliente : Form
    {
       
       

        

        public string message;
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastroCliente cadastro = new cadastroCliente();
            cadastro.Show();
            cadastro.Visible = true;


        }

        public void Consultar_Click(object sender, EventArgs e)
        {
            ;
            ConexaoBanco conexao = new ConexaoBanco();
            SqlCommand cmd = new SqlCommand();
           // SqlCommand cmdc = new SqlCommand();
            SqlConnection Conn = new SqlConnection();

            Conn.ConnectionString = @"Data Source=DESKTOP-8QNPI58\SQLEXPRESS;Initial Catalog=SistemadeCadastro;Integrated Security=True";
           
           cmd = new SqlCommand("SELECT Email, Contato, Celular Telefone FROM CONTATO", Conn);
         //  cmd = new SqlCommand("SELECT Nome FROM cadastroPessoa WHERE NOME LIKE @nome", Conn);

            cmd.Parameters.AddWithValue("@nome", "%" + txtConsulta.Text + "%" );
            
            SqlDataAdapter consulta = new SqlDataAdapter(cmd);
           // SqlDataAdapter consultaNome = new SqlDataAdapter(cmdc);
            DataSet tabela = new DataSet();
            consulta.Fill(tabela);
           // consultaNome.Fill(tabela);
            dgConsulta.DataSource = tabela.Tables[0];


            //Conexão com o Banco

            try
            {
                 cmd.Connection = conexao.Conectar();

                //executar comando de insert
                cmd.ExecuteNonQuery();
                // desconecta do banco 
                conexao.Desconectar();

                // mensgem de sucesso.

                this.message = "Cadastro realizado!";

            }
            catch (SqlException erro)
            {
                this.message = "Erro ao conectar com o banco" + erro;
            }

        }
    }
}
