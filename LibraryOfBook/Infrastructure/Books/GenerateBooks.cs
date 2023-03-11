using Bogus;
using Domain.Core.Classes;
using Newtonsoft.Json;

namespace Infrastructure.Books
{
    public class GenerateBooks
    {
        public static void Run()
        {
            List<string> bookNames = new List<string>()
            {
                "The Hidden Garden",
                "The Lost Labyrinth",
                "The Crimson Crown",
                "The Midnight Circus",
                "The Enchanted Forest",
                "The Raven's Prophecy",
                "The Forgotten Kingdom",
                "The Cursed Ruby",
                "The Ghostly Bride",
                "The Sapphire Storm",
                "The Secret Society",
                "The Emerald Isle",
                "The Witch's Curse",
                "The Dark Tower",
                "The Shadow Queen",
                "The Mystic Oracle",
                "The Sunken City",
                "The Pirate's Treasure",
                "The Dragon's Lair",
                "The Time Traveler's Wife",
                "The Hunger Games",
                "To Kill a Mockingbird",
                "The Catcher in the Rye",
                "1984",
                "The Great Gatsby",
                "One Hundred Years of Solitude",
                "Pride and Prejudice",
                "The Lord of the Rings",
                "The Hobbit",
                "The Chronicles of Narnia",
                "Harry Potter and the Philosopher's Stone",
                "Harry Potter and the Chamber of Secrets",
                "Harry Potter and the Prisoner of Azkaban",
                "Harry Potter and the Goblet of Fire",
                "Harry Potter and the Order of Phoenix",
                "Harry Potter and the Half-Blood Prince",
                "Harry Potter and the Deathly Hallows",
                "The Da Vinci Code",
                "Angels and Demons",
                "Inferno",
                "The Lost Symbol",
                "The Girl with the Dragon Tattoo",
                "The Girl Who Played with Fire",
                "The Girl Who Kicked the Hornet's Nest",
                "Gone Girl",
                "The Girl on the Train",
                "The Silent Patient",
                "The Hunger Games: Catching Fire",
                "The Hunger Games: Mockingjay",
                "The Maze Runner",
                "The Scorch Trials",
                "The Death Cure",
                "The Fault in Our Stars",
                "Looking for Alaska",
                "Paper Towns",
                "An Abundance of Katherines",
                "The Alchemist",
                "Brida",
                "Veronika Decides to Die",
                "The Devil Wears Prada",
                "The Nanny Diaries",
                "Confessions of a Shopaholic",
                "The Help",
                "The Immortal Life of Henrietta Lacks",
                "The Kite Runner",
                "A Thousand Splendid Suns",
                "And the Mountains Echoed",
                "The Book Thief",
                "Life of Pi",
                "The Road",
                "The Catcher Was a Spy",
                "The Shadow of the Wind",
                "The Name of the Wind",
                "The Wise Man's Fear",
                "A Game of Thrones",
                "A Clash of Kings",
                "A Storm of Swords",
                "A Feast for Crows",
                "A Dance with Dragons",
                "The Winds of Winter",
                "A Dream of Spring",
                "The Stand",
                "It",
                "The Shining",
                "Pet Sematary",
                "Salem's Lot",
                "Misery",
                "Carrie",
                "Doctor Sleep",
                "The Tommyknockers",
                "The Dark Half",
                "Needful Things"
            };
            List<Book> booksForJson = new();
            Faker faker = new();
            for (int i = 0; i < bookNames.Count; i++)
            {
                Book books = new()
                {
                    Author = faker.Name.FullName(),
                    Title = bookNames[i],
                    Id = i + 1
                };
                booksForJson.Add(books);

            }
            string path = @"D:\ForGitHub\LibraryOfBook\Infrastructure\Books\books.json";

            string json = JsonConvert.SerializeObject(booksForJson, Formatting.Indented);
            File.WriteAllText(path, json);

        }
    }
}
