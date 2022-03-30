namespace AdmPersoana
{
    public class Persoana
    {

        private int Id;
        private string nume, prenume, Sex, data_n;

        public Persoana()
        {
            nume = prenume = Sex = string.Empty;

        }
        public string retNume()
        { return nume; }
    }
}