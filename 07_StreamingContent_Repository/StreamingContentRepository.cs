using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository
    {
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //Explain CRUD
        //Start with void but refactor to bool
        public bool AddContentToDirectory(StreamingContent content)
        {
            // Add this when you start refactoring the basic method
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);
            
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        // At this point we can head over and create a RepositoryTests file
        // Once that gets set up, we can have the students test the AddContentToDirectory method we just created

        // Next we'll add the first Read method, to get the list
        public List<StreamingContent> GetContents()
        {
            // Here we're passing the reference to the _contentDirectory
            // You may want to talk about references on Stack/Heap if that helps visualize the difference
            return _contentDirectory;

            // Again you can now go and test the method
        }

        // When thinking through CRUD, we might have multiple methods for each action
        // Let's also build us a method where we can get a single StreamingContent by its title
        // You may offer for the students to spend a few minutes attempting this before going over it
        public StreamingContent GetContentByTitle(string title)
        {
            // Alright so we want a specific StreamingContent from the List that we have
            // So what we need to do is check each item in the list and see if the title matches
            // How do we execute some code for each item in a collection? What have we seen that does that?

            // We can write a foreach loop that will iterate through each item and return it if it finds an item
            foreach (StreamingContent content in _contentDirectory)
            {
                // We now can check each one to see IF the title matches
                // After writing this out, we can also show them how adding a way to ignore case
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }

            // If we foreach through the entire collection and don't find a match, we won't have returned anything
            // That's why we still have an error on the method signature right now
            // Let's just return a null reference for now if we don't find the correct match
            return null; //-- This is NOT best practice, but we don't want to write a lot of exceptions right now
        }

        // Update can be a tricky one because there are a couple ways to handle it
        // We're going to show a way to update an object without adjusting the actual reference
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            // Find the content using our other method we wrote
            // Notice we're calling a method but not using . (dot) notation. How does this work?
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            // Update the content if it exists
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;

                return true;
            }
            else
            {
                return false;
            }
        }

        // Delete => Remove existing content form the List
        public bool DeleteExistingContent(string titleToDelete)
        {
            StreamingContent contentToDelete = GetContentByTitle(titleToDelete);
            if (contentToDelete == null)
            {
                return false;
            }
            else
            {
                _contentDirectory.Remove(contentToDelete);
                return true;
            }
        }
    }
}
