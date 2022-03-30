using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

    class Program
    {
        static void Main()
        {
        
            Persoana p=new Persoana("Mihai","Florin");
            string sp = p.Nume();
            Console.WriteLine(sp);
            Console.ReadKey();
        Persoana p2 = new Persoana();
        p2.Tastatura();

        }
    }
    public class Camera
    {
        int nrCam;
        public Camera()
        {
            nrCam = 0;
        }
        public Camera(int _nrCam)
        {
            nrCam = _nrCam;
        }
    }
public  class Persoana
{

    int Id;
    string nume, prenume, Sex, data_n;


    public Persoana()
    {
        nume = prenume = Sex = data_n = string.Empty;
        Id = 0;
    }
    public Persoana(string _nume, string _prenume)
    {
        nume = _nume;
        prenume = _prenume;
    }
    public string Nume()
    { return $"Nume: {nume}{prenume}"; }
    public string Tastatura()
    {
        nume = Console.ReadLine();
        prenume = Console.ReadLine();
        return $"Nume: {nume}{prenume}";
    }


    public static void WriteToFile(this string Str, string Filename)
    {
        File.WriteAllText(Filename, Str);
        return;
    }

}






public class Camin
    {

        string numeCamin, adresa, Administrator;
        int pretCazare;
        public Camin()
        {
            numeCamin = adresa = Administrator = string.Empty;
            pretCazare = 0;
        }
        public Camin(string _numeCamin, string _adresa, string _Administrator, int _pretCazare)
        {
            numeCamin = _numeCamin;
            adresa = _adresa;
            Administrator = _Administrator;
            pretCazare = _pretCazare;
        }
    }

