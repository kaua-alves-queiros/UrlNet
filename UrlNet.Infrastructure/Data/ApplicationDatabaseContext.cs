using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlNet.Infrastructure.Data
{
    public class ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : DbContext (options)
    {
    }
}
