class Voiture
{
   public string Modele { get; private set; }
   public string Marque { get; private set; }
   public int VitesseMin { get; private set; }
   public int VitesseMax { get; private set; }
   public double TempsTotal { get; private set; }

   public Voiture(string modele, string marque, int vitesseMin, int vitesseMax)
   {
       Modele = modele;
       Marque = marque;
       VitesseMin = vitesseMin;
       VitesseMax = vitesseMax;
       TempsTotal = 0;
   }

   public double CalculerVitesse(double distance)
   {
       Random rand = new Random();
       int vitesseAleatoire = rand.Next(VitesseMin, VitesseMax + 1);
       return vitesseAleatoire;
   }

   public void AjouterTempsTour(double tempsTour)
   {
       TempsTotal += tempsTour;
   }
}
