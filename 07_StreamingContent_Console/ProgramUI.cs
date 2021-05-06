using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    public class ProgramUI
    {
        private StreamingContentRepository _contentRepo = new StreamingContentRepository();
        // Method that runs/starts the application
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        // Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                // Display our options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                // Get the user's input
                string input = Console.ReadLine();

                // Evaluate the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        // Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        // View All Content
                        DisplayAllContent();
                        break;
                    case "3":
                        // View Content By Title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        // Update Existing Content
                        UpdateExistingContent();
                        break;
                    case "5":
                        // Delete Existing Content
                        DeleteExistingContent();
                        break;
                    case "6":
                        // Exit
                        keepRunning = false;
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.Write("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Create new StreamingContent
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            // Title
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            // Description
            Console.WriteLine("Enter the description for the content");
            newContent.Description = Console.ReadLine();

            // Star Rating
            Console.WriteLine("Enter the  star rating (1.0 - 5.0) for the content:");
            string starRatingAsString = Console.ReadLine();
            newContent.StarRating = Convert.ToDouble(starRatingAsString);

            // GenreType
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horor\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance,\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt; // Turning the int (genreAsInt) into the enum type -- this is called casting

            //MaturityRating
            Console.WriteLine("Enter the number for Maturity Rating:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG 13\n" +
                "4. R\n" +
                "5. TV G\n" +
                "6. TV PG\n" +
                "7. TV 14\n" +
                "8. TV MA");
            // Now that we've prompted them, we need to get the user's input
            string maturityString = Console.ReadLine();
            int maturityInt = int.Parse(maturityString);
            newContent.MaturityRating = (MaturityRating)maturityInt;

            _contentRepo.AddContentToDirectory(newContent);
        }

        // View Current SteamingContent that is saved
        private void DisplayAllContent()
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _contentRepo.GetContents();
            foreach (StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title: {content.Title} \n" +
                    $"Description: {content.Description}\n");
            }
        }

        // View existing Content by title
        private void DisplayContentByTitle()
        {
            Console.Clear();
            // Prompts the user to give me a title
            Console.WriteLine("Enter the title of the content you would like to see:");

            // Get the user's input
            string title = Console.ReadLine();

            // Find the content by that title
            StreamingContent content = _contentRepo.GetContentByTitle(title);

            // Display said content if it isn't null
            if (content != null)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"Stars: {content.StarRating} \n" +
                    $"Genre: {content.TypeOfGenre}\n"+
                    $"Maturity Rating: {content.MaturityRating} \n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}");
            }
            else
            {
                Console.WriteLine("No content by that title");
            }
        }

        // Update Existing Content
        private void UpdateExistingContent()
        {
            // Display all content
            DisplayAllContent();

            // Ask for the title of the content to update
            Console.WriteLine("Enter the title of the content you'd like to update:");

            // Get that title
            string oldTitle = Console.ReadLine();

            // We will build a new object
            StreamingContent newContentValues = new StreamingContent();

            // Title
            Console.WriteLine("Enter the title for the content:");
            newContentValues.Title = Console.ReadLine();

            // Description
            Console.WriteLine("Enter the description for the content");
            newContentValues.Description = Console.ReadLine();

            // Star Rating
            Console.WriteLine("Enter the  star rating (1.0 - 5.0) for the content:");
            string starRatingAsString = Console.ReadLine();
            newContentValues.StarRating = Convert.ToDouble(starRatingAsString);

            // GenreType
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horor\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance,\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContentValues.TypeOfGenre = (GenreType)genreAsInt; // Turning the int (genreAsInt) into the enum type -- this is called casting

            //MaturityRating
            Console.WriteLine("Enter the number for Maturity Rating:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG 13\n" +
                "4. R\n" +
                "5. TV G\n" +
                "6. TV PG\n" +
                "7. TV 14\n" +
                "8. TV MA");
            // Now that we've prompted them, we need to get the user's input
            string maturityString = Console.ReadLine();
            int maturityInt = int.Parse(maturityString);
            newContentValues.MaturityRating = (MaturityRating)maturityInt;

            // Verify the update worked
            bool wasUpdated = _contentRepo.UpdateExistingContent(oldTitle, newContentValues);

            if (wasUpdated)
            {
                Console.WriteLine("Content successfully updated!");
            }
            else
            {
                Console.WriteLine("Could not update content");
            }
        }

        // Delete Existing Content
        private void DeleteExistingContent()
        {
            DisplayAllContent();

            // Get the title they want to remove
            Console.WriteLine("\nEnter the title of the content you'd like to remove:");

            string input = Console.ReadLine();

            // Call the delete method
            bool wasDeleted = _contentRepo.DeleteExistingContent(input);

            // If the content was deleted, say so
            // Otherwise state it could not be deleted
            if (wasDeleted)
            {
                Console.WriteLine("The content was successfully deleted.");
            }
            else
            {
                Console.WriteLine("Content could not be deleted");
            }
        }

        // Seed method
        private void SeedContentList()
        {
            StreamingContent future = new StreamingContent("Back to the Future", "A high school student named Marty is accidentally sent back in time 30 years", 4.4, GenreType.SciFi, MaturityRating.PG);
            StreamingContent godzilla = new StreamingContent("Godzilla vs. Kong", "Godzilla and King Kong don't get along", 2.1, GenreType.Action, MaturityRating.PG_13);
            StreamingContent rubber = new StreamingContent("Rubber", "Car tire comes to life and goes on a killing spree", 1.9, GenreType.Action, MaturityRating.R);

            _contentRepo.AddContentToDirectory(future);
            _contentRepo.AddContentToDirectory(godzilla);
            _contentRepo.AddContentToDirectory(rubber);
        }
    }
}
