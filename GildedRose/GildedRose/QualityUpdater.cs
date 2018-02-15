using System.Collections.Generic;

namespace GildedRose
{
    public class QualityUpdater
    {
        public const string AgedBrie = "Aged Brie";
        public const string Backstage = "Backstage passes to a TAFKAL80ETC concert";
        public const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        
        public void UpdateQuality(IList<Item> items)
        {
            foreach (var item in items)
            {
                UpdateQualityOf(item);
            }
        }

        private static void UpdateQualityOf(Item item)
        {
            if (item.Name == AgedBrie)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
                
                item.SellIn = item.SellIn - 1;
                
                if (item.SellIn < 0)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }
            else if (item.Name == Backstage)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;

                    if (item.SellIn < 11)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }

                    if (item.SellIn < 6)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                }
                
                item.SellIn = item.SellIn - 1;
                

                if (item.SellIn < 0)
                {
                    item.Quality = item.Quality - item.Quality;
                }
            }
            else if  (item.Name == Sulfuras)
            {
            }
            else
            {
                if (item.Quality > 0)
                {
                    item.Quality = item.Quality - 1;
                }
                
                item.SellIn = item.SellIn - 1;


                if (item.SellIn < 0)
                {
                    if (item.Quality > 0)
                    {
                        item.Quality = item.Quality - 1;
                    }
                }
            }
        }
    }
}