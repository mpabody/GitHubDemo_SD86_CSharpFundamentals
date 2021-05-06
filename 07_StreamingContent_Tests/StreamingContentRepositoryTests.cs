using _07_StreamingContent_Repository;
using _07_StreamingContent_Repository.Conetnt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            // Arrange --> Setting up the playing field
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            // Act --> Get/run the code we want to test
            bool addResult = repository.AddContentToDirectory(content);

            // Assert --> Use the Assert class to verify the expected outcome
            // For our Assert let's use a new method we haven't seen before
            Assert.IsTrue(addResult);
        }

        // Testing the Read method (GET)
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            // Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            repo.AddContentToDirectory(content);

            // Act
            List<StreamingContent> contents = repo.GetContents();

            // Now that we've been given a list. Also, we know our Add works. What does this mean?
            // We can check to see if the list contains the content we added above
            // If we look at our List class (using . (dot) notiation we can see there's a Contains method we can call)
            bool directoryHasContent = contents.Contains(content);

            // How do we know this method exists? Well I know because I've seen it before.
            // Best way to learn is by looking through resources (Google/Intellisense)

            // Assert
            Assert.IsTrue(directoryHasContent);
        }

        private StreamingContentRepository _repo;
        private StreamingContent _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Back to the Future", "A high school student named Marty is accidentally sent back in time 30 years", 4.4, GenreType.Action, MaturityRating.PG);

            _repo.AddContentToDirectory(_content);
        }

        // Testing the GetByTitle method
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            // Arrange
            // This will be replaced with the [TestInitialize] method now

            // Act
            StreamingContent searchResult = _repo.GetContentByTitle("Back to the Future");

            // Assert
            // We can now compare the reference that was returned with the _content field that was added to the 
            Assert.AreEqual(_content, searchResult);
        }

        // With these additions, we can see how our tests will also start to slim down
        // This is the goal with most of our code, basically from here on

        // Test the UpdateExistingContent
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContent newContent = new StreamingContent("Back to the Future", "A high school student named Marty is accidentally sent back in time 30 years", 4.4, GenreType.Action, MaturityRating.PG);

            // Act
            bool updateResult = _repo.UpdateExistingContent("Back to the Future", newContent);

            // Assert
            Assert.IsTrue(updateResult);
        }

        // Test the Delete method
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContent content = _repo.GetContentByTitle("Back to the Future");

            // Act
            bool removeResult = _repo.DeleteExistingContent(content.Title);

            // Assert
            Assert.IsTrue(removeResult);
        }


        [TestMethod]
        public void TestingInheritance()
        {
            List<Object> listOfObjects = new List<Object>();
            StreamingContent content = new StreamingContent("title", "descripion", 4, GenreType.Action, MaturityRating.G);
            Movie movie = new Movie("movie title", "movie description", 3, GenreType.Bromance, MaturityRating.R, 56.5);

            listOfObjects.Add(movie);
            listOfObjects.Add(content);
        }
    }
}
