using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public class NormalItemQuality
    {
        private readonly QualityUpdater qualityUpdater = new QualityUpdater();

        [Test]
        public void ShouldDegradeQualityWhenSellNotPassed()
        {
            Item myItem = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };

            this.qualityUpdater.UpdateQuality(new List<Item> { myItem });
            
            Assert.That(myItem.Quality, Is.EqualTo(19));
        }

        [Test]
        public void ShouldDegradeQualityTwiceWhenSellPassed()
        {
            Item myItem = new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20 };

            this.qualityUpdater.UpdateQuality(new List<Item> { myItem });

            Assert.That(myItem.Quality, Is.EqualTo(18));
        }
        
        [TestCase(0)]
        [TestCase(-1)]
        public void ShouldNotDecreseFrom0(int initialQuality)
        {
            Item myItem = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = initialQuality };

            this.qualityUpdater.UpdateQuality(new List<Item> { myItem });

            Assert.That(myItem.Quality, Is.EqualTo(initialQuality));
        }
    }
}
