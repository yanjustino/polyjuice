using System;
using NUnit.Framework;
using Polyjuice.Potions;
using Polyjuice.Tests.Models;
using static Polyjuice.Tests.TestHelper;


namespace Polyjuice.Tests.Potions
{
    public class LoremTest
    {
        [Test]
        public void TestLorem()
        {
            Match("\\w", Lorem.Word());
            Match(@"(\w*){3}",  string.Join(" ", Lorem.Words()));
            Match("\\w{3}", Lorem.Characters(3));
            Match(@"(\w*)", Lorem.Sentence(3));
            Match(@"(\w*)",  string.Join(" ", Lorem.Sentences()));
            Match(@"(\w*)", Lorem.Paragraph(3));
            Match(@"(\w*)",  string.Join(" ", Lorem.Paragraphs()));
        }
        
    }
}