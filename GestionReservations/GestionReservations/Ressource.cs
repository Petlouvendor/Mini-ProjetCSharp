using System;
using System.Collections.Generic;
using System.Text;

namespace GestionReservations
{

    public class Ressource
    {
        public int Id { get; set; }
        public string Type { get; set; } = "";
        public string Nom { get; set; } = "";
        public string Responsable { get; set; } = "";
        public string EmailResponsable { get; set; } = "";
        public string Localisation { get; set; } = "";
        public int Capacite { get; set; } = 1;
    }
}