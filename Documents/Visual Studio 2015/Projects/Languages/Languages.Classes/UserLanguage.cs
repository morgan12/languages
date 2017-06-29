using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Languages.Classes
{
    public class UserLanguage
    {
        public int Id { get; set; }
        public Users Users { get; set; }
        public LanguageId LanguageChoice{ get; set; }
    }
}
