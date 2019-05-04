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
        SpellContainer filteredSpells;

        public SpellCompendium()
        {
            InitializeComponent();
        }

        private void DGVSpellList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            var test = dgv.CurrentCell.OwningRow.DataBoundItem;
        }

        private void SpellCompendium_Load(object sender, EventArgs e)
        {
            //set up the spell list object and bind it to the DGV
            fullSpellContainer = new SpellContainer();
        }
    }
}
