using MySql.Data.MySqlClient;
using System;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string server = "localhost";
                string database = "homework7";
                string login = "root";
                string pass = "root";

                Console.WriteLine("Введите команду");
                string command = Console.ReadLine();

                string sqlConnect = "Database=" + database + ";Datasource=" + server + ";user=" + login + ";Password=" + pass;
                MySqlConnection connect = new MySqlConnection(sqlConnect);
                connect.Open();


                if (command.Contains("GET ALL"))
                {
                    string sql = "select * from students";
                    MySqlCommand query = new MySqlCommand(sql, connect);
                    MySqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("Cтудент " + reader["fio"]);
                    }
                    reader.Close();
                    connect.Close();
                }
                else if (command.Contains("GET INFO"))
                {
                    command = command.Substring(9);
                    string sql = "select * from students where fio = \"" + command + "\"";
                    MySqlCommand query = new MySqlCommand(sql, connect);
                    MySqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("Cтудент № " + reader["student_id"] + " " + reader["fio"]);
                    }
                    reader.Close();
                    connect.Close();

                }
                else if (command.Contains("DELETE"))
                {
                    command = command.Substring(7);
                    string sql = "delete from students where fio = \"" + command + "\"";
                    MySqlCommand query = new MySqlCommand(sql, connect);
                    query.ExecuteScalar();
                    connect.Close();
                }
                else
                {
                    Console.WriteLine("Команда не распознана");
                }

            }
        }
    }
}
