using System;

namespace GestionResevations
{
    public class Ressource
    {
        // Propriétés
        public int Id { get; set; }
        public string Type { get; set; }
        public string Nom { get; set; }
        public string Responsable { get; set; }
        public string Email { get; set; }
        public string Emplacement { get; set; }
        public int Capacite { get; set; }

        // Constructeur par défaut
        public Ressource()
        {
            Type = "Salle";
            Nom = "";
            Responsable = "";
            Email = "";
            Emplacement = "";
            Capacite = 1;
        }

        // Constructeur avec paramètres
        public Ressource(int id, string type, string nom, string responsable, string email, string emplacement, int capacite)
        {
            Id = id;
            Type = type;
            Nom = nom;
            Responsable = responsable;
            Email = email;
            Emplacement = emplacement;
            Capacite = capacite;
        }

        // Afficher les détails
        public void Afficher()
        {
            Console.WriteLine($"\nID: {Id}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Nom: {Nom}");
            Console.WriteLine($"Responsable: {Responsable}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Emplacement: {Emplacement}");
            Console.WriteLine($"Capacité: {Capacite} personnes");
        }
    }
}
