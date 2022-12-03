using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using anagrama.DTO;
using MySql.Data.MySqlClient;

namespace anagrama.DAO
{
    internal class PlayerDAO
    {
        public static void playerInsert(PlayerDTO usuario)
        {
            var conexao = ConnectionFactory.Build();
            string query = $"INSERT INTO player(nome, tempo) VALUES ('{usuario.Nome}',{0})";

            MySqlCommand command = new MySqlCommand(query, conexao);

            conexao.Open();
            command.ExecuteReader();
            conexao.Close();
        }
        public static void playerUpdate(PlayerDTO player, int currentTempo)
        {
            var conexao = ConnectionFactory.Build();
            string query = $"UPDATE player SET tempo = {player.Tempo + currentTempo} WHERE ID = {player.ID}";

            MySqlCommand command = new MySqlCommand(query, conexao);

            conexao.Open();
            command.ExecuteReader();
            conexao.Close();
        }

        public static PlayerDTO currentPlayerCatcher()
        {
            var conexao = ConnectionFactory.Build();
            string query = "SELECT * FROM player ORDER BY ID DESC LIMIT 1";

            MySqlCommand command = new MySqlCommand(query, conexao);
            conexao.Open();

            MySqlDataReader reader = command.ExecuteReader();
            PlayerDTO player = new PlayerDTO();

            reader.Read();

            player.ID = reader.GetInt16(0);
            player.Nome = reader.GetString(1);
            player.Tempo = reader.GetInt16(2);

            conexao.Close();

            return player;
        }

        public List<PlayerDTO> playerRanking()
        {
            var conexao = ConnectionFactory.Build();
            conexao.Open();

            var query = "SELECT*FROM player ORDER BY tempo DESC LIMIT 5";

            var comando = new MySqlCommand(query, conexao);

            var dataReader = comando.ExecuteReader();

            var players = new List<PlayerDTO>();

            while (dataReader.Read())
            {
                var player = new PlayerDTO();
                player.ID = int.Parse(dataReader["ID"].ToString());
                player.Nome = dataReader["nome"].ToString();
                player.Tempo = int.Parse(dataReader["tempo"].ToString());

                players.Add(player);
            }
            conexao.Close();

            return players;
        }
    }
}
