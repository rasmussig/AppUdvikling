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
        private const string connectionString = @"Data Source=c:/Users/rasmu/OneDrive/Skrivebord/ShoppingItem.sqbpro";

        public ShoppingRepositorySQLite()
        {
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
                        var id = reader.GetInt32(0);
                        Console.WriteLine("Id=" + id);
                        var Name = reader.GetString(1);
                        var Price = reader.GetInt32(2);
                        var Amount = reader.GetInt32(3);
                        var Shop = reader.GetString(4);
                        var Description = reader.GetString(5);
                        var Done = reader.GetBoolean(6);

                        ShoppingItem b = new ShoppingItem { Id = id, Name = Name, Price = Price, Amount = Amount, Shop = Shop, Description = Description, Done = Done };
                        result.Add(b);
                    }
                }

            }
            return result.ToArray();
        }
        public void AddItem(ShoppingItem item)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();

                command.CommandText = @"INSERT INTO ShoppingItem (Name, Price, Amount, Shop, Description, Done) VALUES ($name, $price, $amount, $shop, $desc, $done)";
                command.Parameters.AddWithValue("$name", item.Name);
                command.Parameters.AddWithValue("$price", item.Price);
                command.Parameters.AddWithValue("$amount", item.Amount);
                command.Parameters.AddWithValue("$shop", item.Shop);
                command.Parameters.AddWithValue("$desc", item.Description);
                command.Parameters.AddWithValue("$done", item.Done);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteById(int id)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();

                command.CommandText = @"DELETE FROM ShoppingItem WHERE id = $id";
                command.Parameters.AddWithValue("$id", id);
                command.ExecuteNonQuery();
            }

        }
    }
}
