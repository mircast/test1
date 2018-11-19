using System;
using System.Data.Common;
using System.Linq;
using API.Model;
using System.Collections.Generic;


namespace API.Interfaces
{
    public interface IShoppingCartService
    {
        IEnumerable<ShoppingItem> GetAllItems();
        ShoppingItem Add(ShoppingItem newItem);
        ShoppingItem GetById(Guid id);
        void Remove(Guid id);

    }
}