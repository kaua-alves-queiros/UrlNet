using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlNet.Domain.Aggregations
{
    public class ShortenedUrl
    {
        public Guid Id { get; set; }
        public string OriginalUrl { get; set; }
        public string ShortCode { get; set; }
        public int RedirectCount { get; set; }
        public DateTime CreatedAt { get; set; }

        public ShortenedUrl(string originalUrl, string shortCode)
        {
            Id = Guid.NewGuid();
            OriginalUrl = originalUrl;
            ShortCode = shortCode;
            RedirectCount = 0;
            CreatedAt = DateTime.UtcNow;
        }

        public void ChangeOriginalUrl(string newUrl)
        {
            OriginalUrl = newUrl;
        }

        public void IncrementRedirectCount()
        {
            RedirectCount++;
        }

        ShortenedUrl () { }
    }
}
