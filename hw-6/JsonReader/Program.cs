using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonReader
{
    public class PublishingHouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public PublishingHouse(int id, string name, string adress)
        {
            Id = id;
            Name = name;
            Adress = adress;
        }

        public override string ToString()
        {
            return "Publishing house Id (PublishingHouse field): " + Id + "\n" + "Publishing house name: " + Name + "\n" + "Publishing house adress: " + Adress + "\n";
        }
    }

    public class Book
    {
        [JsonIgnore]
        public int PublishingHouseId { get; set; }
        [JsonPropertyName("Name")]
        public string Title { get; set; }
        public PublishingHouse PublishingHouse { get; set; }

        public Book(int publishingHouseId, string title, PublishingHouse publishingHouse)
        {
            PublishingHouseId = publishingHouseId;
            Title = title;
            PublishingHouse = publishingHouse;
        }

        public override string ToString()
        {
            return "PublishingHouse Id (Book field): " + PublishingHouseId + "\n" + "Title: " + Title + "\n" + PublishingHouse.ToString();
        }
    }

    class Program
    {
        public static async Task Main(string[] args)
        {
            List<Book> books = new List<Book>();

            string path = @"D:\hw6.json";
            using (FileStream fstream = new FileStream(path, FileMode.Open))
            {
                books = await JsonSerializer.DeserializeAsync<List<Book>>(fstream);
            }

            foreach (Book book in books)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Out.WriteLine(book);
            }

            path = @"D:\testwrite.json";
            books.Clear();
            books.Add(new Book(1, "Kobzar", new PublishingHouse(1, "Old lion publisher", "Lviv")));
            books.Add(new Book(2, "Harry Potter", new PublishingHouse(1, "Abababalamaga", "Kyiv")));
            books.Add(new Book(2, "1984", new PublishingHouse(1, "Abababalamaga", "Kyiv")));

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            using (FileStream fstream = new FileStream(path, FileMode.Create))
            {
                await JsonSerializer.SerializeAsync(fstream, books, options);
            }
            Console.Out.WriteLine("File was created");
        }
    }
}