using System;

namespace GestionResevations
{
    public class Reservation
    {
        // Propriétés
        public int Id { get; set; }
        public Ressource Ressource { get; set; }
        public string NomClient { get; set; }
        public string EmailClient { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Statut { get; set; }
        public string Description { get; set; }

        // Constructeur
        public Reservation()
        {
            NomClient = "";
            EmailClient = "";
            Statut = "En attente";
            Description = "";
        }

        // Méthode pour afficher le récapitulatif
        public void AfficherRecap()
        {
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine("          RÉCAPITULATIF DE RÉSERVATION");
            Console.WriteLine("=================================================");

            Console.WriteLine("\nRessource");
            Console.WriteLine("---------");
            Console.WriteLine($"Type : {Ressource.Type}");
            Console.WriteLine($"Nom : {Ressource.Nom}");
            Console.WriteLine($"Responsable : {Ressource.Responsable}");
            Console.WriteLine($"Contact : {Ressource.Email}");

            Console.WriteLine("\nClient");
            Console.WriteLine("------");
            Console.WriteLine($"Nom : {NomClient}");
            Console.WriteLine($"Email : {EmailClient}");

            Console.WriteLine("\nRéservation");
            Console.WriteLine("-----------");
            Console.WriteLine($"Date : {DateDebut:dd MMMM yyyy}");
            Console.WriteLine($"Heure : {DateDebut:HH:mm} - {DateFin:HH:mm}");
            Console.WriteLine($"Statut : {Statut}");

            if (!string.IsNullOrEmpty(Description))
            {
                Console.WriteLine($"Description : {Description}");
            }

            Console.WriteLine("=================================================");
        }
    }
}
