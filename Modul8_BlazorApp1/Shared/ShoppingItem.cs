namespace Modul8_BlazorApp1.Shared
{
   public class ShoppingItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public decimal Price { get; set; } = 0;

        public int Amount { get; set; } = 1;

        public string Shop { get; set; } = "Not Specified";

        public string Description { get; set; } = "";

        public bool Done { get; set; } = false;
    }
}