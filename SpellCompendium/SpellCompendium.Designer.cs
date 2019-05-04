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
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.School = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ritual = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CastingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concentration = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.DGVSpellList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Class,
            this.School,
            this.Level,
            this.Ritual,
            this.CastingTime,
            this.Range,
            this.Component,
            this.Concentration,
            this.Duration});
            this.DGVSpellList.Location = new System.Drawing.Point(12, 106);
            this.DGVSpellList.Name = "DGVSpellList";
            this.DGVSpellList.ReadOnly = true;
            this.DGVSpellList.RowTemplate.Height = 24;
            this.DGVSpellList.Size = new System.Drawing.Size(1008, 332);
            this.DGVSpellList.TabIndex = 0;
            this.DGVSpellList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSpellList_CellDoubleClick);
            // 
            // Class
            // 
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // School
            // 
            this.School.HeaderText = "School";
            this.School.Name = "School";
            this.School.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // Ritual
            // 
            this.Ritual.HeaderText = "Ritual";
            this.Ritual.Name = "Ritual";
            this.Ritual.ReadOnly = true;
            this.Ritual.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ritual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CastingTime
            // 
            this.CastingTime.HeaderText = "Casting Time";
            this.CastingTime.Name = "CastingTime";
            this.CastingTime.ReadOnly = true;
            // 
            // Range
            // 
            this.Range.HeaderText = "Range";
            this.Range.Name = "Range";
            this.Range.ReadOnly = true;
            // 
            // Component
            // 
            this.Component.HeaderText = "Component";
            this.Component.Name = "Component";
            this.Component.ReadOnly = true;
            // 
            // Concentration
            // 
            this.Concentration.HeaderText = "Concentration";
            this.Concentration.Name = "Concentration";
            this.Concentration.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // LBLClass
            // 
            this.LBLClass.AutoSize = true;
            this.LBLClass.Location = new System.Drawing.Point(9, 16);
            this.LBLClass.Name = "LBLClass";
            this.LBLClass.Size = new System.Drawing.Size(42, 17);
            this.LBLClass.TabIndex = 8;
            this.LBLClass.Text = "Class";
            // 
            // LBLSchool
            // 
            this.LBLSchool.AutoSize = true;
            this.LBLSchool.Location = new System.Drawing.Point(135, 16);
            this.LBLSchool.Name = "LBLSchool";
            this.LBLSchool.Size = new System.Drawing.Size(51, 17);
            this.LBLSchool.TabIndex = 9;
            this.LBLSchool.Text = "School";
            // 
            // LBLLevel
            // 
            this.LBLLevel.AutoSize = true;
            this.LBLLevel.Location = new System.Drawing.Point(316, 16);
            this.LBLLevel.Name = "LBLLevel";
            this.LBLLevel.Size = new System.Drawing.Size(42, 17);
            this.LBLLevel.TabIndex = 10;
            this.LBLLevel.Text = "Level";
            // 
            // LBLRitual
            // 
            this.LBLRitual.AutoSize = true;
            this.LBLRitual.Location = new System.Drawing.Point(442, 16);
            this.LBLRitual.Name = "LBLRitual";
            this.LBLRitual.Size = new System.Drawing.Size(44, 17);
            this.LBLRitual.TabIndex = 11;
            this.LBLRitual.Text = "Ritual";
            // 
            // LBLCastingTime
            // 
            this.LBLCastingTime.AutoSize = true;
            this.LBLCastingTime.Location = new System.Drawing.Point(568, 16);
            this.LBLCastingTime.Name = "LBLCastingTime";
            this.LBLCastingTime.Size = new System.Drawing.Size(90, 17);
            this.LBLCastingTime.TabIndex = 12;
            this.LBLCastingTime.Text = "Casting Time";
            // 
            // LBLComponents
            // 
            this.LBLComponents.AutoSize = true;
            this.LBLComponents.Location = new System.Drawing.Point(737, 16);
            this.LBLComponents.Name = "LBLComponents";
            this.LBLComponents.Size = new System.Drawing.Size(87, 17);
            this.LBLComponents.TabIndex = 13;
            this.LBLComponents.Text = "Components";
            // 
            // LBLConcentration
            // 
            this.LBLConcentration.AutoSize = true;
            this.LBLConcentration.Location = new System.Drawing.Point(863, 16);
            this.LBLConcentration.Name = "LBLConcentration";
            this.LBLConcentration.Size = new System.Drawing.Size(96, 17);
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
            this.CLBClass.Location = new System.Drawing.Point(12, 36);
            this.CLBClass.Name = "CLBClass";
            this.CLBClass.Size = new System.Drawing.Size(120, 55);
            this.CLBClass.TabIndex = 15;
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
            this.CLBSchool.Location = new System.Drawing.Point(138, 36);
            this.CLBSchool.Name = "CLBSchool";
            this.CLBSchool.Size = new System.Drawing.Size(175, 55);
            this.CLBSchool.TabIndex = 16;
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
            this.CLBLevel.Location = new System.Drawing.Point(319, 36);
            this.CLBLevel.Name = "CLBLevel";
            this.CLBLevel.Size = new System.Drawing.Size(120, 55);
            this.CLBLevel.TabIndex = 17;
            // 
            // CLBRitual
            // 
            this.CLBRitual.FormattingEnabled = true;
            this.CLBRitual.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CLBRitual.Location = new System.Drawing.Point(445, 36);
            this.CLBRitual.Name = "CLBRitual";
            this.CLBRitual.Size = new System.Drawing.Size(120, 55);
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
            this.CLBCastingTime.Location = new System.Drawing.Point(571, 36);
            this.CLBCastingTime.Name = "CLBCastingTime";
            this.CLBCastingTime.Size = new System.Drawing.Size(163, 55);
            this.CLBCastingTime.TabIndex = 19;
            // 
            // CLBComponents
            // 
            this.CLBComponents.FormattingEnabled = true;
            this.CLBComponents.Items.AddRange(new object[] {
            "Verbal",
            "Somatic",
            "Material"});
            this.CLBComponents.Location = new System.Drawing.Point(740, 36);
            this.CLBComponents.Name = "CLBComponents";
            this.CLBComponents.Size = new System.Drawing.Size(120, 55);
            this.CLBComponents.TabIndex = 20;
            // 
            // CLBConcentration
            // 
            this.CLBConcentration.FormattingEnabled = true;
            this.CLBConcentration.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CLBConcentration.Location = new System.Drawing.Point(866, 36);
            this.CLBConcentration.Name = "CLBConcentration";
            this.CLBConcentration.Size = new System.Drawing.Size(120, 55);
            this.CLBConcentration.TabIndex = 21;
            // 
            // SpellCompendium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
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
            this.Name = "SpellCompendium";
            this.Text = "Spell Compendium";
            this.Load += new System.EventHandler(this.SpellCompendium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSpellList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVSpellList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn School;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ritual;
        private System.Windows.Forms.DataGridViewTextBoxColumn CastingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Range;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Concentration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
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

