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
        private SpellContainer fullSpellContainer;
        private List<string> classFilter;
        private List<string> schoolFilter;
        private List<int> levelFilter;
        private List<bool> ritualFilter;
        private List<string> castingFilter;
        private List<string> componentFilter;
        private List<bool> concentrationFilter;
        private string[] castingTimeFilters = { "1 Action", "1 Bonus Action", "1 Reaction" };
        private SpellContainer filteredSpells;

        public SpellCompendium()
        {
            classFilter = new List<string>();
            schoolFilter = new List<string>();
            levelFilter = new List<int>();
            ritualFilter = new List<bool>();
            castingFilter = new List<string>();
            componentFilter = new List<string>();
            concentrationFilter = new List<bool>();
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
            DGVSpellList.Columns["EffectText"].Visible = false;
        }

        private void ApplyFilters()
        {
            filteredSpells = new SpellContainer();
            var filtered = fullSpellContainer.Spells.Where(p => !string.IsNullOrEmpty(p.Name));

            //apply class list filter if applicable
            if (classFilter.Count > 0)
            {
                filtered = filtered.Where(p => p.ClassList.Split(',').Where(s => classFilter.Contains(s.ToString().Trim())).Count() > 0);
            }

            //apply school list filter if applicable
            if(schoolFilter.Count > 0)
            {
                filtered = filtered.Where(p => schoolFilter.Contains(p.School));
            }

            //apply level list filter if applicable
            if(levelFilter.Count > 0)
            {
                filtered = filtered.Where(p => levelFilter.Contains(p.Level));
            }

            //apply ritual list filter if applicable
            if(ritualFilter.Count > 0)
            {
                filtered = filtered.Where(p => ritualFilter.Contains(p.IsRitual));
            }
            
            //apply casting time filter if applicable
            if(castingFilter.Count > 0)
            {
                if (castingFilter.Contains("Other"))
                {
                    filtered = filtered.Where(p => !castingTimeFilters.Contains(p.CastingTime) || castingFilter.Contains(p.CastingTime));
                }
                else
                {
                    filtered = filtered.Where(p => castingFilter.Contains(p.CastingTime));
                }
            }
            
            //apply components filter if applicable
            if(componentFilter.Count > 0)
            {
                filtered = filtered.Where(p => p.Components.Split(',').Where(s => componentFilter.Contains(s.ToString().Trim())).Count() > 0);
            }
            
            //apply concentration filter if applicable
            if(concentrationFilter.Count > 0)
            {
                filtered = filtered.Where(p => concentrationFilter.Contains(p.Concentration));
            }

            foreach (Spell s in filtered)
            {
                filteredSpells.Add(s);
            }

            DGVSpellList.DataSource = filteredSpells.Spells;
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

        private void CLBLevel_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            int.TryParse(clb.Items[e.Index].ToString(), out int entry);

            if(e.NewValue == CheckState.Checked && !levelFilter.Contains(entry))
            {
                //apply filter
                levelFilter.Add(entry);
            }
            else
            {
                //remove filter
                levelFilter.Remove(entry);
            }

            ApplyFilters();
        }

        private void CLBRitual_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            bool entry = Utilities.StringToBool(clb.Items[e.Index].ToString());

            if(e.NewValue == CheckState.Checked && !ritualFilter.Contains(entry))
            {
                //apply filter
                ritualFilter.Add(entry);
            }
            else
            {
                //remove filter
                ritualFilter.Remove(entry);
            }

            ApplyFilters();
        }

        private void CLBCastingTime_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            string entry = clb.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked && !castingFilter.Contains(entry))
            {
                //apply filter
                castingFilter.Add(entry);
            }
            else
            {
                //remove filter
                castingFilter.Remove(entry);
            }

            ApplyFilters();
        }

        private void CLBComponents_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            string entry = clb.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked && !componentFilter.Contains(entry))
            {
                //apply filter
                componentFilter.Add(entry);
            }
            else
            {
                //remove filter
                componentFilter.Remove(entry);
            }

            ApplyFilters();
        }

        private void CLBConcentration_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            bool entry = Utilities.StringToBool(clb.Items[e.Index].ToString());

            if (e.NewValue == CheckState.Checked && !concentrationFilter.Contains(entry))
            {
                //apply filter
                concentrationFilter.Add(entry);
            }
            else
            {
                //remove filter
                concentrationFilter.Remove(entry);
            }

            ApplyFilters();
        }

        private void DGVSpellList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Spell> output = (List<Spell>)DGVSpellList.DataSource;
            switch(e.ColumnIndex)
            {
                case 0:
                    DGVSpellList.DataSource = output.OrderBy(x => x.Name).ToList();
                    break;
                case 1:
                    DGVSpellList.DataSource = output.OrderBy(x => x.ClassList).ToList();
                    break;
                case 2:
                    DGVSpellList.DataSource = output.OrderBy(x => x.School).ToList();
                    break;
                case 3:
                    DGVSpellList.DataSource = output.OrderBy(x => x.Level).ToList();
                    break;
                case 4:
                    DGVSpellList.DataSource = output.OrderBy(x => x.IsRitual).ToList();
                    break;
                case 5:
                    DGVSpellList.DataSource = output.OrderBy(x => x.CastingTime).ToList();
                    break;
                case 6:
                    DGVSpellList.DataSource = output.OrderBy(x => x.Range).ToList();
                    break;
                case 7:
                    DGVSpellList.DataSource = output.OrderBy(x => x.Components).ToList();
                    break;
                case 8:
                    DGVSpellList.DataSource = output.OrderBy(x => x.Concentration).ToList();
                    break;
                case 9:
                    DGVSpellList.DataSource = output.OrderBy(x => x.Duration).ToList();
                    break;
            }
        }
    }
}
