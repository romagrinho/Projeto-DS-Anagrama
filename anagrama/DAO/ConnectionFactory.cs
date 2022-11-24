using MySql.Data.MySqlClient;

namespace anagrama.DAO
{
    public class ConnectionFactory
    {
        public static MySqlConnection Build()
        {
            return new MySqlConnection("Server=localhost;Database=Anagrama;Uid=root;Pwd=root");
        }
    }
}
