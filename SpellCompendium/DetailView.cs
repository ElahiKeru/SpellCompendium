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
    public partial class DetailView : Form
    {
        Spell target;

        public DetailView()
        {
            InitializeComponent();
        }

        public DetailView(Spell input)
        {
            target = input;
            InitializeComponent();
        }

        private void DetailView_Load(object sender, EventArgs e)
        {
            this.Text = $"Spell Details: {target.Name}";
            TBClassList.Text = target.ClassList;
            TBSchool.Text = target.School;
            TBLevel.Text = target.Level.ToString();
            CBRitual.CheckState = target.IsRitual ? CheckState.Checked : CheckState.Unchecked;
            TBCastingTime.Text = target.CastingTime;
            TBRange.Text = target.Range;
            TBComponents.Text = target.Components;
            TBDuration.Text = target.Duration;
            CBConcentration.CheckState = target.Concentration ? CheckState.Checked : CheckState.Unchecked;
            TBEffect.Text = target.EffectText;
        }
    }
}
