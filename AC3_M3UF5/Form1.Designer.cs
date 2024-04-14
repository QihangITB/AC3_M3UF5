namespace AC3_M3UF5
{
    partial class managementForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupManagement = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textPopulation = new TextBox();
            labelConsumCapita = new Label();
            labelTotalConsum = new Label();
            labelEconomyConsum = new Label();
            labelDomesticConsum = new Label();
            comboRegion = new ComboBox();
            comboYear = new ComboBox();
            labelPopulation = new Label();
            labelRegion = new Label();
            labelYear = new Label();
            groupStats = new GroupBox();
            buttonClean = new Button();
            buttonSave = new Button();
            labelStatOne = new Label();
            labelStatTwo = new Label();
            labelStatThree = new Label();
            labelFour = new Label();
            labelResStatOne = new Label();
            labelResStatTwo = new Label();
            labelResStatThree = new Label();
            labelResStatFour = new Label();
            groupManagement.SuspendLayout();
            groupStats.SuspendLayout();
            SuspendLayout();
            // 
            // groupManagement
            // 
            groupManagement.Controls.Add(textBox4);
            groupManagement.Controls.Add(textBox3);
            groupManagement.Controls.Add(textBox2);
            groupManagement.Controls.Add(textBox1);
            groupManagement.Controls.Add(textPopulation);
            groupManagement.Controls.Add(labelConsumCapita);
            groupManagement.Controls.Add(labelTotalConsum);
            groupManagement.Controls.Add(labelEconomyConsum);
            groupManagement.Controls.Add(labelDomesticConsum);
            groupManagement.Controls.Add(comboRegion);
            groupManagement.Controls.Add(comboYear);
            groupManagement.Controls.Add(labelPopulation);
            groupManagement.Controls.Add(labelRegion);
            groupManagement.Controls.Add(labelYear);
            groupManagement.Location = new Point(26, 25);
            groupManagement.Name = "groupManagement";
            groupManagement.Size = new Size(398, 232);
            groupManagement.TabIndex = 0;
            groupManagement.TabStop = false;
            groupManagement.Text = "Region demographic data management";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(258, 183);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(258, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 11;
            // 
            // textPopulation
            // 
            textPopulation.Location = new Point(258, 56);
            textPopulation.Name = "textPopulation";
            textPopulation.Size = new Size(100, 23);
            textPopulation.TabIndex = 10;
            // 
            // labelConsumCapita
            // 
            labelConsumCapita.AutoSize = true;
            labelConsumCapita.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelConsumCapita.Location = new Point(59, 186);
            labelConsumCapita.Name = "labelConsumCapita";
            labelConsumCapita.Size = new Size(193, 15);
            labelConsumCapita.TabIndex = 9;
            labelConsumCapita.Text = "Domestic consumption per capita";
            // 
            // labelTotalConsum
            // 
            labelTotalConsum.AutoSize = true;
            labelTotalConsum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTotalConsum.Location = new Point(218, 157);
            labelTotalConsum.Name = "labelTotalConsum";
            labelTotalConsum.Size = new Size(34, 15);
            labelTotalConsum.TabIndex = 8;
            labelTotalConsum.Text = "Total";
            // 
            // labelEconomyConsum
            // 
            labelEconomyConsum.AutoSize = true;
            labelEconomyConsum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelEconomyConsum.Location = new Point(44, 126);
            labelEconomyConsum.Name = "labelEconomyConsum";
            labelEconomyConsum.Size = new Size(208, 15);
            labelEconomyConsum.TabIndex = 7;
            labelEconomyConsum.Text = "Economic activities and own sources";
            // 
            // labelDomesticConsum
            // 
            labelDomesticConsum.AutoSize = true;
            labelDomesticConsum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelDomesticConsum.Location = new Point(141, 97);
            labelDomesticConsum.Name = "labelDomesticConsum";
            labelDomesticConsum.Size = new Size(111, 15);
            labelDomesticConsum.TabIndex = 6;
            labelDomesticConsum.Text = "Domestic network";
            // 
            // comboRegion
            // 
            comboRegion.FormattingEnabled = true;
            comboRegion.Location = new Point(135, 56);
            comboRegion.Name = "comboRegion";
            comboRegion.Size = new Size(93, 23);
            comboRegion.TabIndex = 4;
            // 
            // comboYear
            // 
            comboYear.FormattingEnabled = true;
            comboYear.Location = new Point(32, 56);
            comboYear.Name = "comboYear";
            comboYear.Size = new Size(78, 23);
            comboYear.TabIndex = 3;
            // 
            // labelPopulation
            // 
            labelPopulation.AutoSize = true;
            labelPopulation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPopulation.Location = new Point(258, 38);
            labelPopulation.Name = "labelPopulation";
            labelPopulation.Size = new Size(66, 15);
            labelPopulation.TabIndex = 2;
            labelPopulation.Text = "Population";
            // 
            // labelRegion
            // 
            labelRegion.AutoSize = true;
            labelRegion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelRegion.Location = new Point(135, 38);
            labelRegion.Name = "labelRegion";
            labelRegion.Size = new Size(46, 15);
            labelRegion.TabIndex = 1;
            labelRegion.Text = "Region";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.BackColor = SystemColors.Control;
            labelYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelYear.Location = new Point(32, 38);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(31, 15);
            labelYear.TabIndex = 0;
            labelYear.Text = "Year";
            // 
            // groupStats
            // 
            groupStats.Controls.Add(labelResStatFour);
            groupStats.Controls.Add(labelResStatThree);
            groupStats.Controls.Add(labelResStatTwo);
            groupStats.Controls.Add(labelResStatOne);
            groupStats.Controls.Add(labelFour);
            groupStats.Controls.Add(labelStatThree);
            groupStats.Controls.Add(labelStatTwo);
            groupStats.Controls.Add(labelStatOne);
            groupStats.Location = new Point(440, 25);
            groupStats.Name = "groupStats";
            groupStats.Size = new Size(335, 172);
            groupStats.TabIndex = 1;
            groupStats.TabStop = false;
            groupStats.Text = "Region statistics";
            // 
            // buttonClean
            // 
            buttonClean.Location = new Point(217, 263);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(95, 33);
            buttonClean.TabIndex = 2;
            buttonClean.Text = "Clean";
            buttonClean.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(329, 263);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(95, 33);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelStatOne
            // 
            labelStatOne.AutoSize = true;
            labelStatOne.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelStatOne.Location = new Point(107, 38);
            labelStatOne.Name = "labelStatOne";
            labelStatOne.Size = new Size(144, 15);
            labelStatOne.TabIndex = 15;
            labelStatOne.Text = "Population > 20000 hab.:";
            // 
            // labelStatTwo
            // 
            labelStatTwo.AutoSize = true;
            labelStatTwo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelStatTwo.Location = new Point(62, 64);
            labelStatTwo.Name = "labelStatTwo";
            labelStatTwo.Size = new Size(189, 15);
            labelStatTwo.TabIndex = 16;
            labelStatTwo.Text = "Average Domestic Consumption:";
            // 
            // labelStatThree
            // 
            labelStatThree.AutoSize = true;
            labelStatThree.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelStatThree.Location = new Point(16, 94);
            labelStatThree.Name = "labelStatThree";
            labelStatThree.Size = new Size(235, 15);
            labelStatThree.TabIndex = 17;
            labelStatThree.Text = "Higher domestic consumption per capita:";
            // 
            // labelFour
            // 
            labelFour.AutoSize = true;
            labelFour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelFour.Location = new Point(19, 123);
            labelFour.Name = "labelFour";
            labelFour.Size = new Size(232, 15);
            labelFour.TabIndex = 18;
            labelFour.Text = "Lower domestic consumption per capita:";
            // 
            // labelResStatOne
            // 
            labelResStatOne.AutoSize = true;
            labelResStatOne.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelResStatOne.ForeColor = Color.Blue;
            labelResStatOne.Location = new Point(288, 38);
            labelResStatOne.Name = "labelResStatOne";
            labelResStatOne.Size = new Size(12, 15);
            labelResStatOne.TabIndex = 16;
            labelResStatOne.Text = "-";
            // 
            // labelResStatTwo
            // 
            labelResStatTwo.AutoSize = true;
            labelResStatTwo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelResStatTwo.ForeColor = Color.Blue;
            labelResStatTwo.Location = new Point(288, 64);
            labelResStatTwo.Name = "labelResStatTwo";
            labelResStatTwo.Size = new Size(12, 15);
            labelResStatTwo.TabIndex = 19;
            labelResStatTwo.Text = "-";
            // 
            // labelResStatThree
            // 
            labelResStatThree.AutoSize = true;
            labelResStatThree.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelResStatThree.ForeColor = Color.Blue;
            labelResStatThree.Location = new Point(288, 94);
            labelResStatThree.Name = "labelResStatThree";
            labelResStatThree.Size = new Size(12, 15);
            labelResStatThree.TabIndex = 20;
            labelResStatThree.Text = "-";
            // 
            // labelResStatFour
            // 
            labelResStatFour.AutoSize = true;
            labelResStatFour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelResStatFour.ForeColor = Color.Blue;
            labelResStatFour.Location = new Point(288, 123);
            labelResStatFour.Name = "labelResStatFour";
            labelResStatFour.Size = new Size(12, 15);
            labelResStatFour.TabIndex = 21;
            labelResStatFour.Text = "-";
            // 
            // managementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(buttonClean);
            Controls.Add(groupStats);
            Controls.Add(groupManagement);
            Name = "managementForm";
            Text = "Region demographic data management";
            groupManagement.ResumeLayout(false);
            groupManagement.PerformLayout();
            groupStats.ResumeLayout(false);
            groupStats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupManagement;
        private GroupBox groupStats;
        private Label labelPopulation;
        private Label labelRegion;
        private Label labelYear;
        private Label labelDomesticConsum;
        private ComboBox comboRegion;
        private ComboBox comboYear;
        private Label labelEconomyConsum;
        private Label labelTotalConsum;
        private Label labelConsumCapita;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textPopulation;
        private Button buttonClean;
        private Label labelStatThree;
        private Label labelStatTwo;
        private Label labelStatOne;
        private Button buttonSave;
        private Label labelResStatThree;
        private Label labelResStatTwo;
        private Label labelResStatOne;
        private Label labelFour;
        private Label labelResStatFour;
    }
}
