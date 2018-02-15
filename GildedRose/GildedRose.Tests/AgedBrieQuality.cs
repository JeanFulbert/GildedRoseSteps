using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class AgedBrieQuality
    {
        private const string AgedBrieName = "Aged Brie";
        
        private readonly QualityUpdater qualityUpdater = new QualityUpdater();

        [Test]
        public void ShouldIncrease()
        {
            Item myItem = new Item {Name = AgedBrieName, SellIn = 10, Quality = 20};

            this.qualityUpdater.UpdateQuality(new List<Item> {myItem});

            Assert.That(myItem.Quality, Is.EqualTo(21));
        }

        [Test]
        public void ShouldNeverExceed50()
        {
            Item myItem = new Item {Name = AgedBrieName, SellIn = 10, Quality = 50};

            this.qualityUpdater.UpdateQuality(new List<Item> {myItem});

            Assert.That(myItem.Quality, Is.EqualTo(50));
        }
    }
}
