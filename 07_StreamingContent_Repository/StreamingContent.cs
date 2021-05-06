using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public enum MaturityRating
    {
        G = 1,
        PG,
        PG_13,
        R,
        TV_G,
        TV_PG,
        TV_14,
        TV_MA
    }

    public enum GenreType
    {
        // We're setting the Horror to 1 for two reasons
        // One is to show the students we can change the value
        // Two is that later on we'll be casting off user input, so I recommend we do this or refactor later
        Horror,
        RomCom,
        SciFi,
        Documentary,
        Bromance,
        Drama,
        Action
    }

    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public GenreType TypeOfGenre { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                // We're checking against a lot of types, so we can use the a switch case to check that
                // For this, we can use the 'sw' code snippet:
                // Type 'sw' and hit tab twice, type the name of your MaturityRating property and hit enter
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_G:
                    case MaturityRating.TV_PG:
                        return true;
                    case MaturityRating.PG_13:
                    case MaturityRating.R:
                    case MaturityRating.TV_14:
                    case MaturityRating.TV_MA:
                    default:
                        return false;
                }

                // Another way to write this would be if we created a range in our enum itself, by ordering the enum values
                // This if ( > 4) is based off of the order shown above, would have to refactor the MaturityRating enum as well
                if ((int)MaturityRating > 4) // We also can show off casting here
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        
        public StreamingContent() { }

        public StreamingContent(string title, string description, double starRating, GenreType typeOfGenre, MaturityRating maturityRating)
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            TypeOfGenre = typeOfGenre;
            MaturityRating = maturityRating;
        }
    }
}
