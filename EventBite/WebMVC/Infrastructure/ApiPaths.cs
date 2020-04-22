using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Infrastructure
{
    public class ApiPaths
    {
        public static class Catalog
        {
            public static string GetAllCatalogItems(string baseUri,
                int page, int take)
            {
                return $"{baseUri}items?pageIndex={page}&pageSize={take}";
            }

            public static string GetAllFormats(string baseUri)
            {
                return $"{baseUri}catalogformats";
            }

            public static string GetAllCategories(string baseUri)
            {
                return $"{baseUri}catalogCategories";
            }
        }

        public static class Basket
        {

        }
    }
}
