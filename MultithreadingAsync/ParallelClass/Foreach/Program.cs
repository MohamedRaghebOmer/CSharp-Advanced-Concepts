using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

static class For
{
    static readonly List<string> urls = new List<string>
    {
        "https://www.cnn.com",
        "https://www.programmingadvices.com",
        "https://www.amazon.com"
    };

    static void Main(string[] args)
    {
        Parallel.ForEach(urls, url => DownloadContent(url));
        Console.WriteLine("Done!");
    }

    static async Task DownloadContent(string url)
    {
        string content = string.Empty;

        using (var client = new WebClient())
        {
            // Add browser-like headers; many servers block requests with no/empty User-Agent
            client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64)";
            client.Headers[HttpRequestHeader.Accept] = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";

            try
            {
                content = client.DownloadString(url);
            }
            catch (WebException ex)
            {
                Console.WriteLine($"{url}: request failed: {ex.Message}");
                if (ex.Response is HttpWebResponse resp)
                {
                    Console.WriteLine($"HTTP {(int)resp.StatusCode} {resp.StatusDescription}");
                }
                return;
            }

            Console.WriteLine($"{url}: content length: {content.Length}");
        }

    }
}

