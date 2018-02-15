using System.Collections.Generic;
using GildedRose.QualityUpdaters;

namespace GildedRose
{
    public class QualityUpdater
    {
        public const string AgedBrie = "Aged Brie";
        public const string Backstage = "Backstage passes to a TAFKAL80ETC concert";
        public const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        
        private readonly NormalQualityUpdater normalQualityUpdater = new NormalQualityUpdater();
        
        private readonly IDictionary<string, IItemQualityUpdater> qualityUpdaterByName =
            new Dictionary<string, IItemQualityUpdater>
            {
                [AgedBrie] = new AgedBrieQualityUpdater(),
                [Backstage] = new BackstageQualityUpdater(),
                [Sulfuras] = new LegendaryQualityUpdater(),
            };
        
        public void UpdateQuality(IList<Item> items)
        {
            foreach (var item in items)
            {
                this.UpdateQualityOf(item);
            }
        }

        private void UpdateQualityOf(Item item)
        {
            IItemQualityUpdater qualityUpdater = this.normalQualityUpdater;
            if (this.qualityUpdaterByName.ContainsKey(item.Name))
            {
                qualityUpdater = this.qualityUpdaterByName[item.Name];
            }
            
            qualityUpdater.UpdateQuality(item);
        }
    }
}