using (var htmlFetcher = new HtmlFetcher.HtmlFetcher())
{
    await Console.Out.WriteLineAsync("Url giriniz: ");
    string? url = Console.ReadLine();

    if (string.IsNullOrEmpty(url))
    {
        url = "https://www.google.com";
    }

    string html = await htmlFetcher.FetchHtml(url);
    Console.WriteLine(html);
}