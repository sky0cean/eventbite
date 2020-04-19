using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Models;

namespace WebMVC.Services
{
    interface ICatalogService
    {
        Task<Catalog> GetCatalogItemsAsync(int page, int size);
    }
}
