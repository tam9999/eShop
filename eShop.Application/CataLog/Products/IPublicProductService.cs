using eShop.ViewModels.CataLog.Products;
using eShop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.Application.CataLog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
    }
}
