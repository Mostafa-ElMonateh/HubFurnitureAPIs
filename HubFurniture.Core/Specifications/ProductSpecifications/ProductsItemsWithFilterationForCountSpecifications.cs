﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubFurniture.Core.Entities;

namespace HubFurniture.Core.Specifications.ProductSpecifications
{
    public class ProductsItemsWithFilterationForCountSpecifications : BaseSpecifications<CategoryItem>
    {
        public ProductsItemsWithFilterationForCountSpecifications(ProductSpecParams specParams)
            :base(cs => 
                (!specParams.CategoryId.HasValue || cs.CategoryId == specParams.CategoryId) &&
                (string.IsNullOrEmpty(specParams.ProductColor) || cs.Color == specParams.ProductColor) &&
                (!specParams.ItemTypeId.HasValue || cs.CategoryItemTypeId == specParams.ItemTypeId) &&
                (!specParams.MinimumPrice.HasValue || cs.Price >= specParams.MinimumPrice) &&
                (!specParams.MaximumPrice.HasValue || cs.Price <= specParams.MaximumPrice)
            )
        {
            
        }
    }
}
