using Languages.Classes;
using Languages.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LanguagesContext())
            {
                var languageHello = new Translations
                {
                    GermanWord = "hallo",
                    SpanishWord = "hola",
                    ItalianWord = "ciao",
                    EnglishWord = "hello",
                };
                var languageMorning = new Translations
                {
                    GermanWord = "morgen",
                    SpanishWord = "manana",
                    ItalianWord = "mattina",
                    EnglishWord = "morning"
                };
                var languageCat = new Translations
                {
                    GermanWord = "katze",
                    SpanishWord = "gato",
                    ItalianWord = "gatto",
                    EnglishWord = "cat"
                };
                var languageDog = new Translations
                {
                    GermanWord = "hund",
                    SpanishWord = "perro",
                    ItalianWord = "cane",
                    EnglishWord = "dog"
                };
                var UserChris = new Users
                {
                    UserName = "Chris",
                    Location = "Louisville"
                };
                var UserMorgan = new Users
                {
                    UserName = "Morgan",
                    Location = "Nashville"
                };
                var UserChristian = new Users
                {
                    UserName = "Christian",
                    Location = "Nashville"
                };

                var UserBrooklyn = new Users
                {
                    UserName = "Brooklyn",
                    Location = "Shepherdsville"
                };
                var GermanMorgan = new UserLanguage
                {
                    LanguageChoice = LanguageId.German
                };
                var SpanishMorgan = new UserLanguage
                {
                    LanguageChoice = LanguageId.Spanish
                };
                var GermanChris = new UserLanguage
                {
                    LanguageChoice = LanguageId.German
                };
                var ItalianChris = new UserLanguage
                {
                    LanguageChoice = LanguageId.Italian
                };
                UserMorgan.LanguageIds.Add(GermanMorgan);
                UserMorgan.LanguageIds.Add(SpanishMorgan);
                UserChris.LanguageIds.Add(GermanChris);
                UserChris.LanguageIds.Add(ItalianChris);
                context.Translations.AddRange(new List<Translations> { languageHello, languageMorning, languageCat, languageDog});
                context.Users.AddRange(new List<Users> { UserChris, UserMorgan, UserBrooklyn });
                context.SaveChanges();
            }
        }
    }
}
