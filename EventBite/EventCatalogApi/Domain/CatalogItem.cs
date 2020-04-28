using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogApi.Domain
{
    public class CatalogItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public int CatalogCategoryId { get; set; }
        public int CatalogFormatId { get; set; }
        public virtual CatalogCategory CatalogCategory { get; set; }
        public virtual CatalogFormat CatalogFormat { get; set; }
    }
}
