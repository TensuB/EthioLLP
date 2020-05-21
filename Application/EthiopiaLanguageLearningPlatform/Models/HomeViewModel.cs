using System.Collections.Generic;

namespace EthiopiaLanguageLearningPlatform.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            Characters = new List<Character>();
        }

        public IList<Character> Characters { get; set; }
    }
}
