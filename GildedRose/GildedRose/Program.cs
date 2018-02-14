using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Program
    {
        private IList<Item> Items;

        private static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var app = new Program
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                    new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                }
            };

            app.UpdateQuality();

            Console.ReadKey();
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < this.Items.Count; i++)
            {
                if (this.Items[i].Name != "Aged Brie" &&
                    this.Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (this.Items[i].Quality > 0)
                    {
                        if (this.Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            this.Items[i].Quality = this.Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (this.Items[i].Quality < 50)
                    {
                        this.Items[i].Quality = this.Items[i].Quality + 1;

                        if (this.Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (this.Items[i].SellIn < 11)
                            {
                                if (this.Items[i].Quality < 50)
                                {
                                    this.Items[i].Quality = this.Items[i].Quality + 1;
                                }
                            }

                            if (this.Items[i].SellIn < 6)
                            {
                                if (this.Items[i].Quality < 50)
                                {
                                    this.Items[i].Quality = this.Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (this.Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    this.Items[i].SellIn = this.Items[i].SellIn - 1;
                }

                if (this.Items[i].SellIn < 0)
                {
                    if (this.Items[i].Name != "Aged Brie")
                    {
                        if (this.Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (this.Items[i].Quality > 0)
                            {
                                if (this.Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    this.Items[i].Quality = this.Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            this.Items[i].Quality = this.Items[i].Quality - this.Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (this.Items[i].Quality < 50)
                        {
                            this.Items[i].Quality = this.Items[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }
}