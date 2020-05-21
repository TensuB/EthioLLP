using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EthiopiaLanguageLearningPlatform.Models
{
    public class Character
    {
        public string Id { get; set; }
        public string Name {get; set;}
        public string Symbol { get; set; }
        public string ImageUrl { get; set; }
        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
        public string SourceLanguageReading { get; set; }
        public string TargetLanguageReading { get; set; }
    }
}
