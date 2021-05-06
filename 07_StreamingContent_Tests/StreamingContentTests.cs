using _07_StreamingContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            StreamingContent content = new StreamingContent();

            content.Title = "Back to the Future";
            string expected = "Back to the Future";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.PG, true)]
        [DataRow(MaturityRating.PG_13, false)]
        [DataRow(MaturityRating.R, false)]
        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendly(MaturityRating rating, bool expectedFamilyFriendly)
        {
            StreamingContent newContent = new StreamingContent("Back To The Future", "A high school student named Marty is accidentally sent back in time 30 years", 4.4, GenreType.Action, rating);

            bool actual = newContent.IsFamilyFriendly;
            bool expected = expectedFamilyFriendly;
            Assert.AreEqual(actual, expected);


            //longer way below

            //StreamingContent content = new StreamingContent();
            //content.MaturityRating = MaturityRating.PG;

            //Assert.IsTrue(content.IsFamilyFriendly);
        }
    }
}
