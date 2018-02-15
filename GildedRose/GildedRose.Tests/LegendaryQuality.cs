using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class LegendaryQuality
    {
        private readonly QualityUpdater qualityUpdater = new QualityUpdater();

        [Test]
        public void ShouldNotAlterQualityNorSellIn()
        {
            Item myItem = new Item { Name =  QualityUpdater.Sulfuras, SellIn = 0, Quality = 80 };

            this.qualityUpdater.UpdateQuality(new List<Item> { myItem });

            Assert.That(myItem.Quality, Is.EqualTo(80));
            Assert.That(myItem.SellIn, Is.EqualTo(0));
        }
    }
}
