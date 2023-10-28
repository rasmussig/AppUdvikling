using Modul8_BlazorApp1.Shared;

namespace Modul8_BlazorApp1.Server.Repositories
{
    public interface IShoppingRepository
    {
        ShoppingItem[] GetAll();
        void AddItem(ShoppingItem item);
        void DeleteById(int id);

    }
}
