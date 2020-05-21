namespace EthiopiaLanguageLearningPlatform.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public string Symbol { get; set; }
        public string ImageUrl { get; set; }
        public string ColumnIndex { get; set; }
        public string RowIndex { get; set; }
        public string SourceLanguageReading { get; set; }
        public string TargetLanguageReading { get; set; }
    }
}
