﻿namespace GildedRose.QualityUpdaters
{
    public class NormalQualityUpdater : DecreaseQualityUpdater
    {
        public override void UpdateQuality(Item item)
        {
            item.SellIn = item.SellIn - 1;
            
            var decreaseFactor =
                item.SellIn < 0
                    ? 2 
                    : 1;
            this.DecreaseQuality(item, decreaseFactor);
        }
    }
}