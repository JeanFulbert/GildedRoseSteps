namespace GildedRose.QualityUpdaters
{
    public class NormalQualityUpdater : IItemQualityUpdater
    {
        public void UpdateQuality(Item item)
        {
            DecreaseQuality(item);

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                DecreaseQuality(item);
            }
        }

        private static void DecreaseQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
        }
    }
}