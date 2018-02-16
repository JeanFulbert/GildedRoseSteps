namespace GildedRose.QualityUpdaters
{
    public abstract class IncreaseQualityUpdater  : IItemQualityUpdater
    {
        public abstract void UpdateQuality(Item item);
        
        protected void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }
    }
}