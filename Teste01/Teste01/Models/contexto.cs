using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Teste01.Models
{
    public class contexto : DbContext
    {
        public DbSet<pessoa> Pessoa { get; set; }
    }
}