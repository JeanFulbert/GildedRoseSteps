using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class BackstagePassQuality
    {
        private readonly QualityUpdater qualityUpdater = new QualityUpdater();

        [TestCase(11)]
        [TestCase(20)]
        public void BackstagePassQualityIncrease(int initialSellIn)
        {
            Item myItem = new Item { Name = QualityUpdater.Backstage, SellIn = initialSellIn, Quality = 20 };

            this.qualityUpdater.UpdateQuality(new List<Item> { myItem });

            Assert.That(myItem.Quality, Is.EqualTo(21));
        }

      
        [TestCase(10)]
        [TestCase(9)]
        [TestCase(8)]
        [TestCase(7)]
        [TestCase(6)]
        public void BackstagePassQualityIncreaseTwiceAsFast_When10DaysToTheSellIn(int initialSellIn)
        {
            Item myItem = new Item { Name =  QualityUpdater.Backstage, SellIn = initialSellIn, Quality = 20 };

            this.qualityUpdater.UpdateQuality(new List<Item> { myItem });

            Assert.That(myItem.Quality, Is.EqualTo(22));
        }

        [TestCase(5)]
        [TestCase(4)]
        [TestCase(3)]
        [TestCase(2)]
        [TestCase(1)]
        public void BackstagePassQualityIncreaseBy3AsFast_When5DaysToTheSellIn(int initialSellIn)
        {
            Item myItem = new Item { Name =  QualityUpdater.Backstage, SellIn = initialSellIn, Quality = 20 };

            this.qualityUpdater.UpdateQuality(new List<Item> { myItem });

            Assert.That(myItem.Quality, Is.EqualTo(23));
        }

        [Test]
        public void BackstagePassQualitySetTo0WhenSellInPassed()
        {
            Item myItem = new Item { Name =  QualityUpdater.Backstage, SellIn = 0, Quality = 20 };

            this.qualityUpdater.UpdateQuality(new List<Item> { myItem });

            Assert.That(myItem.Quality, Is.EqualTo(0));
        }
    }
}
