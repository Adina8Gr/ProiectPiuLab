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
        int nrPersoane = 0;
        string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
        Administrare_FisierText adminPersoane = new Administrare_FisierText(numeFisier);
        Persoana PersoanaNoua = new Persoana();
        adminPersoane.GetPersoane(out nrPersoane);
        Persoana[] persoane = adminPersoane.GetPersoane(out nrPersoane);
        AfisarePersoane(persoane, nrPersoane);
        int idPersoana = nrPersoane + 1;
        PersoanaNoua.IdPersona = idPersoana;
        //adaugare student in fisier
        adminPersoane.AddPersoane(PersoanaNoua);

        nrPersoane = nrPersoane + 1;

        /*  Persoana p=new Persoana("Mihai","Florin");
          string sp = p.Nume();
          Console.WriteLine(sp);
          Console.ReadKey();
      Persoana p2 = new Persoana();
      p2.Tastatura();
        */
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
    private const char SEPARATOR_PRINCIPAL_FISIER = ';';
    private const char SEPARATOR_SECUNDAR_FISIER = ' ';
    int ID=0;
    int NUME = 1;
    int PRENUME = 0;
    int NOTE = 3;
    public int IdPersoana { get; set; }
    public string nume { get; set; }
    public string prenume { get; set; }
    const int NR_MAX_LOCURI = 500;

    public   Persoana()
    {
        nume = prenume =  string.Empty;
       
    }
    public  Persoana(int idPersoana, string _nume, string _prenume)
    {
        this.IdPersoana = idPersoana;
        this.nume = _nume;
        this.prenume = _prenume;
    }
    public static void AfisarePersoana(Persoana persoana)
    {
        string infoPersoana = string.Format("Persoana cu id-ul #{0} are numele: {1} {2} ",
                persoana.IdPersoana,
                persoana.nume ?? " NECUNOSCUT ",
                persoana.prenume ?? " NECUNOSCUT "
              );

        Console.WriteLine(infoPersoana);
    }

    public void AfisarePersoane(Persoana[] persoane, int nrPersoane)
    {
        Console.WriteLine("Persoanele cazate sunt:");
        for (int contor = 0; contor < nrPersoane; contor++)
        {
            AfisarePersoana(persoane[contor]);
        }
    }

    public  Persoana CitireTastatura()
    {
        Console.WriteLine("Introduceti numele");
        string nume = Console.ReadLine();

        Console.WriteLine("Introduceti prenumele");
        string prenume = Console.ReadLine();

        Persoana persoana = new Persoana(0, nume, prenume);

        

        return persoana;
    }
    /*public string Nume()
    { return $"Nume: {nume}{prenume}"; }
    public string Tastatura()
    {
        nume = Console.ReadLine();
        prenume = Console.ReadLine();
        return $"Nume: {nume}{prenume}";
    }*/

    /*public static void WriteToFile(this string Str, string Filename)
    {
        File.WriteAllText(Filename, Str);
        return;
    }
    */
    
        
        string numeFisier;

        public Administrare_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddPersoana(Persoana persoana)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(persoana.ConversieLaSir_PentruFisier());
            }
        }

        public Persoana[] GetPersoane(out int nrPersoane)
        {
            Persoana[]  persoane= new Persoana[NR_MAX_LOCURI];

       
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrPersoane = 0;

           
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    persoane[nrPersoane++] = new Persoana(linieFisier);
                }
            }

            return persoane;
        }
    
    public Persoana(string linieFisier)
    {
        string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

        
        IdPersoana = Convert.ToInt32(dateFisier[ID]);
        nume = dateFisier[NUME];
        prenume = dateFisier[PRENUME];
        
    }

    public string ConversieLaSir_PentruFisier()
    {


        string obiectPersoanaPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
            SEPARATOR_PRINCIPAL_FISIER,
            IdPersoana.ToString(),
            (nume ?? " NECUNOSCUT "),
            (prenume ?? " NECUNOSCUT "));
           

        return obiectPersoanaPentruFisier;
    }

    public string GetNume()
    { return nume;
    }
    public string GetPrenume()
    { return prenume; }

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


