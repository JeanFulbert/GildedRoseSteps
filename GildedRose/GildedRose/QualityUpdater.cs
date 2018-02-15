using System.Collections.Generic;
using GildedRose.QualityUpdaters;

namespace GildedRose
{
    public class QualityUpdater
    {
        public const string AgedBrie = "Aged Brie";
        public const string Backstage = "Backstage passes to a TAFKAL80ETC concert";
        public const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        
        private readonly AgedBrieQualityUpdater agedBrieQualityUpdater = new AgedBrieQualityUpdater();
        private readonly BackstageQualityUpdater backstageQualityUpdater = new BackstageQualityUpdater();
        private readonly SulfurasQualityUpdater sulfurasQualityUpdater = new SulfurasQualityUpdater();
        private readonly NormalQualityUpdater normalQualityUpdater = new NormalQualityUpdater();
        
        public void UpdateQuality(IList<Item> items)
        {
            foreach (var item in items)
            {
                this.UpdateQualityOf(item);
            }
        }

        private void UpdateQualityOf(Item item)
        {
            if (item.Name == AgedBrie)
            {
                this.agedBrieQualityUpdater.UpdateQuality(item);
            }
            else if (item.Name == Backstage)
            {
                this.backstageQualityUpdater.UpdateQuality(item);
            }
            else if  (item.Name == Sulfuras)
            {
                this.sulfurasQualityUpdater.UpdateQuality(item);
            }
            else
            {
                this.normalQualityUpdater.UpdateQuality(item);
            }
        }
    }
}