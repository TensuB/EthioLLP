
using Microsoft.EntityFrameworkCore;

namespace EthiopiaLanguageLearningPlatform.Models
{
    public class CharactersDbContext : DbContext
    {

        public CharactersDbContext(DbContextOptions<CharactersDbContext> options)
            : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
    }
}
