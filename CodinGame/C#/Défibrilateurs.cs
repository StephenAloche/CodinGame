using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    public class Defibrilateur
    {
        public int id;
        public string lieu;
        public string adresse;
        public string tel;
        public string lon;
        public string lat;
        public double distance;

        public Defibrilateur()
        {
        }

        public Defibrilateur(int Id, string Lieu, string Adresse, string Tel, string Lon, string Lat)
        {
            id = Id;
            lieu = Lieu;
            adresse = Adresse;
            tel = Tel;
            lon = Lon;
            lat = Lat;
        }
    }

    public static double Distance(double LonA, double LatA, double LonB, double LatB)
    {
        double x = (LonB - LonA) * Math.Cos((LatA + LatB) / 2);
        double y = (LatB - LatA);
        double d = (Math.Sqrt(x * x + y * y)) * 6371;
        return d;
    }

    public static double DegToRad(double value)
    {
        double valueRad = value * Math.PI / 180;
        return valueRad;
    }

    static void Main(string[] args)
    {
        string LON = Console.ReadLine();
        string LAT = Console.ReadLine();
        int N = int.Parse(Console.ReadLine());
        List<Defibrilateur> defibList = new List<Defibrilateur>();

        LON = LON.Replace(",", ".");
        LAT = LAT.Replace(",", ".");

        double LONA = double.Parse(LON);
        double LATA = double.Parse(LAT);

        double LONArad = DegToRad(LONA);
        double LATArad = DegToRad(LATA);


        for (int i = 0; i < N; i++)
        {
            string DEFIB = Console.ReadLine();
            String[] DefibTab = DEFIB.Split(';');
            Defibrilateur defib = new Defibrilateur(int.Parse(DefibTab[0]), DefibTab[1], DefibTab[2], DefibTab[3], DefibTab[4], DefibTab[5]);
            defib.lon = (defib.lon).Replace(",", ".");
            defib.lat = (defib.lat).Replace(",", ".");

            double LONB = double.Parse(defib.lon);
            double LATB = double.Parse(defib.lat);

            double LONBrad = DegToRad(LONB);
            double LATBrad = DegToRad(LATB);

            defib.distance = Distance(LONArad, LATArad, LONBrad, LATBrad);

            defibList.Add(defib);
        }

        Defibrilateur defibProche = new Defibrilateur();
        
        IEnumerable<Defibrilateur> defibQuery =
            from defib in defibList
            where  defib.distance == (from defib2 in defibList select defib2.distance).Min()
            select defib;

        foreach (Defibrilateur defib in defibQuery)
        {
            Console.WriteLine(defib.lieu);
            //defibProche = defibQuery.Aggregate((firstItem, nextItem) => firstItem.distance < nextItem.distance ? firstItem : nextItem);
        }
        //Console.WriteLine(defibProche.lieu);
    }
}