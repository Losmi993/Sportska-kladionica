

using System.Data.SqlServerCe;

namespace KladionicaNova
{
    class DataBaseConnection
    {
        private static DataBaseConnection instance;

        private SqlCeConnection connection;

        private DataBaseConnection()
        {
            PocetnaForma LF = new PocetnaForma();
            string Dir = LF.GetHomeDirectory();
            string connectionString = "Password = 'milos123'; " + "Data Source =" + @Dir + "\\BazaKladionicaNova.sdf";


            connection = new SqlCeConnection(connectionString);
            connection.Open();
        }

        public static DataBaseConnection Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataBaseConnection();

                return instance;
            }
        }

        public SqlCeConnection Connection
        {
            get
            {
                return connection;
            }
        }
    }
}
