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
                int page, int take, int? category, int? format)
            {
                var filterQs = string.Empty;
                if(category.HasValue || format.HasValue)
                {
                    var categoryQs = (category.HasValue) ? category.Value.ToString() : "null";
                    var formatQs = (format.HasValue) ? format.Value.ToString() : "null";
                    filterQs = $"/format/{formatQs}/category/{categoryQs}";
                }
                return $"{baseUri}items{filterQs}?pageIndex={page}&pageSize={take}";

                //I forgot to chenge below to above and filter was not working.
                //return $"{baseUri}items?pageIndex={page}&pageSize={take}";
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
