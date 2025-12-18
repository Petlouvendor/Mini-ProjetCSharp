using GestionReservations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionReservations
{ 
public class Reservation
{
    public int Id { get; set; }
    public Ressource Ressource { get; set; }
    public string ClientNom { get; set; } = "";
    public string ClientEmail { get; set; } = "";
    public DateTime DateDebut { get; set; }
    public DateTime DateFin { get; set; }
    public string Statut { get; set; } = "Confirmée";
    public string Motif { get; set; } = "";
}
}
