/*** YouTube Site Tutorial: https://www.youtube.com/watch?v=BnlFovYeQtI&list=PL82C6-O4XrHdiS10BLh23x71ve9mQCln0&index=2&ab_channel=TeddySmith ***/

using System.Security.Cryptography.X509Certificates;

namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public string PrimaryAttackName { get; set; }
        public int PrimaryAttackDamage { get; set; }
        public string SecondaryAttackName { get; set; }
        public int SecondaryAttackDamage { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }

    }
}
