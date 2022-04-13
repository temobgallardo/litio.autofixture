using System.Collections.Generic;

namespace Litio.AutoFixture
{
  public interface IShopingList
  {
    string BasketId { get; }
    List<Product> Products { get; }

  }
}