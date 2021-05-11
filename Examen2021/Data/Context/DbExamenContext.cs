using Data.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class DbExamenContext : DbContext
    {
        public DbSet<Persoon> Personen { get; set; }
        //todo: insert connectionstring

    }
}
