using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string tableName = "myTable";

            program.PrintTable(tableName);

            Console.ReadKey();
        }

        void PrintTable(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open(); Console.WriteLine("Соединение открыто...");

                string query;
                SqlCommand command;

                query = "SELECT Count(*) FROM INFORMATION_SCHEMA.Columns where TABLE_NAME = \'" + tableName + "\';";
                command = new SqlCommand(query, connection);
                int count = int.Parse(command.ExecuteScalar().ToString());







                query = "SELECT * from " + tableName + ";";
                command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // построчно считываем данные
                {
                    Console.Write("|");
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(reader.GetValue(i).ToString() + "|");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}


