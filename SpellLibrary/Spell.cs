using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellLibrary
{
    public class Spell
    {
        public string ClassList { get; private set; }
        public string School { get; private set; }
        public int Level { get; private set; }
        public bool IsRitual { get; private set; }
        public string CastingTime { get; private set; }
        public string Range { get; private set; }
        public string Components { get; private set; }
        public bool Concentration { get; private set; }
        public string Duration { get; private set; }
        public string EffectText { get; private set; }

        public Spell(string clslst, string scl, int lvl, bool rit, 
            string casttm, string rng, string comp, bool conc, 
            string dur, string efttxt)
        {
            ClassList = clslst;
            School = scl;
            Level = lvl;
            IsRitual = rit;
            CastingTime = casttm;
            Range = rng;
            Components = comp;
            Concentration = conc;
            Duration = dur;
            EffectText = efttxt;
        }

        public Spell(Spell clone)
        {
            ClassList = clone.ClassList;
            School = clone.School;
            Level = clone.Level;
            IsRitual = clone.IsRitual;
            CastingTime = clone.CastingTime;
            Range = clone.Range;
            Components = clone.Components;
            Concentration = clone.Concentration;
            Duration = clone.Duration;
            EffectText = clone.EffectText;
        }
    }
}
