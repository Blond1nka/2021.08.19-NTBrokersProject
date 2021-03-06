using NTBrokersProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace NTBrokersProject.Services
{
    public class BrokerDBService
    {
        private readonly SqlConnection _connection;
      

        public BrokerDBService(SqlConnection connection)
        {
            _connection = connection;
        }

        public void AddBroker(BrokerModel broker)
        {
            _connection.Open();

            using var command = new SqlCommand($"INSERT INTO dbo.Brokers (Name, Surname) VALUES ('{broker.Name}', '{broker.Surname}');", _connection);
            command.ExecuteNonQuery();
            
            _connection.Close();
        }


        public List<BrokerModel> GetAll()
        {
            List<BrokerModel> items = new();

            _connection.Open();

            using var command = new SqlCommand("SELECT ID, Name, Surname FROM dbo.Brokers;", _connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                items.Add(
                new BrokerModel
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Surname = reader.GetString(2),
                });
            }

            _connection.Close();

            return items;
        }

    }
}
