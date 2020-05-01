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
                var filterQs = "";

                if(format.HasValue)
                {
                    var categoryQs = (category.HasValue) ? category.Value.ToString() : string.Empty;
                    filterQs = $"/format/{format.Value}/category/{categoryQs}";
                }
                else if(category.HasValue)
                {
                    var categoryQs = (category.HasValue) ? category.Value.ToString() : string.Empty;
                    filterQs = $"/format/all/category/{categoryQs}";
                }
                else
                {
                    filterQs = string.Empty;
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
                //It was catalog"C"ategory 
                return $"{baseUri}catalogcategories";
            }
        }

        public static class Basket
        {

        }
    }
}
