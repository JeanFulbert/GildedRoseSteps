namespace GildedRose.QualityUpdaters
{
    public class BackstageQualityUpdater : IncreaseQualityUpdater
    {
        public override void UpdateQuality(Item item)
        {
            item.SellIn = item.SellIn - 1;
            
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else
            {
                var increaseFactor = this.GetIncreaseFactor(item.SellIn);
                this.IncreaseQuality(item, increaseFactor);
            }
        }

        private int GetIncreaseFactor(int itemSellIn)
        {
            if (itemSellIn < 5)
            {
                return 3;
            }
            
            if (itemSellIn < 10)
            {
                return 2;
            }

            return 1;
        }
    }
}