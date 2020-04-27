using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Models;

namespace WebMVC.Services
{
    public interface ICatalogService
    {
        Task<Catalog> GetCatalogItemsAsync(int page, int size, int? category, int? format);
        Task<IEnumerable<SelectListItem>> GetFormatsAsync();
        Task<IEnumerable<SelectListItem>> GetCategoriesAsync();
    }
}
