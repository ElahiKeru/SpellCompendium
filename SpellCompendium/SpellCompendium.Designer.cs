namespace SpellCompendium
{
    partial class SpellCompendium
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVSpellList = new System.Windows.Forms.DataGridView();
            this.LBLClass = new System.Windows.Forms.Label();
            this.LBLSchool = new System.Windows.Forms.Label();
            this.LBLLevel = new System.Windows.Forms.Label();
            this.LBLRitual = new System.Windows.Forms.Label();
            this.LBLCastingTime = new System.Windows.Forms.Label();
            this.LBLComponents = new System.Windows.Forms.Label();
            this.LBLConcentration = new System.Windows.Forms.Label();
            this.CLBClass = new System.Windows.Forms.CheckedListBox();
            this.CLBSchool = new System.Windows.Forms.CheckedListBox();
            this.CLBLevel = new System.Windows.Forms.CheckedListBox();
            this.CLBRitual = new System.Windows.Forms.CheckedListBox();
            this.CLBCastingTime = new System.Windows.Forms.CheckedListBox();
            this.CLBComponents = new System.Windows.Forms.CheckedListBox();
            this.CLBConcentration = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSpellList)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVSpellList
            // 
            this.DGVSpellList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSpellList.Location = new System.Drawing.Point(9, 86);
            this.DGVSpellList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVSpellList.Name = "DGVSpellList";
            this.DGVSpellList.ReadOnly = true;
            this.DGVSpellList.RowTemplate.Height = 24;
            this.DGVSpellList.Size = new System.Drawing.Size(756, 270);
            this.DGVSpellList.TabIndex = 0;
            this.DGVSpellList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSpellList_CellDoubleClick);
            // 
            // LBLClass
            // 
            this.LBLClass.AutoSize = true;
            this.LBLClass.Location = new System.Drawing.Point(7, 13);
            this.LBLClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLClass.Name = "LBLClass";
            this.LBLClass.Size = new System.Drawing.Size(32, 13);
            this.LBLClass.TabIndex = 8;
            this.LBLClass.Text = "Class";
            // 
            // LBLSchool
            // 
            this.LBLSchool.AutoSize = true;
            this.LBLSchool.Location = new System.Drawing.Point(101, 13);
            this.LBLSchool.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLSchool.Name = "LBLSchool";
            this.LBLSchool.Size = new System.Drawing.Size(40, 13);
            this.LBLSchool.TabIndex = 9;
            this.LBLSchool.Text = "School";
            // 
            // LBLLevel
            // 
            this.LBLLevel.AutoSize = true;
            this.LBLLevel.Location = new System.Drawing.Point(237, 13);
            this.LBLLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLLevel.Name = "LBLLevel";
            this.LBLLevel.Size = new System.Drawing.Size(33, 13);
            this.LBLLevel.TabIndex = 10;
            this.LBLLevel.Text = "Level";
            // 
            // LBLRitual
            // 
            this.LBLRitual.AutoSize = true;
            this.LBLRitual.Location = new System.Drawing.Point(332, 13);
            this.LBLRitual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLRitual.Name = "LBLRitual";
            this.LBLRitual.Size = new System.Drawing.Size(34, 13);
            this.LBLRitual.TabIndex = 11;
            this.LBLRitual.Text = "Ritual";
            // 
            // LBLCastingTime
            // 
            this.LBLCastingTime.AutoSize = true;
            this.LBLCastingTime.Location = new System.Drawing.Point(426, 13);
            this.LBLCastingTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLCastingTime.Name = "LBLCastingTime";
            this.LBLCastingTime.Size = new System.Drawing.Size(68, 13);
            this.LBLCastingTime.TabIndex = 12;
            this.LBLCastingTime.Text = "Casting Time";
            // 
            // LBLComponents
            // 
            this.LBLComponents.AutoSize = true;
            this.LBLComponents.Location = new System.Drawing.Point(553, 13);
            this.LBLComponents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLComponents.Name = "LBLComponents";
            this.LBLComponents.Size = new System.Drawing.Size(66, 13);
            this.LBLComponents.TabIndex = 13;
            this.LBLComponents.Text = "Components";
            // 
            // LBLConcentration
            // 
            this.LBLConcentration.AutoSize = true;
            this.LBLConcentration.Location = new System.Drawing.Point(647, 13);
            this.LBLConcentration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLConcentration.Name = "LBLConcentration";
            this.LBLConcentration.Size = new System.Drawing.Size(73, 13);
            this.LBLConcentration.TabIndex = 14;
            this.LBLConcentration.Text = "Concentration";
            // 
            // CLBClass
            // 
            this.CLBClass.FormattingEnabled = true;
            this.CLBClass.Items.AddRange(new object[] {
            "B",
            "C",
            "D",
            "P",
            "R",
            "S",
            "L",
            "W"});
            this.CLBClass.Location = new System.Drawing.Point(9, 29);
            this.CLBClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CLBClass.Name = "CLBClass";
            this.CLBClass.Size = new System.Drawing.Size(91, 34);
            this.CLBClass.TabIndex = 15;
            this.CLBClass.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBClass_ItemCheck);
            // 
            // CLBSchool
            // 
            this.CLBSchool.FormattingEnabled = true;
            this.CLBSchool.Items.AddRange(new object[] {
            "Abjuration",
            "Conjuration",
            "Divination",
            "Enchantment",
            "Evocation",
            "Illusion",
            "Necromancy",
            "Transmutation"});
            this.CLBSchool.Location = new System.Drawing.Point(104, 29);
            this.CLBSchool.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CLBSchool.Name = "CLBSchool";
            this.CLBSchool.Size = new System.Drawing.Size(132, 34);
            this.CLBSchool.TabIndex = 16;
            this.CLBSchool.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBSchool_ItemCheck);
            // 
            // CLBLevel
            // 
            this.CLBLevel.FormattingEnabled = true;
            this.CLBLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CLBLevel.Location = new System.Drawing.Point(239, 29);
            this.CLBLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CLBLevel.Name = "CLBLevel";
            this.CLBLevel.Size = new System.Drawing.Size(91, 34);
            this.CLBLevel.TabIndex = 17;
            // 
            // CLBRitual
            // 
            this.CLBRitual.FormattingEnabled = true;
            this.CLBRitual.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CLBRitual.Location = new System.Drawing.Point(334, 29);
            this.CLBRitual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CLBRitual.Name = "CLBRitual";
            this.CLBRitual.Size = new System.Drawing.Size(91, 34);
            this.CLBRitual.TabIndex = 18;
            // 
            // CLBCastingTime
            // 
            this.CLBCastingTime.FormattingEnabled = true;
            this.CLBCastingTime.Items.AddRange(new object[] {
            "1 Action",
            "1 Bonus Action",
            "1 Reaction",
            "Other"});
            this.CLBCastingTime.Location = new System.Drawing.Point(428, 29);
            this.CLBCastingTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CLBCastingTime.Name = "CLBCastingTime";
            this.CLBCastingTime.Size = new System.Drawing.Size(123, 34);
            this.CLBCastingTime.TabIndex = 19;
            // 
            // CLBComponents
            // 
            this.CLBComponents.FormattingEnabled = true;
            this.CLBComponents.Items.AddRange(new object[] {
            "Verbal",
            "Somatic",
            "Material"});
            this.CLBComponents.Location = new System.Drawing.Point(555, 29);
            this.CLBComponents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CLBComponents.Name = "CLBComponents";
            this.CLBComponents.Size = new System.Drawing.Size(91, 34);
            this.CLBComponents.TabIndex = 20;
            // 
            // CLBConcentration
            // 
            this.CLBConcentration.FormattingEnabled = true;
            this.CLBConcentration.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CLBConcentration.Location = new System.Drawing.Point(650, 29);
            this.CLBConcentration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CLBConcentration.Name = "CLBConcentration";
            this.CLBConcentration.Size = new System.Drawing.Size(91, 34);
            this.CLBConcentration.TabIndex = 21;
            // 
            // SpellCompendium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 366);
            this.Controls.Add(this.CLBConcentration);
            this.Controls.Add(this.CLBComponents);
            this.Controls.Add(this.CLBCastingTime);
            this.Controls.Add(this.CLBRitual);
            this.Controls.Add(this.CLBLevel);
            this.Controls.Add(this.CLBSchool);
            this.Controls.Add(this.CLBClass);
            this.Controls.Add(this.LBLConcentration);
            this.Controls.Add(this.LBLComponents);
            this.Controls.Add(this.LBLCastingTime);
            this.Controls.Add(this.LBLRitual);
            this.Controls.Add(this.LBLLevel);
            this.Controls.Add(this.LBLSchool);
            this.Controls.Add(this.LBLClass);
            this.Controls.Add(this.DGVSpellList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SpellCompendium";
            this.Text = "Spell Compendium";
            this.Load += new System.EventHandler(this.SpellCompendium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSpellList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVSpellList;
        private System.Windows.Forms.Label LBLClass;
        private System.Windows.Forms.Label LBLSchool;
        private System.Windows.Forms.Label LBLLevel;
        private System.Windows.Forms.Label LBLRitual;
        private System.Windows.Forms.Label LBLCastingTime;
        private System.Windows.Forms.Label LBLComponents;
        private System.Windows.Forms.Label LBLConcentration;
        private System.Windows.Forms.CheckedListBox CLBClass;
        private System.Windows.Forms.CheckedListBox CLBSchool;
        private System.Windows.Forms.CheckedListBox CLBLevel;
        private System.Windows.Forms.CheckedListBox CLBRitual;
        private System.Windows.Forms.CheckedListBox CLBCastingTime;
        private System.Windows.Forms.CheckedListBox CLBComponents;
        private System.Windows.Forms.CheckedListBox CLBConcentration;
    }
}

