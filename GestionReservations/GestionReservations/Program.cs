using System;

namespace GestionResevations
{
    class Programme
    {
        static void Main(string[] args)
        {
            Console.Title = "GestionResevations";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            AppGestionReservation monApp = new AppGestionReservation();
            monApp.Lancer();
        }
    }
}
