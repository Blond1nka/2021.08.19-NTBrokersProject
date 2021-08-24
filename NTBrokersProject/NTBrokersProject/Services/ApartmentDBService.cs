using NTBrokersProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTBrokersProject.Services
{
    public class ApartmentDBService
    {
        private readonly SqlConnection _connection;

        public ApartmentDBService(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<ApartmentModel> GetData()
        {
            List<ApartmentModel> items = new();

            _connection.Open();

            using var command = new SqlCommand($@"SELECT dbo.Apartments.*, CONCAT(dbo.Apartments.Street, ' ', dbo.Apartments.Address), dbo.Company.Name
                                                  FROM dbo.Apartments
                                                  JOIN dbo.Companies
                                                  ON dbo.Apartments.CompanyId = dbo.Company.Id", _connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                items.Add(new()
                {
                    Id = reader.GetInt32(0),
                    City = reader.GetString(1),
                    Street = reader.GetString(2),
                    Address = reader.GetInt32(3),
                    FlatFloor = reader.GetInt32(4),
                    BuildingFloors = reader.GetInt32(5),
                    Area = reader.GetInt32(6),
                    CompanyId = reader.GetInt32(7),
                    BrokerId = reader.GetInt32(8)
                });
            }

            _connection.Close();

            return items;
        }


        public void Create(ApartmentModel model)
        {
            _connection.Open();
            using var command = new SqlCommand($@"INSERT INTO dbo.Apartments (City, Street, Address, FlatFloor, 
                                                                              BuildingFloors, Area, CompanyId, BrokerId)
                                                  VALUES ('{model.City}', '{model.Street}', '{model.Address}', {model.FlatFloor}', 
                                                          '{model.BuildingFloors}', '{model.Area}', {model.CompanyId}');", _connection);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
