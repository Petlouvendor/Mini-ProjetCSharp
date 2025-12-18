using System;
using System.Collections.Generic;
using System.Text;

namespace GestionReservations
{
    // Interface simple pour la gestion
    public interface IGestionnaire
    {
        void AjouterRessource(Ressource ressource);
        List<Ressource> GetRessources();
        Ressource GetRessource(int id);

        void AjouterReservation(Reservation reservation);
        List<Reservation> GetReservations();
        Reservation GetReservation(int id);
    }

    // Interface pour l'affichage
    public interface IAfficheur
    {
        void AfficherMenu();
        void AfficherReservation(Reservation res);
        void AfficherRessource(Ressource res);
        void AfficherMessage(string message, bool erreur = false);
    }
}
