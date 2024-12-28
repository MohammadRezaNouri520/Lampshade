using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace ShopManagement.Configuration.Permissions
{
    public class ShopPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Product", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ListProducts, "لیست محصولات"),
                        new PermissionDto(ShopPermissions.SearchProducts, "جستجوی محصولات"),
                        new PermissionDto(ShopPermissions.CreateProduct, "ایجاد محصول"),
                        new PermissionDto(ShopPermissions.EditProduct, "ویرایش محصول"),
                    }
                },
                {
                    "ProductCategory", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.SearchProductCategories, "جستجوی گروه محصولات"),
                        new PermissionDto(ShopPermissions.ListProductCategories, "لیست گروه محصولات"),
                        new PermissionDto(ShopPermissions.CreateProductCategory, "ایجاد گروه محصولات"),
                        new PermissionDto(ShopPermissions.EditProductCategory, "ویرایش گروه محصولات"),
                    }
                }
            };
        }
    }
}