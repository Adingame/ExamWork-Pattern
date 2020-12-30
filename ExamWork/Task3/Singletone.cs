using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

namespace ExamWork.Task3
{
    public class PersonData
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string AccessToModules { get; set; }
    }

    public class DatabaseConnectSingleton
    {
        static DatabaseConnectSingleton Instance;

        public List<PersonData> personDatas = new List<PersonData>();

        public static OracleConnection ConnectionToOracle;

        public static string connectionString = "DATA SOURCE=localhost:1521/xe;PASSWORD=ВАШ_ПАРОЛЬ;PERSIST SECURITY INFO=True;USER ID=ВАШ_ЛОГИН";
        
        private DatabaseConnectSingleton() { }
        
        public static DatabaseConnectSingleton CreateOrGetInstance()
        {
            if (Instance == null)
            {
                Instance = new DatabaseConnectSingleton();

                ConnectionToOracle = new OracleConnection(connectionString);

                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        
        public static void OpenConnection()
        {
            ConnectionToOracle.Open();
        }

        public static void CloseConnection()
        {
            ConnectionToOracle.Close();
        }
    }
}
