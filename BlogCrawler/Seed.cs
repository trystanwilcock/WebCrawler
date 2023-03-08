using System.IO;

namespace BlogCrawler
{
    class Seed
    {
        /// <summary>
        /// Returns all seed URLs.
        /// </summary>
        public string[] Items
        {
            get => File.ReadAllLines(path);
        }

        private readonly string path;

        public Seed(string path)
        {
            this.path = path;

            string[] seedURLs = new string[]
            {
                "https://trystanwilcock.com/2021/03/31/how-to-build-a-book-barcode-scanner-in-blazor/"
            };

            using StreamWriter file = File.CreateText(path);

            foreach (string url in seedURLs)
                file.WriteLine(url.ToCleanURL());
        }
    }
}