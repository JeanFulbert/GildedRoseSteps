using System.Collections.Generic;
using System.Linq.Expressions;
using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    [TestFixture]
    public class ConjuredQuality
    {
        private readonly QualityUpdater qualityUpdater = new QualityUpdater();

        [Test]
        public void ConjuredQualityDecreaseTwiceFastWhenSellNotPassed()
        {
            Item myItem = new Item { Name ="Conjured", SellIn = 10, Quality = 20 };

            this.qualityUpdater.UpdateQuality(new List<Item> { myItem });

            Assert.That(myItem.Quality, Is.EqualTo(18));
        }

        [Test]
        public void ConjuredQualityDecreaseTwiceOnceSellPassedQualityDegradeTwice()
        {
            Item myItem = new Item { Name ="Conjured", SellIn = 0, Quality = 20 };

            this.qualityUpdater.UpdateQuality(new List<Item> { myItem });

            Assert.That(myItem.Quality, Is.EqualTo(16));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void ConjuredQualityDoesntDecreseFrom0(int initialQuality)
        {
            Item myItem = new Item { Name ="Conjured", SellIn = 10, Quality = initialQuality };

            this.qualityUpdater.UpdateQuality(new List<Item> { myItem });

            Assert.That(myItem.Quality, Is.EqualTo(initialQuality));
        }
    }
}
