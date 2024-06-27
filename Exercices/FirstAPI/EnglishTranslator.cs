using FirstAPI.Services;
using System.Collections;

namespace FirstAPI
{
    public class EnglishTranslator : ITranslator
    {
        public string Translate(string word)
        {
            word = word.ToLower();

            if (word == "bonjour")
            {
                return "hello";
            }
            else if (word == "aurevoir")
            {
                return "bye";
            }
            else if (word == "merci")
            {
                return "thanks";
            }
            else
            {
                return "Mot non reconnu";
            }

        }
    }
}
