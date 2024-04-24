namespace SimulationCourse
{
   class Program
   {
       static void Main(string[] args)
       {
           // Initialiser les paramètres de la course
           int nombreTours = 4;
           double distanceParTour = 7; // en kilomètres

           // Créer les voitures
           List<Voiture> voitures = new List<Voiture>() {
           new Voiture("812 SuperFast", "Ferrari", 60, 100), // Model, Marque, Vitesse 
           new Voiture("911 GT2 RS", "Porshe", 60, 100),
           new Voiture("GTR Nissmo", "Nissan", 60, 100),
           new Voiture("Aventador", "Lamborghini", 60, 100),
           new Voiture("M4 Competition CSL", "BMW", 60, 100),
           new Voiture("AMG gt black series", "Mercedes", 60, 100)
       };


           // Afficher les informations de départ
           //Console.BackgroundColor = ConsoleColor.DarkRed;
           Console.WriteLine();
           Console.WriteLine("----------------------------------------");
           Console.WriteLine("Début de la course de Spa-Francorchamps ");
           Console.WriteLine("----------------------------------------");
           Console.WriteLine();
           //Console.ResetColor();
           Console.WriteLine($"Nombre de tours : {nombreTours}");
           Console.WriteLine($"Distance par tour : {distanceParTour} km");
           Console.WriteLine();
           Console.WriteLine("Voitures participantes :");
           Console.WriteLine();

           // Affiche les voitures participantes 
           foreach (var voiture in voitures)
           {
               Console.WriteLine($"- {voiture.Marque} ({voiture.Modele})");
           }
           Console.WriteLine();

           // Simulation de la course
           for (int tour = 1; tour <= nombreTours; tour++)
           {
               Console.WriteLine($"Tour {tour} :");

               // Parcourir chaque voiture
               foreach (var voiture in voitures)
               {
                   // Calculer la vitesse de la voiture pour ce tour
                   double vitesse = voiture.CalculerVitesse(distanceParTour);

                   // Calculer le temps pour parcourir le tour
                   double tempsTour = distanceParTour / vitesse;

                   // Mettre à jour le temps total de la voiture
                   voiture.AjouterTempsTour(tempsTour);

                   // Afficher les progrès de la voiture
                   Console.WriteLine($"- {voiture.Marque} ({voiture.Modele}) avance à {vitesse} km/h. Temps du tour : {tempsTour:F2} heures.");
               }

               // Ajouter une pause pour simuler le déroulement en temps réel
               Thread.Sleep(1000);
               Console.WriteLine();
           }

           // Trouver la voiture gagnante
           Voiture? voitureGagnante = null;
           double tempsTotalMinimum = double.MaxValue;
           foreach (var voiture in voitures)
           {
               if (voiture.TempsTotal < tempsTotalMinimum)
               {
                   tempsTotalMinimum = voiture.TempsTotal;
                   voitureGagnante = voiture;
               }
           }

           // Calculer la vitesse moyenne de la voiture gagnante
           double vitesseMoyenneGagnante = distanceParTour / (tempsTotalMinimum / nombreTours);

           //Console.BackgroundColor = ConsoleColor.DarkRed;
           Console.WriteLine("--------------------------------------");
           Console.WriteLine(" Fin de la course de Spa-Francorchamps ");
           Console.WriteLine("--------------------------------------");
           Console.WriteLine();
           //Console.ResetColor();

           // Afficher la voiture gagnante et sa vitesse moyenne
           Console.WriteLine($"La voiture gagnante est : {voitureGagnante?.Marque} ({voitureGagnante?.Modele}) avec un temps total de {tempsTotalMinimum:F2} heures et une vitesse moyenne de {vitesseMoyenneGagnante:F2} km/h.");

           Console.ReadLine();
       }
   }
}
