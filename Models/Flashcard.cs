namespace FlashCardBuddyBlazor.Models
{
    public partial class Flashcard
    {
        public int Flashcardid { get; set; }

        public string Question { get; set; } = string.Empty;

        public string Answer { get; set; } = string.Empty;

        public string Stack { get; set; } = string.Empty;

        public int? Userid { get; set; }

    }
}