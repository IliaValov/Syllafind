namespace Syllafind.Service.Models
{
    public class WordFilter
    {
        public WordFilter()
        {
            this.ContainCharactersAtPositions = new HashSet<Character>();
            this.DoesNotContainCharactersAtPositions = new HashSet<Character>();
            this.ContainsCharacters = new HashSet<string>();
            this.DoesNotContainsCharacters = new HashSet<string>();
        }

        public string StartsWith { get; set; }

        public string EndsWith { get; set; }

        public ICollection<Character> ContainCharactersAtPositions { get; set; }

        public ICollection<Character> DoesNotContainCharactersAtPositions { get; set; }

        public ICollection<string> ContainsCharacters { get; set; }

        public ICollection<string> DoesNotContainsCharacters { get; set; }

        public int Length { get; set; }
    }
}
