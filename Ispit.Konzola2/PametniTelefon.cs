using Ispit.Konzola2.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola2
{
    public class PametniTelefon : IPametniTelefon, ITelefon

    {

        //property
        public string Model { get; private set; }




        //konstruktor parametrizirani

        public PametniTelefon(string model)
        {
            this.Model = model;
        }






        //Metode

       
        public string Surfanje(string url)
        {
            return Surfaj(url);

        }




        public string Surfaj(string url)
        {
            
            bool validan_url = ProvjeriAkoJeValidanUrl(url);
            string poruka_valid = "Moguće je surfati na tom url-u.";
            string poruka_invalid = "Neispravan url!";
            if (validan_url)
                return poruka_valid; 
            else
                return poruka_invalid; 


        }





        
        public string Poziv(string telefonski_broj)
        {
            bool validan_broj = ProvjeriAkoJeValidanBroj(telefonski_broj);
            string poruka_valid = "Moguće je zvati telefonski broj.";
            string poruka_invalid = "Neispravan telefonski broj!";
            if (validan_broj)
                return poruka_valid;
            else
                return poruka_invalid;

        }







        public bool ProvjeriAkoJeValidanUrl(string url)
        {

            foreach (var c in url)
            {
                if (c >= '0' && c <= '9')
                {
                    return false;
                }
            }
            return true;



        }






        public bool ProvjeriAkoJeValidanBroj(string telefonski_broj)
        {
            foreach (var c in telefonski_broj)
            {
                if (!(c >= '0' && c <= '9'))
                {
                    return false;
                }
            }
            return true;
        }






    }



}
