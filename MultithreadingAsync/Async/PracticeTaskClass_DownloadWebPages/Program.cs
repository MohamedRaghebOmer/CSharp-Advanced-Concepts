using System;
using System.Net;
using System.Threading.Tasks;

static class PracticeTaskClass_DownloadWebPages
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting tasks...");

        Task task1 = DownloadAndPrintAsync("https://www.cnn.com");
        Console.WriteLine("Task1 started...");

        Task task2 = DownloadAndPrintAsync("https://programmingadvices.com");
        Console.WriteLine("Task2 started...");

        Task task3 = DownloadAndPrintAsync("https://www.amazon.com");
        Console.WriteLine("Task3 started...");

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("\nDone all tasks.");
    }

    static async Task DownloadAndPrintAsync(string url)
    {
        string content = string.Empty;

        using (var client = new WebClient())
        {
            // Add browser-like headers; many servers block requests with no/empty User-Agent
            client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64)";
            client.Headers[HttpRequestHeader.Accept] = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";

            await Task.Delay(500); // Simulate some work

            try
            {
                content = await client.DownloadStringTaskAsync(url);
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
        }

        Console.WriteLine($"{url}: {content.Length} character downloaded.");
    }
}

