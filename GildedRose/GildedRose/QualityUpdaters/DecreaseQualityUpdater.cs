namespace GildedRose.QualityUpdaters
{
    public abstract class DecreaseQualityUpdater  : IItemQualityUpdater
    {
        public abstract void UpdateQuality(Item item);
        
        protected void DecreaseQuality(Item item, int decrement = 1)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - decrement;
            }
        }
    }
}