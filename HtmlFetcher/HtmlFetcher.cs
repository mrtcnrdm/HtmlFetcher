namespace HtmlFetcher
{
    public class HtmlFetcher : IDisposable
    {
        private readonly HttpClient client;

        public HtmlFetcher()
        {
            client = new HttpClient();
        }

        public async Task<string> FetchHtml(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode(); // Hata durumunda istisna fırlatır
            return await response.Content.ReadAsStringAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                client.Dispose(); // HttpClient nesnesini temizle
            }
        }
    }
}
