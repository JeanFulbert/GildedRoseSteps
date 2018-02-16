namespace GildedRose.QualityUpdaters
{
    public class ConjuredQualityUpdater : DecreaseQualityUpdater
    {
        public override void UpdateQuality(Item item)
        {
            item.SellIn = item.SellIn - 1;
            
            var decreaseFactor =
                item.SellIn < 0
                    ? 4 
                    : 2;
            this.DecreaseQuality(item, decreaseFactor);
        }
    }
}