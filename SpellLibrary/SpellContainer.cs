using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SpellLibrary
{
    public class SpellContainer : IEnumerable<Spell>
    {
        private readonly string spellPath;
        private List<Spell> spells;

        public List<Spell> Spells
        {
            get
            {
                if (spells == null)
                {
                    spells = new List<Spell>();
                }
                return spells;
            }
            set
            {
                spells = value;
            }
        }

        public SpellContainer(string xmlPath)
        {
            spellPath = xmlPath;
            ProcessSpellsList();
        }

        public SpellContainer()
        {

        }

        private void ProcessSpellsList()
        {
            XmlDocument inputDoc = new XmlDocument();
            inputDoc.Load(spellPath);

            XmlNodeList spellset = inputDoc.GetElementsByTagName("spell");

            foreach (XmlNode xn in spellset)
            {
                Spells.Add(new Spell(xn["name"].InnerText,
                                     xn["classlist"].InnerText,
                                     xn["school"].InnerText,
                                     int.Parse(xn["level"].InnerText),
                                     Utilities.StringToBool(xn["ritual"].InnerText),
                                     xn["casttime"].InnerText,
                                     xn["range"].InnerText,
                                     xn["components"].InnerText,
                                     Utilities.StringToBool(xn["concentration"].InnerText),
                                     xn["duration"].InnerText,
                                     xn["effect"].InnerText));
            }
        }

        public IEnumerator<Spell> GetEnumerator()
        {
            return Spells.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Spells.GetEnumerator();
        }

        public Spell this[string index]
        {
            get
            {
                if (spells == null) spells = new List<Spell>();
                Spell target = null;
                foreach (Spell s in spells)
                {
                    if (s.Name.Equals(index))
                    {
                        target = s;
                    }
                }
                return target;
            }
        }

        public Spell this[int index]
        {
            get
            {
                if (spells == null) spells = new List<Spell>();
                return spells[index];
            }
        }

        public void Add(Spell target)
        {
            Spells.Add(target);
        }

        public void Remove(string target)
        {
            Spells.Remove(this[target]);
        }
    }
}
