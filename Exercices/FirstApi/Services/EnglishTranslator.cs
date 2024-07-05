namespace FirstApi.Services
{
    public class EnglishTranslator : ITranslator
    {
        public string Translate(string word)
        {
            word = word.ToLower();

            if (word == "bonjour")
                return "hello";
            else if (word == "aurevoir")
                return "bye";
            else if (word == "merci")
                return "thanks";
            else
                return "le mot n'est pas reconnu";
        }
    }
}
