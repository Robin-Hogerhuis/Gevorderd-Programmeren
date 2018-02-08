using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderProgrammerenPracticumWeek1
{
    class Huisdier
    {
        private string Naam;
        private string Soort;
       

        public Huisdier(string n, string s)
        {
            this.Naam = n;
            this.Soort = s;
        }

        public string getNaam()
        {
            return Naam;
        }

        public string getSoort()
        {
            return Soort;
        }

        public string getBeschrijving() 
        {
            return Naam + Soort; 
        }

     
     


    }
}
