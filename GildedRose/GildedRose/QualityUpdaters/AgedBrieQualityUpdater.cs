using System;

namespace GildedRose.QualityUpdaters
{
    public class AgedBrieQualityUpdater : IncreaseQualityUpdater
    {
        public override void UpdateQuality(Item item)
        {
            item.SellIn = item.SellIn - 1;

            var increaseFactor =
                item.SellIn < 0
                    ? 2 
                    : 1;
            
            this.IncreaseQuality(item, increaseFactor);
        }
    }
}