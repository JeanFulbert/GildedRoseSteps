namespace GildedRose.QualityUpdaters
{
    public class AgedBrieQualityUpdater : IItemQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            IncreaseQuality(item);

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                IncreaseQuality(item);
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