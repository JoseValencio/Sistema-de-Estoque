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
    public class Contato
    {

        ConexaoBanco conexao = new ConexaoBanco();
        SqlCommand cmdContato = new SqlCommand();
        public string message;


        public Contato(string telefone, string celular, string email, string contato)
        {
            cmdContato.CommandText = "insert into Contato (telefone, celular, email, contato) values (@telefone,  @celular, @email, @contato)";
           
            cmdContato.Parameters.AddWithValue("@telefone", telefone);
            cmdContato.Parameters.AddWithValue("@celular", celular);
            cmdContato.Parameters.AddWithValue("@email", email);
            cmdContato.Parameters.AddWithValue("@contato", contato);

            try
            {
                cmdContato.Connection = conexao.Conectar();

                //executar comando de insert
                cmdContato.ExecuteNonQuery();
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
