using Modul8_BlazorApp1.Shared;

namespace Modul8_BlazorApp1.Server.Repositories
{
    public class IShoppingRepositorySQLite : IShoppingRepository
    {
        private const string connectionString = @"Data Source=C:\Users\rasmu\OneDrive\Skrivebord\bikes.db";
        // SKAL ÆNDRES

        public IShoppingRepositorySQLite()
        {
        }

        public ShoppingItem[] GetAll()
        {
            var result = new List<ShoppingItem>();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM Bike";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        Console.WriteLine("Id=" + id);
                        var brand = reader.GetString(1);
                        var model = reader.GetString(2);
                        var desc = reader.GetString(3);
                        var price = reader.GetInt32(4);
                        var imgUrl = reader.GetString(5);

                        BEBike b = new BEBike { Id = id, Brand = brand, Model = model, Description = desc, Price = price, ImageUrl = imgUrl };
                        result.Add(b);
                    }
                }

    }
}
