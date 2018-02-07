using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderProgrammerenPracticumWeek1
{
    class Huisdier
    {
        private string naam;
        private string soort;

        public Huisdier(string naam, string soort)
        {
            this.naam = naam;
            this.soort = soort;
        }

        public string getNaam()
        {
            return this.naam;
        }

        public string getSoort()
        {
            return this.soort;
        }

        public string getBeschrijving()
        {
            return this.naam + this.soort;  
        }
    }
}
