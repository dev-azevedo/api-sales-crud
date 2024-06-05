﻿using SalesCrud.Infra;
using SalesCrud.Model;
using SalesCrud.Repository.Interfaces;
using System.Xml.Linq;

namespace SalesCrud.Repository;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{

    public ProductRepository(AppDbContext context) : base(context)
    { }

    public Product FindByDescription(string description)
    {
        return dataset.SingleOrDefault(p => p.Description == description);
    }

    public List<Product> FindAllByDescription(string description)
    {
        return dataset.Where(p => p.Description.ToLower().Contains(description.ToLower())).ToList();
    }
}
