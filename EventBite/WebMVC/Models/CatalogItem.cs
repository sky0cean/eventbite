using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Models
{
    public class CatalogItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string PictureUrl { get; set; }
        public int CatalogCategoryId { get; set; }
        public int CatalogFormatId { get; set; }
        public string CatalogCategory { get; set; }
        public string CatalogFormat { get; set; }
    }
}
