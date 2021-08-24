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

        //internal List<ApartmentAdditionalModel> Read()
        //{
        //    List<ApartmentAdditionalModel> items = new();

        //    _connection.Open();

        //    //many to many left joins
        //    using var command = new SqlCommand("SELECT dbo.House.ID, dbo.House.City, dbo.House.Street, dbo.House.Address, " +
        //                                       "dbo.House.FlatFloor, dbo.House.BuildingFloors, dbo.House.Area, dbo.House.BrokerId, " +
        //                                       "dbo.House.CompanyId, dbo.Company.Name, dbo.Broker.Name, dbo.Broker.Surname " +
        //                                        "FROM dbo.House " +
        //                                       //"LEFT OUTER JOIN dbo.CompanyBroker " +
        //                                       // "ON dbo.House.BrokerId = dbo.CompanyBroker.BrokerId " +
        //                                       // "LEFT OUTER JOIN dbo.Broker " +
        //                                       //  "ON dbo.CompanyBroker.BrokerId = dbo.Broker.ID " +
        //                                       //"LEFT OUTER JOIN dbo.Company " +
        //                                       // "ON dbo.CompanyBroker.CompanyId = dbo.Company.ID;", _connection);
        //                                       "LEFT OUTER JOIN dbo.Company " +
        //                                        "ON dbo.House.CompanyId = dbo.Company.ID " +
        //                                       "LEFT OUTER JOIN dbo.Broker " +
        //                                        "ON dbo.Broker.ID = dbo.House.BrokerId;", _connection);

        //    using var reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        items.Add(new()
        //        {
        //            //Id = reader.GetInt32(0),
        //            //City = reader.GetString(1),
        //            //Street = reader.GetString(2),
        //            //Address = reader.GetInt32(3),
        //            //FlatFloor = reader.GetInt32(4),
        //            //BuildingFloors = reader.GetInt32(5),
        //            //Area = reader.GetInt32(6),
        //            //BrokerId = reader.GetInt32(7),
        //            //CompanyId = reader.GetInt32(8),
        //            Apartment = reader.GetString(2) + " " + reader.GetInt32(3),
        //            Company = reader.GetString(9),
        //            Broker = reader.GetString(10) + " " + reader.GetString(11),

        //        });
        //    }

        //    _connection.Close();

        //    return items;
        //}


        //public void Create(RealEstateDBService model)
        //{
        //    _connection.Open();
        //    using var command = new SqlCommand($"INSERT INTO dbo.Apartments (City, Street, Address, FlatFloor, " +
        //                                       $"BuildingFloors, BrokerId, CompanyId) " +
        //                                       $"values ('{model.Apartments.City}', '{model.Apartments.Street}', '{model.Apartments.Address}'," +
        //                                       $"'{model.Apartments.FlatFloor}', '{model.Apartments.BuildingFloors}', '{model.Apartments.Area}'," +
        //                                       $"null, '{model.Apartments.CompanyId}');", _connection);
        //    command.ExecuteNonQuery();
        //    _connection.Close();
        //}
    }
}
