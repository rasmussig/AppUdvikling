using Microsoft.AspNetCore.Mvc;
using Modul8_BlazorApp1.Server.Repositories;
using Modul8_BlazorApp1.Shared;

namespace Modul8_BlazorApp1.Server.Controllers
{
    [ApiController]
    [Route("api/Shopping")]
    public class ShoppingController : ControllerBase
    {
        private IShoppingRepository mRepo;

        public ShoppingController(IShoppingRepository repo)
        {
           this.mRepo = repo;
        }

        [HttpGet]
        public IEnumerable<ShoppingItem> GetAll()
        {
            return mRepo.GetAll();
        }

        [HttpPost]
        public void AddItem(ShoppingItem item)
        {
            mRepo.AddItem(item);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public void DeleteItem(int id)
        {
            mRepo.DeleteById(id);

        }
    }
}
    
