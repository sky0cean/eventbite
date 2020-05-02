using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Services;
using WebMVC.ViewModels;

namespace WebMVC.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ICatalogService _service;
        public CatalogController(ICatalogService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index(int? page, int? categoriesFilterApplied,
            int? formatsFilterApplied)
        {

            var itemsOnPage = 9;

            var catalog = await _service.GetCatalogItemsAsync(page ?? 0, itemsOnPage,
                categoriesFilterApplied, formatsFilterApplied);
            var vm = new CatalogIndexViewModel
            {
                CatalogItems = catalog.Data,
                Categories = await _service.GetCategoriesAsync(),
                Formats = await _service.GetFormatsAsync(),
                CategoriesFilterApplied = categoriesFilterApplied ?? 0,
                FormatsFilterApplied = formatsFilterApplied ?? 0,
                PaginationInfo = new PaginationInfo
                {
                    ActualPage = page ?? 0,
                    TotalItems = catalog.Count,
                    ItemsPerPage = itemsOnPage,
                    TotalPages = (int)Math.Ceiling((decimal)catalog.Count / itemsOnPage)
                }   
            };

            vm.PaginationInfo.Next = (vm.PaginationInfo.ActualPage == vm.PaginationInfo.TotalPages - 1) ? "is-disabled" : "";
            vm.PaginationInfo.Previous = (vm.PaginationInfo.ActualPage == 0) ? "is-disabled" : "";


            return View(vm);
        }

        [Authorize]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";


            return View();
        }

    }
}