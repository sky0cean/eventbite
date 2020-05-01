using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventCatalogApi.Data;
using EventCatalogApi.Domain;
using EventCatalogApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EventCatalogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly CatalogContext _context;
        private readonly IConfiguration _config;
        public CatalogController(CatalogContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Items(
            [FromQuery]int pageIndex = 0,
            [FromQuery]int pageSize = 9)
        {
            var itemsCount = await _context.CatalogItems.LongCountAsync();

            var items = await _context.CatalogItems
                               .OrderBy(c => c.Name)
                               .Skip(pageIndex * pageSize)
                               .Take(pageSize)
                               .ToListAsync();
            items = ChangePictureUrl(items);

            var model = new PaginatedItemsViewModel<CatalogItem>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                Count = itemsCount,
                Data = items
            };
            return Ok(model);
        }

        [HttpGet]
        [Route("[action]/format/{catalogFormatId}/category/{catalogCategoryId}")]
        public async Task<IActionResult> Items(
        int? catalogFormatId,
        int? catalogCategoryId,
        [FromQuery]int pageIndex = 0,
        [FromQuery]int pageSize = 9)
        {
            var root = (IQueryable<CatalogItem>)_context.CatalogItems;
            if (catalogFormatId.HasValue)
            {
                root = root.Where(c => c.CatalogFormatId == catalogFormatId);
            }
            if (catalogCategoryId.HasValue)
            {
                root = root.Where(c => c.CatalogCategoryId == catalogCategoryId);
            }


            var itemsCount = await root.LongCountAsync();

            var items = await root
                                .OrderBy(c => c.Name)
                                .Skip(pageIndex * pageSize)
                                .Take(pageSize)
                                .ToListAsync();

            items = ChangePictureUrl(items);

            var model = new PaginatedItemsViewModel<CatalogItem>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                Count = itemsCount,
                Data = items
            };
            return Ok(model);
        }



        [HttpGet]
        [Route("[action]/format/all/category/{catalogCategoryId:int?}")]
        public async Task<IActionResult> Items(
            int? catalogCategoryId,
            [FromQuery]int pageIndex = 0, 
            [FromQuery]int pageSize = 9)
        {
            var root = (IQueryable<CatalogItem>)_context.CatalogItems;

            if (catalogCategoryId.HasValue)
            {
                root = root.Where(c => c.CatalogCategoryId == catalogCategoryId);
            }

            var itemsCount = await root.LongCountAsync();

            var items = await root
                               .OrderBy(c => c.Name)
                               .Skip(pageIndex * pageSize)
                               .Take(pageSize)
                               .ToListAsync();
            items = ChangePictureUrl(items);

            var model = new PaginatedItemsViewModel<CatalogItem>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                Count = itemsCount,
                Data = items
            };
            return Ok(model);

        }

        private List<CatalogItem> ChangePictureUrl(List<CatalogItem> items)
        {
            items.ForEach(
                c => c.PictureUrl =
                    c.PictureUrl.Replace("http://externalcatalogbaseurltobereplaced",
                        _config["ExternalCatalogBaseUrl"])
                    );
            return items;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> CatalogFormats()
        {
            var items = await _context.CatalogFormats.ToListAsync();
            return Ok(items);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> CatalogCategories()
        {
            var items = await _context.CatalogCategories.ToListAsync();
            return Ok(items);
        }
    }
}