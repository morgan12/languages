using Languages.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Languages.DataModel
{
    public class LanguagesContext:DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Translations> Translations { get; set; }
        public DbSet<UserLanguage> UserLanguage { get; set; }
    }
}
