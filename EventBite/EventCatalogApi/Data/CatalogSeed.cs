using EventCatalogApi.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogApi.Data
{
    public static class CatalogSeed
    {
        public static void Seed(CatalogContext context)
        {
            context.Database.Migrate();
            if (!context.CatalogCategories.Any())
            {
                context.CatalogCategories.AddRange(GetPreConfiguredCatalogCategories());
                context.SaveChanges();
            }
            if (!context.CatalogFormats.Any())
            {
                context.CatalogFormats.AddRange(GetPreConfiguredCatalogFormats());
                context.SaveChanges();                    
            }
            if (!context.CatalogItems.Any())
            {
                context.CatalogItems.AddRange(GetPreConfiguredCatalogItems());
                context.SaveChanges();
            }
                
        }

        private static IEnumerable<CatalogItem> GetPreConfiguredCatalogItems()
        {
            return new List<CatalogItem>()
            {
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=3, Description = "Festival of Children's Rhythmic Gymnastics. 211 likes. Stadium, Arena & Sports Venue.", Name = "Festival of Rhythmic gymnastics", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/1" },
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=9, Description = "FIFA World Cup Asian Qualifiers", Name = "YK-FM vs G-OSAK", Price = "Paid", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/2" },
                new CatalogItem { CatalogCategoryId=2, CatalogFormatId=5, Description = "2020 Beaujolais nouveau release!", Name = "Wine Tasting", Price = "Paid", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/3" },
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=3, Description = "Discussion & Support by Dr Spiritual", Name = "Quarantine days? open up your mind!", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/4" },
                new CatalogItem { CatalogCategoryId=5, CatalogFormatId=3, Description = "Come experience the Water Lantern Festival with your friends and family as the floating lanterns reflect messages of love, hope, and happiness upon the water.", Name = "Seattle Water Lantern Festival 2020", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/5" },
                new CatalogItem { CatalogCategoryId=2, CatalogFormatId=4, Description = "Dress up your favorite costumes. Be a part of Alice in Wonderland.", Name = "Mad hatter tea party", Price = "Paid", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/6" },
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=6, Description = "The premiere 42.195K paint race.", Name = "Color run! 2020", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/7" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/8" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/9" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/10" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/11" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/12" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/13" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/14" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/15" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/16" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/17" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/18" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/19" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/20" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/21" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/22" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/23" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/24" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/25" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/26" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/27" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/28" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "", Name = "", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/29" }
            };

        }

        private static IEnumerable<CatalogFormat> GetPreConfiguredCatalogFormats()
        {
            return new List<CatalogFormat>
            {
                new CatalogFormat{ Format = "Class"},
                new CatalogFormat{ Format = "Conference"},
                new CatalogFormat{ Format = "Festival"},
                new CatalogFormat{ Format = "Party"},
                new CatalogFormat{ Format = "Networking"},
                new CatalogFormat{ Format = "Race"},
                new CatalogFormat{ Format = "Seminar"},
                new CatalogFormat{ Format = "Tour"},
                new CatalogFormat{ Format = "Game"}
            };
        }

        private static IEnumerable<CatalogCategory> GetPreConfiguredCatalogCategories()
        {
            return new List<CatalogCategory>
            {
                new CatalogCategory{ Category = "Business"},
                new CatalogCategory{ Category = "Food & Drink"},
                new CatalogCategory{ Category = "Health"},
                new CatalogCategory{ Category = "Music"},
                new CatalogCategory{ Category = "Family & Education"},
                new CatalogCategory{ Category = "Travel & Outdoor"},
                new CatalogCategory{ Category = "Sports & Fitness"},
                new CatalogCategory{ Category = "Hobbies"},
                new CatalogCategory{ Category = "Other"}
            };
        }
    }
}
