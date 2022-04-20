using Newtonsoft.Json;
using Syllafind.Service.Models;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace Syllafind.Service
{
    public class WordFinderAlgorithm
    {
        public List<string> FindWords(WordFilter filter)
        {
            string jsonWords = File.ReadAllText("D:\\Programs\\Syllafind\\Syllafind.Service\\words_dictionary.json");

            HashSet<string> words = JsonConvert.DeserializeObject<Dictionary<string, int>>(jsonWords)
                .Select(x => x.Key)
                .ToHashSet()
                .Where(x => x.Length == filter.Length)
                .ToHashSet();

            StringBuilder sb = new StringBuilder();
            string regex = $@"^\w{{{ filter.Length }}}$";

            if (!string.IsNullOrEmpty(filter.StartsWith))
            {
                words = words.Where(x => x.StartsWith(filter.StartsWith)).ToHashSet();
            }

            if (!string.IsNullOrEmpty(filter.EndsWith))
            {
                words = words.Where(x => x.EndsWith(filter.EndsWith)).ToHashSet();
            }

            var rx = new Regex(regex, RegexOptions.Multiline);
            var wordsInText = string.Join("\n", words);
            var matches = rx.Matches(wordsInText);

            // Contains
            foreach (var character in filter.ContainsCharacters)
            {
                words = words.Where(word => word.Contains(char.Parse(character))).ToHashSet();
            }

            // Does not contains characters
            if (filter.DoesNotContainsCharacters.Count > 0)
            {
                foreach (var character in filter.DoesNotContainsCharacters)
                {
                    words = words.Where(word => !word.Contains(char.Parse(character))).ToHashSet();
                }
            }

            // Has
            if (filter.ContainCharactersAtPositions.Count > 0)
            {
                foreach (var symbol in filter.ContainCharactersAtPositions)
                {
                    words = words.Where(word => word[symbol.Position - 1] == symbol.Symbol).ToHashSet();
                }
            }

            // Does not
            if(filter.DoesNotContainCharactersAtPositions.Count > 0)
            {
                foreach (var symbol in filter.DoesNotContainCharactersAtPositions)
                {
                    words = words.Where(word => word[symbol.Position - 1] != symbol.Symbol).ToHashSet();
                }
            }

            return words.ToList();
        }
    }
}
