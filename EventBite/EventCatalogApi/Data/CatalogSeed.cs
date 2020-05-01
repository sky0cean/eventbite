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
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=3, Description = "Festival of Children's Rhythmic Gymnastics. 211 likes. Stadium, Arena & Sports Venue. I just can’t adult right now.", Name = "Festival of Rhythmic gymnastics", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/1" },
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=9, Description = "FIFA World Cup Asian Qualifiers", Name = "YK-FM vs G-OSAK", Price = 12.99M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/2" },
                new CatalogItem { CatalogCategoryId=2, CatalogFormatId=5, Description = "2020 Beaujolais nouveau release! Twinkle, twinkle, little star, point me to the nearest bar.", Name = "Wine Tasting", Price = 12.99M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/3" },
                new CatalogItem { CatalogCategoryId=3, CatalogFormatId=7, Description = "The human body is 90% water so we’re basically just cucumbers with anxiety. Discussion & Support by Dr Spiritual", Name = "Quarantine days? open yourself!", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/4" },
                new CatalogItem { CatalogCategoryId=5, CatalogFormatId=3, Description = "Come experience the Water Lantern Festival with your friends and family as the floating lanterns reflect messages of love, hope, and happiness upon the water.", Name = "Seattle Water Lantern Festival 2020", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/5" },
                new CatalogItem { CatalogCategoryId=5, CatalogFormatId=3, Description = "Experience the culture beauty and spirit of the Polynesian Islands.", Name = "polynesian culture festival", Price = 12.99M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/6" },
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=6, Description = "The premiere 42.195K paint race. Live for the moments you can’t put into words.", Name = "Color run! 2020", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/7" },
                new CatalogItem { CatalogCategoryId=8, CatalogFormatId=1, Description = "Let's take good care of our animals.", Name = "PET CLASS 2020", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/8" },
                new CatalogItem { CatalogCategoryId=4, CatalogFormatId=3, Description = "All Locations, United States, Europe, Asia.  The World's Hottest Music Festival. Summer should get a speeding ticket.", Name = "Summer Music Festival 2020", Price = 12.99M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/9" },
                new CatalogItem { CatalogCategoryId=6, CatalogFormatId=3, Description = "World's biggest hot-air baloon festival in South Carolina. We rise by lifting others.", Name = "International Balloon Fiesta 2020", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/10" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "The Academy of Online Education present", Name = "Basic Web Develop classes.", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/11" },
                new CatalogItem { CatalogCategoryId=4, CatalogFormatId=3, Description = "New York Summer Rock Festival is a free, outdoor festival of the arts held each year in Bryant Park ", Name = "New York Summer Rock Festival", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/12" },
                new CatalogItem { CatalogCategoryId=5, CatalogFormatId=8, Description = "Join Museum Director Alice on Saturday October 24, for a guided walk in Oakland Cemetery.", Name = "Oakland Cemerery Tour(in the dark)", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/13" },
                new CatalogItem { CatalogCategoryId=3, CatalogFormatId=7, Description = "Don’t call it a dream, call it a plan. Free Motivational Seminar from Expert Speaker, Dr. Moti Vation.", Name = "Unstoppable: Motivational Seminar", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/14" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, Description = "Find your future at Xenon.", Name = "Open job fair, June 12 & 13", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/15" },
                new CatalogItem { CatalogCategoryId=4, CatalogFormatId=8, Description = "OUT MAY 5th FEAT.TIMELESS PRE-ORDER NOW, Nights we won’t remember with people we won’t forget.", Name = "Melinda T Berst 2020", Price = 12.99M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/16" },
                new CatalogItem { CatalogCategoryId=8, CatalogFormatId=1, Description = "Basic Digital DSLR Class. With instructor Haskey Suzuka.", Name = "Photography workshops", Price = 12.99M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/17" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=2, Description = "Hire character. Train skill. -Peter Schutz The event will also include hands-on Workshops.", Name = "Recruiting 101", Price = 12.99M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/18" },
                new CatalogItem { CatalogCategoryId=2, CatalogFormatId=5, Description = "The way to instantly connect with neighbors. Espresso may not be the answer but it’s worth a shot.", Name = "Over the table", Price = 12.99M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/19" },
                new CatalogItem { CatalogCategoryId=6, CatalogFormatId=1, Description = "We have nothing to lose and a world to sea. All Weekend of July", Name = "Sat Surf School", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/20" },
                new CatalogItem { CatalogCategoryId=9, CatalogFormatId=3, Description = "Eveything you need to know about Mardi Gras in New Mexico. This year, it is happening in New Mexico.", Name = "Mardi Gras in New Mexico 2020", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/21" },
                new CatalogItem { CatalogCategoryId=2, CatalogFormatId=1, Description = "Re-think your food. First, we eat, then we can do everything else.", Name = "Discover your way to gourmet", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/22" },
                new CatalogItem { CatalogCategoryId=2, CatalogFormatId=1, Description = "Kyobi Cooking school.", Name = "Season it jut right!", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/23" },
                new CatalogItem { CatalogCategoryId=9, CatalogFormatId=1, Description = "The only bad workout is the one that didn’t happen.", Name = "Yoga yourself", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/24" },
                new CatalogItem { CatalogCategoryId=8, CatalogFormatId=1, Description = "A good teacher can inspire hope, ignite the imagination, and instill a love of learning. ― Brad Henry", Name = "Art class", Price = 12.99M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/25" },
                new CatalogItem { CatalogCategoryId=6, CatalogFormatId=1, Description = "A brighter future for all.", Name = "Pre-K, summar school", Price = 12.99M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/26" },
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=1, Description = "Fall in love with taking care of yourself.", Name = "Fitness with Alice", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/27" },
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=1, Description = "WESTGROVE HALL, AUSTIN, TX", Name = "DAWSON MAKEUP MASTERCLASS", Price = 0.00M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/28" },
                new CatalogItem { CatalogCategoryId=8, CatalogFormatId=3, Description = "Anime Weekend New York is the largest Anime Convention in the eastcoast.", Name = "Anime Weekend 2020", Price = 12.99M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/29" }
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
