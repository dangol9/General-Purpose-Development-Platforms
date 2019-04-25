using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc1.Models
{
    public class TekstidModel
    {
        static string Failinimi = HttpContext.Current.Server.MapPath("~/App_Data/andmed1.txt");
        public static void LisaTekst(string Tekst)
        {
            System.IO.File.AppendAllText(Failinimi, Tekst + "\n");
        }
        public static string[] KysiTekstid()
        {
            return System.IO.File.ReadAllLines(Failinimi);
        }
        public static IEnumerable<string> TekstidSarnasePikkuseJargi(string Tekst)
        {
           return KysiTekstid().OrderBy(s => Math.Abs(s.Length - Tekst.Length));
        }
        public static double SonadeErinevus(string sona1, string sona2)
        {
            if(sona1.Length = 0) { return sona2.Length; }
            if (sona2.Length = 0) { return sona1.Length; }
            return Math.Abs(sona1.Length - sona2.Length) + Math.Abs(sona1[0] - sona2[1]) * 0.5;
        }
        public static IEnumerable<string> TekstidSarnuseJargi(string Tekst)
        {
            return KysiTekstid().OrderBy(s => SonadeErinevus(s, text));
        }
    }
}