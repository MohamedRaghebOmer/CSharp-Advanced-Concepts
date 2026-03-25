using System;
using System.Net;
using System.Threading.Tasks;

static class WebPagesDownloader_SemiProject
{
    public delegate void CallBackEventHandler(PageLoadedEventArgs e);
    public static event CallBackEventHandler PageLoaded;

    public class PageLoadedEventArgs : EventArgs
    {
        public string Content { get; set; }
        public int ContentLength { get; set; }
        public string URL { get; set; }

        public PageLoadedEventArgs(string content, int contentLength, string url)
        {
            this.Content = content;
            this.ContentLength = contentLength;
            this.URL = url;
        }
    }

    static async Task Main(string[] args)
    {
        bool again = true;

        while (again)
        {
            Console.Clear();

            Task task = DownloadAndPrintAsync(ReadValidUrl(), PrintPageContent);

            // Simulate working
            Console.WriteLine("\nLoading Page content...");
            await Task.Delay(750);
            Console.WriteLine("About to finish...\n");

            await task;

            Console.WriteLine("\nDo you want to load another page [Y|N]? ");
            again = string.Equals(Console.ReadLine(), "y", StringComparison.OrdinalIgnoreCase);
        }
    }

    static string ReadValidUrl()
    {
        string url = string.Empty;

        Console.Write("Write the page URL to download it: ");
        url = Console.ReadLine();

        while (!IsValidUrl(url))
        {
            Console.Write("Invalid URL; Enter a valid one: ");
            url = Console.ReadLine();
        }

        return url;
    }

    static bool IsValidUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
            return false;

        return Uri.TryCreate(url, UriKind.Absolute, out Uri result)
               && (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);
    }

    static async Task DownloadAndPrintAsync(string url, CallBackEventHandler printMethod)
    {
        string content = string.Empty;

        using (var client = new WebClient())
        {
            // Add browser-like headers; many servers block requests with no/empty User-Agent
            client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64)";
            client.Headers[HttpRequestHeader.Accept] = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";

            await Task.Delay(1500); // Simulate some work

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

        printMethod?.Invoke(new PageLoadedEventArgs(content, content.Length, url));
    }

    static void PrintPageContent(PageLoadedEventArgs pageLoadedEventArgs)
    {
        Console.WriteLine($"Web URL: {pageLoadedEventArgs.URL}");
        Console.WriteLine($"Content Length: {pageLoadedEventArgs.ContentLength}");
        //Console.WriteLine($"Content: {pageLoadedEventArgs.Content}");
    }
}

