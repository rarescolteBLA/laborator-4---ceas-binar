using System;
using System.Threading;

class CeasBinar
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            DateTime now = DateTime.Now;
            string o = Convert.ToString(now.Hour, 2).PadLeft(6, '0');
            string m = Convert.ToString(now.Minute, 2).PadLeft(6, '0');
            string s = Convert.ToString(now.Second, 2).PadLeft(6, '0');
            Console.WriteLine($"Ceas Binar\n O = {o}\n M = {m}\n S = {s}\n");
            int ora = now.Hour;
            int minut = now.Minute;
            int secunda = now.Second;
            binar(8, ora, minut, secunda,0);
            binar(4, ora, minut, secunda,1);
            binar(2, ora, minut, secunda,2);
            binar(1, ora, minut, secunda,3);
            Console.WriteLine($"-----------\n |{ora}|{minut}|{secunda}");
            Thread.Sleep (1000);
            
        }
        
    }
    static void binar(int valoare,int ora,int minut,int secunda,int pozitie) 
    {
        Console.WriteLine($"{valoare}|{afisare(ora, pozitie)}|{afisare(minut,pozitie)}|{afisare(secunda,pozitie)}");
    }
    static string afisare(int timp, int pozitie)
    {
        string primaCifra = Convert.ToString(timp / 10, 2).PadLeft(4, '0');
        string aDouaCifra = Convert.ToString(timp % 10, 2).PadLeft(4, '0');
        string rezultat = $"{primaCifra[pozitie]}{aDouaCifra[pozitie]}";
        return rezultat;
    }
}