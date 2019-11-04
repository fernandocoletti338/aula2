using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApiCalculoDensidade.Model
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options)
           : base(options)
        {

        }
        public DbSet<ObjetoCalculo> calculos { get; set; }
    }
}
