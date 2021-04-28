using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification()
        {
            AddInclude(x => x.ProductType);
            AddInclude(p => p.ProductBrand);
        }

        public ProductsWithTypesAndBrandsSpecification(int id)
        : base(p => p.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(p => p.ProductBrand);
        }
    }
}