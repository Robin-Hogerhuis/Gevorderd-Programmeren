﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderProgrammerenPracticumWeek1
{
    class Persoon
    {
        private string voornaam;
        private string achternaam;
        private int leeftijd;
        private List<Huisdier> huisdieren;

        public Persoon(string voornaam, string achternaam, int leeftijd)
        {
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.leeftijd = leeftijd;
            huisdieren = new List<Huisdier>();
        }

        public string getNaam()
        {
            return voornaam; 
        }

        public string getAchternaam()
        {
            return achternaam; 
        }

        public List<Huisdier> getHuisdieren()
        {
            return huisdieren; 
        }

        public void addHuisdier(Huisdier huisdier)
        {
          
        }

        public int getLeeftijd()
        {
            return leeftijd;
        }
    }
}
