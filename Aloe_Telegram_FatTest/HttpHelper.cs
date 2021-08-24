using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Aloe_Telegram_FatTest
{
    public class HttpHelper
    {
            static async Task Main(string[] args)
            {
                using var client = new HttpClient();

                var result = await client.GetAsync("http://webcode.me");
                Console.WriteLine(result.StatusCode);
            }
        
    }
}

