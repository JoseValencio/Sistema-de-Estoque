using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;


namespace Business
{
    public class Pessoa
    {


        //Comando Sql
        ConexaoBanco conexao = new ConexaoBanco();
        SqlCommand cmd = new SqlCommand();
        public string message;


        //Construtor da classe.
        public Pessoa(string nome, string cpf, string rg, string dataCadastro, string dataNascimento,
        string observacao)
       
        {


            cmd.CommandText = "insert into cadastroPessoa (nome, cpf, Rg, Data_Nascimento , Data_Cadastro, Observacao) values (@nome,  @cpf, @rg, @Data_Nascimento, @Data_Cadastro, @Observacao)";

            
            //parametros

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@rg",  rg);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@data_Nascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@data_cadastro", dataCadastro);
            cmd.Parameters.AddWithValue("@observacao", observacao);



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


