/*** YouTube Site Tutorial: https://www.youtube.com/watch?v=BnlFovYeQtI&list=PL82C6-O4XrHdiS10BLh23x71ve9mQCln0&index=2&ab_channel=TeddySmith ***/

using System.Security.Cryptography.X509Certificates;

namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /* create get set for image in DB */

public DateTime Birth { get; set; }
        public string PrimaryAttackName { get; set; }
        public int PrimaryAttackDamage { get; set; }
        public string SecondardyAttackName { get; set; }
        public int SecondardyAttackDamage { get; set; }



    }
}
