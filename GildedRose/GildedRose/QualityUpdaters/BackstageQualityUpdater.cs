namespace GildedRose.QualityUpdaters
{
    public class BackstageQualityUpdater : IItemQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            IncreaseQuality(item);
            
            if (item.SellIn < 11)
            {
                IncreaseQuality(item);
            }

            if (item.SellIn < 6)
            {
                IncreaseQuality(item);
            }

            item.SellIn = item.SellIn - 1;


            if (item.SellIn < 0)
            {
                item.Quality = item.Quality - item.Quality;
            }
        }

        private static void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }
    }
}