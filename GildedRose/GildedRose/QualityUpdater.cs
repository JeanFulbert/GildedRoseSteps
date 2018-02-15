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
                UpdateAgedBrie(item);
            }
            else if (item.Name == Backstage)
            {
                UpdateBackstage(item);
            }
            else if  (item.Name == Sulfuras)
            {
                UpdateSulfuras(item);
            }
            else
            {
                UpdateNormal(item);
            }
        }

        private static void UpdateAgedBrie(Item item)
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

        private static void UpdateBackstage(Item item)
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

        private static void UpdateSulfuras(Item item)
        {
            // Do nothing because it's legen… wait for it …DARY !
        }

        private static void UpdateNormal(Item item)
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