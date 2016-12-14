using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mythras_Character_Generator.MythrasInfo
{
    public class Race
    {
        string raceName;
        int strMin;
        int strMax;
        int dexMin;
        int dexMax;
        int conMin;
        int conMax;
        int sizMin;
        int sizMax;
        int powMin;
        int powMax;
        int chaMin;
        int chaMax;
        int intMin;
        int intMax;

        public Race()
        {
            this.raceName = "Human";
            this.strMin = 3;
            this.strMax = 18;
            this.dexMin = 3;
            this.dexMax = 18;
            this.conMin = 3;
            this.conMax = 18;
            this.sizMin = 3;
            this.sizMax = 18;
            this.powMin = 3;
            this.powMax = 18;
            this.chaMin = 3;
            this.chaMax = 18;
            this.intMin = 3;
            this.intMax = 18;
        }

        public Race(string raceName, int strMin, int strMax, int dexMin, int dexMax, 
            int conMin, int conMax, int sizMin, int sizMax, int chaMin, int chaMax,
            int powMin, int powMax, int intMin, int intMax)
        {
            this.raceName = raceName;
            this.strMin = strMin;
            this.strMax = strMax;
            this.dexMin = dexMin;
            this.dexMax = dexMax;
            this.conMin = conMin;
            this.conMax = conMax;
            this.sizMin = sizMin;
            this.sizMax = sizMax;
            this.powMin = powMin;
            this.powMax = powMax;
            this.chaMin = chaMin;
            this.chaMax = chaMax;
            this.intMin = intMin;
            this.intMax = intMax;
        }

        public string getName()
        {
            return raceName;
        }
    }
}
