using System;

namespace GildedRose.QualityUpdaters
{
    public class NormalQualityUpdater : IItemQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn = item.SellIn - 1;
            
            var decreaseFactor =
                item.SellIn < 0
                    ? 2 
                    : 1;
            DecreaseQuality(item, decreaseFactor);
        }

        private static void DecreaseQuality(Item item, int decrement)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - decrement;
            }
        }
    }
}