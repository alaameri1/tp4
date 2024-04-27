using System;
using System.ComponentModel.DataAnnotations;

namespace NomDeVotreProjet.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le champ Nom est obligatoire.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "La longueur du Nom doit être comprise entre 3 et 20 caractères.")]
        public string? Nom { get; set; }

        [Range(1, 5, ErrorMessage = "Le nombre d'étoiles doit être compris entre 1 et 5.")]
        public int Etoiles { get; set; }

        [Required(ErrorMessage = "Le champ Ville est obligatoire.")]
        public string? Ville { get; set; }

        [Required(ErrorMessage = "Le champ Site Web est obligatoire.")]
        [RegularExpression(@"^(https?://)?([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$", ErrorMessage = "Veuillez entrer une URL valide.")]
        [Display(Name = "Site Web")]
        public string? SiteWeb { get; set; }
        public string? Tel {get; set; }
        public string Pays { get; set; } = "Tunisie"; // Ajout de la propriété Pays avec une valeur par défaut de "Tunisie"

        public ICollection<Appreciation>? Appreciations { get; set; }

    }
}
