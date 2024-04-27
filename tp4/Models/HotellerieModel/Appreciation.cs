using System.ComponentModel.DataAnnotations;

namespace NomDeVotreProjet.Models.HotellerieModel
{
    public class Appreciation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le champ Nom Personne est obligatoire.")]
        [Display(Name = "Nom Personne")]
        public string? NomPers { get; set; }

        [Required(ErrorMessage = "Le champ Commentaire est obligatoire.")]
        public string? Commentaire { get; set; }

        public int? HotelId { get; set; } // Déclaré nullable
        [Required(ErrorMessage = "Le champ Note est obligatoire.")]
        [Range(1, 5, ErrorMessage = "La note doit être comprise entre 1 et 5.")]
        public int Note { get; set; } = 3; // Valeur par défaut de la note est 3
        // Propriété de navigation vers l'hôtel associé
        public Hotel? Hotel { get; set; }    

    }
}
