using apivehiculos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apivehiculos.Context
{
    public class AppDbContext :DbContext
    {
        public AppDbContext( DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Vehiculos_Bd> vehiculos { get; set; }
    }
}
