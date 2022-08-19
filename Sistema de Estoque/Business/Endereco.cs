using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace Business
{
    public class Endereco
    {
        ConexaoBanco conexao = new ConexaoBanco();
        SqlCommand cmdEndereco = new SqlCommand();

        public Endereco(string endereco, string numero, string bairro, string cidade, string estado)
        {
            cmdEndereco.CommandText = "Insert Into Endereco (endereco, numero, bairro, cidade, estado) VALUE (@endereco, @numero, @bairro, @cidade, @estado) ";
           
            cmdEndereco.Parameters.AddWithValue("endereco", endereco);
            cmdEndereco.Parameters.AddWithValue("numero", numero);
            cmdEndereco.Parameters.AddWithValue("bairro", bairro);
            cmdEndereco.Parameters.AddWithValue("cidade", cidade);
            cmdEndereco.Parameters.AddWithValue("estado", estado);

            try
            {
                cmdEndereco.Connection = conexao.Conectar();
                cmdEndereco.ExecuteNonQuery();
                conexao.Desconectar();

                
            }
            catch(SqlException erro)
            {
                
            }
        }
    }
}
