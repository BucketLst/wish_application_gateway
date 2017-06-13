using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ProcessRepositories().Wait();
        }

        private static async Task ProcessRepositories()
        {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

        var stringTask = client.GetStringAsync("http://localhost:5050/api/wishlist/getallwishes");

        var msg = await stringTask;
        Console.Write(msg);
        }
    }
}
