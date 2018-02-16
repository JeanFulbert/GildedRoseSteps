namespace GildedRose.QualityUpdaters
{
    public class BackstageQualityUpdater : IncreaseQualityUpdater
    {
        public override void UpdateQuality(Item item)
        {
            this.IncreaseQuality(item);
            
            if (item.SellIn < 11)
            {
                this.IncreaseQuality(item);
            }

            if (item.SellIn < 6)
            {
                this.IncreaseQuality(item);
            }

            item.SellIn = item.SellIn - 1;


            if (item.SellIn < 0)
            {
                item.Quality = item.Quality - item.Quality;
            }
        }
    }
}