using System;
using System.Xml.Linq;
using Modul8_BlazorApp1.Shared;
using Microsoft.Data.Sqlite;
using Modul8_BlazorApp1.Client.Pages;
using Modul8_BlazorApp1.Server.Repositories;

namespace Modul8_BlazorApp1.Server.Repositories
{
    public class ShoppingRepositorySQLite : IShoppingRepository
    {
        private const string connectionString = @"Data Source=c:\Users\rasmu\OneDrive\Skrivebord\ShoppingItem.db";

        public ShoppingRepositorySQLite()
        {
        }
        public void AddItem(ShoppingItem item)
        {

        }
        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public ShoppingItem[] GetAll()
        {
            var result = new List<ShoppingItem>();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM ShoppingItem";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Id = reader.GetInt32(0);
                        var Name = reader.GetString(1);
                        var Price = reader.GetInt32(2);
                        var Amount = reader.GetInt32(3);
                        var Shop = reader.GetString(4);
                        var Description = reader.GetString(5);

                        ShoppingItem b = new ShoppingItem { Id = Id, Name = Name, Price = Price, Amount = Amount, Shop = Shop, Description = Description };
                        result.Add(b);
                    }
                }

            }
            return result.ToArray();
        }
        public void UpdateItem(ShoppingItem item)
        {
            throw new NotImplementedException();
        }
    }
}
