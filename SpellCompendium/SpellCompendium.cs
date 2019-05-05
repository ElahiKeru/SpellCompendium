using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpellLibrary;

namespace SpellCompendium
{
    public partial class SpellCompendium : Form
    {
        //properties and links to external library
        SpellContainer fullSpellContainer;
        List<string> classFilter;
        List<string> schoolFilter;
        SpellContainer filteredSpells;

        public SpellCompendium()
        {
            classFilter = new List<string>();
            schoolFilter = new List<string>();
            InitializeComponent();
        }

        private void DGVSpellList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            DetailView dv = new DetailView((Spell)dgv.CurrentCell.OwningRow.DataBoundItem);
            dv.Show();
        }

        private void SpellCompendium_Load(object sender, EventArgs e)
        {
            //fill the spell list
            fullSpellContainer = new SpellContainer(@"DND5ESpellList.xml");

            //populate the controls
            DGVSpellList.DataSource = fullSpellContainer.Spells;
        }

        private void CLBClass_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            string entry = clb.Items[e.Index].ToString();

            if(e.NewValue == CheckState.Checked && !classFilter.Contains(entry))
            {
                //apply filter
                classFilter.Add(entry);
            }
            else
            {
                //remove filter
                classFilter.Remove(entry);
            }

            ApplyFilters();
        }

        private void ApplyFilters()
        {
            filteredSpells = new SpellContainer();
            var filtered = fullSpellContainer.Spells.Where(p => !string.IsNullOrEmpty(p.Name));
            if (classFilter.Count > 0)
            {
                filtered = filtered.Where(p => (p.ClassList.Where(s => classFilter.Contains(s.ToString())).Count() > 0));
            }

            foreach(Spell s in filtered)
            {
                filteredSpells.Add(s);
            }

            DGVSpellList.DataSource = filteredSpells.Spells;
        }

        private void CLBSchool_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            string entry = clb.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked && !classFilter.Contains(entry))
            {
                //apply filter
                schoolFilter.Add(entry);
            }
            else
            {
                //remove filter
                schoolFilter.Remove(entry);
            }

            ApplyFilters();
        }
    }
}
