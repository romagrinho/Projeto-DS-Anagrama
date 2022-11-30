using MySql.Data.MySqlClient;

namespace anagrama.DAO
{
    public class ConnectionFactory
    {
        public static MySqlConnection Build()
        {
            string connectionString = "Server=localhost;Database=Anagrama;Uid=root;Pwd=root;";
            return new MySqlConnection(connectionString);
        }
    }
}
