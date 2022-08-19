using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace Database
{
    public class ConexaoBanco
    {
        SqlConnection Conn = new SqlConnection();

        //Construtor
        public ConexaoBanco()
        {
            Conn.ConnectionString = @"Data Source=DESKTOP-8QNPI58\SQLEXPRESS;Initial Catalog=SistemadeCadastro;Integrated Security=True";
            
        }
        //Metodo Conectar 
        public SqlConnection Conectar()
        {
            if (Conn.State == System.Data.ConnectionState.Closed)
            {
                Conn.Open();
            }
            return Conn;
        }

        //Metodo Desconectar
        public void Desconectar()
        {
            if (Conn.State == System.Data.ConnectionState.Open)
            {
                Conn.Close();
            }

        }
    }
}