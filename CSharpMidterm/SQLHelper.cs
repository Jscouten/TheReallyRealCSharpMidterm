using System;
using System.Data.SqlClient;

namespace CSharpMidterm
{
    class SQLHelper
    {
        private static string mySqlConnectionString = Properties.Settings.Default.MySQLConnectionString;
        public static int IDOfficial = 0;
        public static string TryInput(string UsernameTesting, int PINTesting)
        {
            // var UserObjectList = new List<UserObjectClass>();
            using (SqlConnection ConnectionTest = new SqlConnection())
            {
                ConnectionTest.ConnectionString = mySqlConnectionString;
                ConnectionTest.Open();
                SqlCommand TestingCmd = new SqlCommand("SELECT * FROM PINTable WHERE Username = @0", ConnectionTest);
                TestingCmd.Parameters.AddWithValue("@0", UsernameTesting);
                SqlDataReader reader = TestingCmd.ExecuteReader();
                while (reader.Read())
                {
                    int ID = Convert.ToInt32(reader.GetSqlValue(0).ToString());
                    string UsernameOfficial = reader.GetSqlValue(1).ToString();
                    int PINOfficial = Convert.ToInt32(reader.GetSqlValue(2).ToString());
                    if (UsernameTesting == UsernameOfficial)
                    {
                        if (PINTesting == PINOfficial)
                        {
                            IDOfficial = ID;
                            return "Successful login. Welcome back " + UsernameOfficial;
                        }
                        else
                        {
                            return "PIN was not correct";
                        }
                    }
                    else
                    {
                        return "That Username is not in the system";
                    }
                }
                return "That Username is not in the system";
            }
        }

        public static UserObject UserStatsReturn(string Username, int Pin)
        {
            UserObject User = new UserObject();
            using (SqlConnection ReturnConn = new SqlConnection())
            {
                ReturnConn.ConnectionString = mySqlConnectionString;
                ReturnConn.Open();
                SqlCommand ReturnCmd = new SqlCommand("SELECT * FROM PINTable WHERE PIN = @0", ReturnConn);
                ReturnCmd.Parameters.AddWithValue("@0", Pin);

                SqlDataReader reader = ReturnCmd.ExecuteReader();
                while (reader.Read())
                {
                    User.IDObject = IDOfficial;
                    User.UsernameObject = Username;
                    User.PINObject = Pin;
                    User.CheckingObject = Convert.ToDecimal(reader.GetSqlValue(3).ToString());
                    User.SavingObject = Convert.ToInt32(reader.GetSqlValue(4).ToString());
                }
            }
            return User;
        }

        public static string SaveChanges(int ID, string Username, int PIN, decimal Checking, decimal Saving)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = mySqlConnectionString;
                conn.Open();
                SqlCommand delcommand = new SqlCommand("DELETE FROM PINTable WHERE PIN = @0", conn);
                delcommand.Parameters.AddWithValue("@0", PIN);
                delcommand.ExecuteNonQuery();
                // i realize now that this statement under this text made it so that i had to make a new connection but since i already made the 2nd connection im not gonna make it
                // so that it works in the first connection because thats more work than i need to do
                conn.Close();

            }
            using (SqlConnection conn2 = new SqlConnection())
            {
                conn2.ConnectionString = mySqlConnectionString;
                conn2.Open();
                SqlCommand addcommand = new SqlCommand("INSERT INTO PINTable VALUES(@Username, @PIN, @Checking, @Saving)", conn2);
                addcommand.Parameters.AddWithValue(@"Username", Username);
                addcommand.Parameters.AddWithValue(@"PIN", PIN);
                addcommand.Parameters.AddWithValue(@"Checking", Checking);
                addcommand.Parameters.AddWithValue(@"Saving", Saving);
                addcommand.ExecuteNonQuery();
                conn2.Close();
            }
            return "";
        }

    }
}
