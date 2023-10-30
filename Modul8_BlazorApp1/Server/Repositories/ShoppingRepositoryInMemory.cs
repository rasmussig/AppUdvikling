using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Modul8_BlazorApp1.Shared;
namespace Modul8_BlazorApp1.Server.Repositories
{
    public class ShoppingRepositoryInMemory : IShoppingRepository
    {
        private List<ShoppingItem> mProducts = new() {
                  new ShoppingItem { Id = 3, Name = "Tærte", Price = 39, Amount = 1, Description = "Den smager godt", Shop = "Bilka"  },
                  new ShoppingItem { Id = 4, Name = "Æbler", Price = 14, Amount = 1, Description = "De er grønne", Shop = "Bilka"  }
        };

        public void AddItem(ShoppingItem item)
        {
            int newId = mProducts.Select(x => x.Id).Max() + 1;
            item.Id = newId;
            mProducts.Add(item);
        }

        public ShoppingItem[] GetAll() => mProducts.ToArray();


        public void DeleteById(int id)
        {
            mProducts.RemoveAll((item) => item.Id == id);
        }

        public void UpdateItem(ShoppingItem item)
        {
            DeleteById(item.Id);
            mProducts.Add(item);
        }
    }
}
