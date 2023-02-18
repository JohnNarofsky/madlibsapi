namespace madlibsapi
{
    public enum WordType
    {
        noun,
        verb,
        adjective,
        adverb
    }

    public class WordEntry
    {
        public int Id { get; set; }
        public int Tag { get; set; }
        public WordType Type { get; set; }
        public string? Value { get; set; }
    }

    public class Game
    {
        public Game()
        {
            this.WordEntries = new List<WordEntry>();
        }

        public string? Article { get; set; }
        public int Id { get; set; }
        public List<WordEntry> WordEntries { get; set; }
    }

}
