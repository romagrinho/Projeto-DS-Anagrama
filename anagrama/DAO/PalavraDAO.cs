using anagrama.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagrama.DAO
{
    public class PalavraDAO
    {
        public List<PalavraDTO> ListarPalavras(string dificuldade)
        {
            var conexao = ConnectionFactory.Build();
            conexao.Open();

            var query = "SELECT*FROM Palavras WHERE Dificuldade = @dificuldade";

            var comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@dificuldade", dificuldade);

            var dataReader = comando.ExecuteReader();

            var palavras = new List<PalavraDTO>();

            while (dataReader.Read())
            {
                var palavra = new PalavraDTO();
                palavra.ID = int.Parse(dataReader["ID"].ToString());
                palavra.Palavra = dataReader["Palavra"].ToString();
                palavra.Dificuldade = dataReader["Dificuldade"].ToString();

                palavras.Add(palavra);
            }
            conexao.Close();

            return palavras;
        }
    }
}
