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
            if (!context.CatalogDates.Any())
            {
                context.CatalogDates.AddRange(GetPreConfiguredCatalogDates());
                context.SaveChanges();
            }
            if (!context.CatalogPrices.Any())
            {
                context.CatalogPrices.AddRange(GetPreConfiguredCatalogPrices());
                context.SaveChanges();
            }

        }

        private static IEnumerable<CatalogPrice> GetPreConfiguredCatalogPrices()
        {
            return new List<CatalogPrice>()
            {
                new CatalogPrice{ Price = "Free"},
                new CatalogPrice{ Price = "Paid"}
            };
        }

        private static IEnumerable<CatalogDate> GetPreConfiguredCatalogDates()
        {
            return new List<CatalogDate>()
            {
                new CatalogDate{ Date = "Today"},
                new CatalogDate{ Date = "Tomorrow"},
                new CatalogDate{ Date = "This Weekend"},
                new CatalogDate{ Date = "This week"},
                new CatalogDate{ Date = "Next Week"},
                new CatalogDate{ Date = "This month"},
                new CatalogDate{ Date = "Next month"}
            };
        }

        private static IEnumerable<CatalogItem> GetPreConfiguredCatalogItems()
        {
            return new List<CatalogItem>()
            {
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=3, CatalogPriceId=1, CatalogDateId=1, Description = "Festival of Children's Rhythmic Gymnastics. 211 likes. Stadium, Arena & Sports Venue. I just can’t adult right now.", Name = "Festival of Rhythmic gymnastics", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/1" },
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=9, CatalogPriceId=2, CatalogDateId=2, Description = "FIFA World Cup Asian Qualifiers", Name = "YK-FM vs G-OSAK", Price = "Paid", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/2" },
                new CatalogItem { CatalogCategoryId=2, CatalogFormatId=5, CatalogPriceId=2, CatalogDateId=3, Description = "2020 Beaujolais nouveau release! Twinkle, twinkle, little star, point me to the nearest bar.", Name = "Wine Tasting", Price = "Paid", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/3" },
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=3, CatalogPriceId=1, CatalogDateId=4, Description = "The human body is 90% water so we’re basically just cucumbers with anxiety. Discussion & Support by Dr Spiritual", Name = "Quarantine days? open up your mind!", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/4" },
                new CatalogItem { CatalogCategoryId=5, CatalogFormatId=3, CatalogPriceId=1, CatalogDateId=5, Description = "Come experience the Water Lantern Festival with your friends and family as the floating lanterns reflect messages of love, hope, and happiness upon the water.", Name = "Seattle Water Lantern Festival 2020", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/5" },
                new CatalogItem { CatalogCategoryId=2, CatalogFormatId=4, CatalogPriceId=2, CatalogDateId=6, Description = "It’s cake o’clock. Dress up your favorite costumes. Be a part of Alice in Wonderland.", Name = "Mad hatter tea party", Price = "Paid", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/6" },
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=6, CatalogPriceId=1, CatalogDateId=7, Description = "The premiere 42.195K paint race. Live for the moments you can’t put into words.", Name = "Color run! 2020", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/7" },
                new CatalogItem { CatalogCategoryId=8, CatalogFormatId=7, CatalogPriceId=1, CatalogDateId=1, Description = "We will help you capture unforgettable photos on Brooklyn Bridge.", Name = "Photoshoot on Brooklyn Bridge.", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/8" },
                new CatalogItem { CatalogCategoryId=4, CatalogFormatId=3, CatalogPriceId=2, CatalogDateId=2, Description = "All Locations, United States, Europe, Asia.  The World's Hottest Music Festival. Summer should get a speeding ticket.", Name = "Summer Music Festival 2020", Price = "Paid", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/9" },
                new CatalogItem { CatalogCategoryId=6, CatalogFormatId=3, CatalogPriceId=1, CatalogDateId=3, Description = "World's biggest hot-air baloon festival in New Mexico. We rise by lifting others.", Name = "International Balloon Fiesta 2020", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/10" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, CatalogPriceId=1, CatalogDateId=4, Description = "Lecture 1: What is Computation?", Name = "Introduction to Computer Science and Programming in Python.", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/11" },
                new CatalogItem { CatalogCategoryId=4, CatalogFormatId=3, CatalogPriceId=1, CatalogDateId=5, Description = "New York Summer Rock Festival is a free, outdoor festival of the arts held each year in Bryant Park ", Name = "New York Summer Rock Festival", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/12" },
                new CatalogItem { CatalogCategoryId=5, CatalogFormatId=8, CatalogPriceId=1, CatalogDateId=6, Description = "Join Museum Director Alice on Saturday October 24, for a guided walk in Oakland Cemetery.", Name = "Trick or Treat! Oakland Cemerery Tour(in the dark)", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/13" },
                new CatalogItem { CatalogCategoryId=3, CatalogFormatId=7, CatalogPriceId=1, CatalogDateId=7, Description = "Don’t call it a dream, call it a plan. Free Motivational Seminar from Expert Speaker, Dr. Moti Vation.", Name = "Unstoppable: Motivational Seminar", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/14" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=1, CatalogPriceId=1, CatalogDateId=1, Description = "The purpose of the LeaderShip Skills seminar is to strengthen your current management skill with more distinguished dimension.", Name = "Leadership Skills Seminar", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/15" },
                new CatalogItem { CatalogCategoryId=4, CatalogFormatId=8, CatalogPriceId=2, CatalogDateId=2, Description = "OUT MAY 5th FEAT.TIMELESS PRE-ORDER NOW, Nights we won’t remember with people we won’t forget.", Name = "Jon Bavi 2020", Price = "Paid", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/16" },
                new CatalogItem { CatalogCategoryId=8, CatalogFormatId=1, CatalogPriceId=2, CatalogDateId=3, Description = "Basic Digital DSLR Class. With instructor Haskey Suzuka.", Name = "Photography workshops for beginners", Price = "Paid", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/17" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=2, CatalogPriceId=2, CatalogDateId=4, Description = "Hire character. Train skill. -Peter Schutz The event will also include hands-on Workshops.", Name = "Recruiting 101", Price = "Paid", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/18" },
                new CatalogItem { CatalogCategoryId=2, CatalogFormatId=5, CatalogPriceId=2, CatalogDateId=5, Description = "The way to instantly connect with neighbors. Espresso may not be the answer but it’s worth a shot.", Name = "Over the table", Price = "Paid", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/19" },
                new CatalogItem { CatalogCategoryId=6, CatalogFormatId=8, CatalogPriceId=1, CatalogDateId=6, Description = "We have nothing to lose and a world to see. Obsarve local squids now.", Name = "Squid watch", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/20" },
                new CatalogItem { CatalogCategoryId=9, CatalogFormatId=3, CatalogPriceId=1, CatalogDateId=7, Description = "Eveything you need to know about Mardi Gras in New Mexico. This year, it is happening in New Mexico.", Name = "Mardi Gras in New Mexico 2020", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/21" },
                new CatalogItem { CatalogCategoryId=2, CatalogFormatId=5, CatalogPriceId=1, CatalogDateId=1, Description = "Re-think your food. First, we eat, then we can do everything else.", Name = "Discover your way to gourmet", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/22" },
                new CatalogItem { CatalogCategoryId=1, CatalogFormatId=2, CatalogPriceId=1, CatalogDateId=2, Description = "People forget years and remember moments.", Name = "Admission free Day,  Modern Art Museum", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/23" },
                new CatalogItem { CatalogCategoryId=9, CatalogFormatId=1, CatalogPriceId=1, CatalogDateId=3, Description = "The only bad workout is the one that didn’t happen.", Name = "Yoga yourself", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/24" },
                new CatalogItem { CatalogCategoryId=8, CatalogFormatId=7, CatalogPriceId=2, CatalogDateId=4, Description = "A good teacher can inspire hope, ignite the imagination, and instill a love of learning. ― Brad Henry", Name = "Art class", Price = "Paid", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/25" },
                new CatalogItem { CatalogCategoryId=6, CatalogFormatId=9, CatalogPriceId=2, CatalogDateId=5, Description = "Always take the scenic route.", Name = "Discover the nature, summar camp", Price = "Paid", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/26" },
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=1, CatalogPriceId=1, CatalogDateId=6, Description = "Fall in love with taking care of yourself.", Name = "Run for Me", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/27" },
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=1, CatalogPriceId=1, CatalogDateId=7, Description = "You may not be there yet but you’re closer than yesterday.", Name = "Gentle Yoga with Amy", Price = "Free", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/28" },
                new CatalogItem { CatalogCategoryId=7, CatalogFormatId=1, CatalogPriceId=2, CatalogDateId=1, Description = "70% of the people who start a fitness plan quit. Except not you. Not this time.", Name = "HipHop 101", Price = "Paid", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/29" }
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
