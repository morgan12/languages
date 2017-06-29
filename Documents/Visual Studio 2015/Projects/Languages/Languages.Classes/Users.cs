using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Languages.Classes
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Location { get; set; }
        public List<UserLanguage> LanguageIds { get; set; }
        public Users()
        {
            LanguageIds = new List<UserLanguage>();
        }
    }
}
