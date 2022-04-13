using System.Collections.Generic;

namespace Litio.AutoFixture
{
  public class ShoppingList : IShopingList
  {
    public List<Product> Products { get; set; }
    public List<string> Tags { get; set; }
    public string BasketId { get; set; }
  }
}
