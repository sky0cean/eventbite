﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Infrastructure;
using WebMVC.Models;

namespace WebMVC.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly string _baseUri;
        private readonly IHttpClient _client;
        public CatalogService(IConfiguration config,
            IHttpClient client)
        {
            _baseUri = $"{config["catalogUrl"]}/api/catalog/";
            _client = client;
        }
        public async Task<Catalog> GetCatalogItemsAsync(int page, int size,
            int? category, int? format)
        {
            var catalogItemsUri = ApiPaths.Catalog.GetAllCatalogItems(_baseUri,
                                    page, size, category, format);
            var dataString = await _client.GetStringAsync(catalogItemsUri);
            return JsonConvert.DeserializeObject<Catalog>(dataString);
        }

        public async Task<IEnumerable<SelectListItem>> GetCategoriesAsync()
        {
            var categoryUri = ApiPaths.Catalog.GetAllCategories(_baseUri);
            var dataString = await _client.GetStringAsync(categoryUri);
            var items = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = null,
                    Text = "All",
                    Selected = true
                }
            };
            var categories = JArray.Parse(dataString);
            foreach(var category in categories)
            {
                items.Add(
                    new SelectListItem
                    {
                        Value = category.Value<string>("id"),
                        Text = category.Value<string>("category")
                    }
                );
            }

            return items;
        }

        public async Task<IEnumerable<SelectListItem>> GetFormatsAsync()
        {
            var formatUri = ApiPaths.Catalog.GetAllFormats(_baseUri);
            var dataString = await _client.GetStringAsync(formatUri);
            var items = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = null,
                    Text = "All",
                    Selected = true
                }
            };
            var formats = JArray.Parse(dataString);
            foreach (var format in formats)
            {
                items.Add(
                    new SelectListItem
                    {
                        Value = format.Value<string>("id"),
                        Text = format.Value<string>("format")
                    }
                );
            }

            return items;
        }
    }
}
