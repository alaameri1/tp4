using Microsoft.EntityFrameworkCore;
using NomDeVotreProjet.Models.HotellerieModel;
using tp4.Models.HotellerieModel; // Assurez-vous que le chemin d'accès est correct

namespace tp4.Models.HotellerieModel
{
    public class HotellerieDbContext : DbContext
    {
        // Constructeur de la classe HotellerieDbContext
        public HotellerieDbContext(DbContextOptions<HotellerieDbContext> options) : base(options)
        {
        }

        // DbSet représentant la table des hôtels dans la base de données
        public DbSet<Hotel> Hotels { get; set; } = null!;
        public DbSet<Appreciation> Appreciations { get; set; } // Ajout du DbSet pour Appreciation

    }
}
