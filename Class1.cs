using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPiuLaborator
{
     public class Persoana
    {
        
        int Id;
        string nume, prenume, Sex, data_n;
       
        public Persoana()
      {
            nume=prenume=Sex= string.Empty;
            Id = 0;
        }
        public string retNume()
        { return nume; }
     
    }
}
