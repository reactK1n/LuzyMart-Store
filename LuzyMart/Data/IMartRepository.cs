using LuzyMart.Models.Domain;
using System;
using System.Collections.Generic;

namespace LuzyMart.Data
{
    public interface IMartRepository
    {
        Product GetProductbyId(Guid id);

        ICollection<Product> GetProductByName(string name);

        ICollection<Product> GetAllProducts();
	}
}
