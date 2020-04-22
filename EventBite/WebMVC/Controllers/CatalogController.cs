﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            var itemsOnPage = 10;

            var catalog = await _service.GetCatalogItemsAsync(page ?? 0, itemsOnPage,
                categoriesFilterApplied, formatsFilterApplied);
            var vm = new CatalogIndexViewModel
            {
                CatalogItems = catalog.Data,
                PaginationInfo = new PaginationInfo
                {
                    ActualPage = page ?? 0,
                    ItemsPerPage = itemsOnPage,
                    TotalItems = catalog.Count,
                    TotalPages = (int)Math.Ceiling((decimal)catalog.Count / itemsOnPage)
                },

                Categories = await _service.GetCategoriesAsync(),
                Formats = await _service.GetFormatsAsync(),
                CategoriesFilterApplied = categoriesFilterApplied ?? 0,
                FormatsFilterApplied = formatsFilterApplied ?? 0
               
            };

            return View(vm);
        }
    }
}