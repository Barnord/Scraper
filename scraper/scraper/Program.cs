using scraper.Core;

namespace scraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Enter();
        }
        static async Task Enter()
        {
            Console.WriteLine("Please enter an address");
            string ?address = Console.ReadLine();

            try
            {
                Console.WriteLine(await ScraperHtml.HttpRequestAsync(address));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
