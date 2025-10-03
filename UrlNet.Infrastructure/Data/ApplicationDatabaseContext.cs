using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlNet.Domain.Aggregations;

namespace UrlNet.Infrastructure.Data
{
    public class ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : DbContext (options)
    {
        public DbSet<ShortenedUrl> ShortenedUrls => default!;
    }
}
