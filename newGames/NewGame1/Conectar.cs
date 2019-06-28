using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient; //namespace MySQL
using System.Data; //nasmespace dos dados

namespace NewGame
{
    class Conectar
    {
        private MySqlConnection cn;
        public MySqlCommand cmd; // é público porque só não vai ser udado aqui, vai ser udado lá no outro form frmUsuarios
        private MySqlDataAdapter adp;


        //método para gerar conexão, é um método construtor
        //também é público pelo mesmo motivo do outro

        public Conectar()
        {
            // não precisa dizer que o 
            //cn é um objeto de conexão novamente
            cn = new MySqlConnection("server=localhost; database=newgames; user id=root; password=sql123;");

            //abrindo a conexão
            cn.Open();
        }

        //string do sql
        public void Comando(string StrComando)// essa string passa a informação, e entende o que está dentro do código
        {
            cmd = new MySqlCommand(StrComando, cn);
        }

        //executar a conexao
        public void Executar()
        {
            cmd.BeginExecuteNonQuery();// ele executa o comando que foi definido pelo sql

        }
    }
}
