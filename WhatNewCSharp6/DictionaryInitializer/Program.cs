namespace DictionaryInitializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> englishDictionaries = new Dictionary<string, string>()
            {
                ["hate"] = "ghet",
                ["love"] = "yeu",
                ["like"] = "thich",
                ["sad"] = "buon",
            };

            englishDictionaries["happy"] = "vui";
            englishDictionaries.Add("beautiful", "dep");

            foreach (var item in englishDictionaries)
            {
                Console.WriteLine(String.Format("{0} - {1}", item.Key, item.Value));
            }
            Console.ReadLine();
        }
    }
}