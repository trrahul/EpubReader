﻿namespace VersOne.Epub.Test.Unit.Entities
{
    public class EpubNavigationItemTests
    {
        [Fact(DisplayName = "ToString method should produce a string with the type, the title, and the number of nested items")]
        public void ToStringTest()
        {
            EpubNavigationItem epubNavigationItem = new()
            {
                Type = EpubNavigationItemType.HEADER,
                Title = "Chapter 1",
                NestedItems = new List<EpubNavigationItem>
                {
                    new EpubNavigationItem()
                }
            };
            Assert.Equal("Type: HEADER, Title: Chapter 1, NestedItems.Count: 1", epubNavigationItem.ToString());
        }
    }
}
