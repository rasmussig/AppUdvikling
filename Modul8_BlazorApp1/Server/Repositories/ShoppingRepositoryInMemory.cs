using Modul8_BlazorApp1.Shared;

namespace Modul8_BlazorApp1.Server.Repositories
{
        public class ShoppingRepositoryInMemory : IShoppingRepository
        {
            private List<ShoppingItem> mProducts = new() {
                  new ShoppingItem { Name = "bananer", Price = 12, Done = true },
                  new ShoppingItem { Name = "Æbler", Price = 14, Done = false  }
        };

            public void AddItem(ShoppingItem item)
            {
                mProducts.Add(item);
            }

            public ShoppingItem[] GetAll() => mProducts.ToArray();

        public void DeleteById(int id)
        {
            mProducts.RemoveAll((item) => item.Id == id);
        }


    }
    }
