namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        public int GroceryListId { get
        {
            return Id;
        } set
        {
            if (value < 0) {
                throw new ArgumentOutOfRangeException("GroceryListId cannot be negative");
            }
            else
            {
                Id = value;
            }
        } }
        public int ProductId { get; set; }
        public int Amount { get
        {
            return Id;
        } set
        {
            if (value < 0) {
                throw new ArgumentOutOfRangeException("Amount cannot be negative");
            }
            else
            {
                Id = value;
            }
        } }


        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            GroceryListId = groceryListId;
            ProductId = productId;
            Amount = amount;
        }

        public Product Product { get; set; } = new(0, "None", 0);
    }
}
