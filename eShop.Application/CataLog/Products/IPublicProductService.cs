using eShop.Application.CataLog.Products.Dtos;
using eShop.Application.CataLog.Products.Dtos.Manage;
using eShop.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.CataLog.Products
{
    public interface IPublicProductService
    {
        public PagedResult<ProductViewModel> GetAllCategoryId(GetProductPagingRequest request);
    }
}
