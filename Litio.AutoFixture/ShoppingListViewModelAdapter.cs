using System;
using System.Collections.Generic;

namespace Litio.AutoFixture
{
  public class ShoppingListViewModelAdapter : ViewModelAdapterBase<ShoppingList>, IShopingList
  {
    public ShoppingListViewModelAdapter(ShoppingList model, IModelBuilder<ShoppingList> modelBuilder)
    {
      this.SetupsProducts();
    }

    public string BasketId => this.Model.BasketId;
    public List<Product> Products { get; }

    private void SetupsProducts()
    {
      this.Products = this.ModelBuilder.Build<List<Product>>(this.Model);
    }
  }
}