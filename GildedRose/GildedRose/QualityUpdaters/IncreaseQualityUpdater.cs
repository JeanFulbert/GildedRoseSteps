using System;

namespace GildedRose.QualityUpdaters
{
    public abstract class IncreaseQualityUpdater  : IItemQualityUpdater
    {
        public abstract void UpdateQuality(Item item);
        
        protected void IncreaseQuality(Item item, int increment = 1)
        {
            item.Quality =
                Math.Min(
                    50,
                    item.Quality + increment);
        }
    }
}