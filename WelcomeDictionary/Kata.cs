using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeDictionary
{
    public  class Kata
    {
        public static string Greet(string language)
        {
            
            Dictionary<string, string> ipAdress = new Dictionary<string, string>()
            {
                {"english", "Welcome"},
                {"czech", "Vitejte"},
                {"danish", "Velkomst"},
                {"dutch", "Welkom"},
                {"estonian", "Tere tulemast"},
                {"finnish", "Tervetuloa"},
                {"flemish", "Welgekomen"},
                {"french", "Bienvenue"},
                {"german", "Willkommen"},
                {"irish", "Failte"},
                {"italian", "Benvenuto"},
                {"latvian", "Gaidits"},
                {"lithuanian", "Laukiamas"},
                {"polish", "Witamy"},
                {"spanish", "Bienvenido"},
                {"swedish", "Valkommen"},
                {"welsh", "Croeso"}
            };
            if (ipAdress.TryGetValue(language, out var returnedValue))
            {
                return returnedValue;
            }
            else return "Welcome";
        }
    }
}
