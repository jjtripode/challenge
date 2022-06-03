using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace nubimetricsApiCurrency.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
