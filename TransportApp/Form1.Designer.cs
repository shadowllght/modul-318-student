namespace TransportApp
{
    partial class app
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titel = new System.Windows.Forms.Label();
            this.standortText = new System.Windows.Forms.TextBox();
            this.standortLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.destinationText = new System.Windows.Forms.TextBox();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.listBoxStandort = new System.Windows.Forms.ListBox();
            this.buttonSuche = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.darkButton = new System.Windows.Forms.Button();
            this.listBoxDestination = new System.Windows.Forms.ListBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBoxAn = new System.Windows.Forms.CheckBox();
            this.checkBoxAb = new System.Windows.Forms.CheckBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titel.Location = new System.Drawing.Point(131, 9);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(260, 39);
            this.Titel.TabIndex = 0;
            this.Titel.Text = "ÖV Applikation";
            // 
            // standortText
            // 
            this.standortText.Location = new System.Drawing.Point(12, 88);
            this.standortText.Name = "standortText";
            this.standortText.Size = new System.Drawing.Size(172, 20);
            this.standortText.TabIndex = 1;
            this.standortText.TextChanged += new System.EventHandler(this.StandortText_TextChanged);
            // 
            // standortLabel
            // 
            this.standortLabel.AutoSize = true;
            this.standortLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standortLabel.Location = new System.Drawing.Point(12, 72);
            this.standortLabel.Name = "standortLabel";
            this.standortLabel.Size = new System.Drawing.Size(47, 13);
            this.standortLabel.TabIndex = 2;
            this.standortLabel.Text = "Standort";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(383, 72);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(60, 13);
            this.destinationLabel.TabIndex = 4;
            this.destinationLabel.Text = "Destination";
            // 
            // destinationText
            // 
            this.destinationText.Location = new System.Drawing.Point(386, 88);
            this.destinationText.Name = "destinationText";
            this.destinationText.Size = new System.Drawing.Size(172, 20);
            this.destinationText.TabIndex = 3;
            this.destinationText.TextChanged += new System.EventHandler(this.DestinationText_TextChanged);
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Location = new System.Drawing.Point(249, 81);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(57, 33);
            this.buttonSwitch.TabIndex = 5;
            this.buttonSwitch.Text = "<->";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.ButtonSwitch_Click);
            // 
            // listBoxStandort
            // 
            this.listBoxStandort.FormattingEnabled = true;
            this.listBoxStandort.Location = new System.Drawing.Point(12, 120);
            this.listBoxStandort.Name = "listBoxStandort";
            this.listBoxStandort.Size = new System.Drawing.Size(172, 147);
            this.listBoxStandort.TabIndex = 6;
            this.listBoxStandort.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxStandort_MouseDoubleClick);
            // 
            // buttonSuche
            // 
            this.buttonSuche.Location = new System.Drawing.Point(238, 202);
            this.buttonSuche.Name = "buttonSuche";
            this.buttonSuche.Size = new System.Drawing.Size(79, 65);
            this.buttonSuche.TabIndex = 8;
            this.buttonSuche.Text = "Suche";
            this.buttonSuche.UseVisualStyleBackColor = true;
            this.buttonSuche.Click += new System.EventHandler(this.ButtonSuche_Click);
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "yyyy-MM-dd";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(278, 133);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(95, 20);
            this.datePicker.TabIndex = 9;
            // 
            // darkButton
            // 
            this.darkButton.Location = new System.Drawing.Point(429, 21);
            this.darkButton.Name = "darkButton";
            this.darkButton.Size = new System.Drawing.Size(82, 30);
            this.darkButton.TabIndex = 10;
            this.darkButton.Text = "Dark mode";
            this.darkButton.UseVisualStyleBackColor = true;
            this.darkButton.Click += new System.EventHandler(this.darkButton_Click);
            // 
            // listBoxDestination
            // 
            this.listBoxDestination.FormattingEnabled = true;
            this.listBoxDestination.Location = new System.Drawing.Point(386, 120);
            this.listBoxDestination.Name = "listBoxDestination";
            this.listBoxDestination.Size = new System.Drawing.Size(172, 147);
            this.listBoxDestination.TabIndex = 11;
            this.listBoxDestination.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxDestination_MouseDoubleClick);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(199, 133);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(57, 20);
            this.timePicker.TabIndex = 13;
            // 
            // checkBoxAn
            // 
            this.checkBoxAn.AutoSize = true;
            this.checkBoxAn.Location = new System.Drawing.Point(278, 170);
            this.checkBoxAn.Name = "checkBoxAn";
            this.checkBoxAn.Size = new System.Drawing.Size(39, 17);
            this.checkBoxAn.TabIndex = 14;
            this.checkBoxAn.Text = "An";
            this.checkBoxAn.UseVisualStyleBackColor = true;
            this.checkBoxAn.Click += new System.EventHandler(this.CheckBoxAn_CheckedChanged);
            // 
            // checkBoxAb
            // 
            this.checkBoxAb.AutoSize = true;
            this.checkBoxAb.Location = new System.Drawing.Point(238, 170);
            this.checkBoxAb.Name = "checkBoxAb";
            this.checkBoxAb.Size = new System.Drawing.Size(39, 17);
            this.checkBoxAb.TabIndex = 15;
            this.checkBoxAb.Text = "Ab";
            this.checkBoxAb.UseVisualStyleBackColor = true;
            this.checkBoxAb.Click += new System.EventHandler(this.CheckBoxAb_CheckedChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Von,
            this.Nach,
            this.Abfahrtszeit,
            this.Ankunftszeit,
            this.Dauer});
            this.dataGridView.Location = new System.Drawing.Point(12, 292);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(546, 117);
            this.dataGridView.TabIndex = 16;
            // 
            // Von
            // 
            this.Von.HeaderText = "Von";
            this.Von.Name = "Von";
            // 
            // Nach
            // 
            this.Nach.HeaderText = "Nach";
            this.Nach.Name = "Nach";
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.HeaderText = "Abfahrtszeit";
            this.Abfahrtszeit.Name = "Abfahrtszeit";
            // 
            // Ankunftszeit
            // 
            this.Ankunftszeit.HeaderText = "Ankuftszeit";
            this.Ankunftszeit.Name = "Ankunftszeit";
            // 
            // Dauer
            // 
            this.Dauer.HeaderText = "Dauer";
            this.Dauer.Name = "Dauer";
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 446);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.checkBoxAb);
            this.Controls.Add(this.checkBoxAn);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.listBoxDestination);
            this.Controls.Add(this.darkButton);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.buttonSuche);
            this.Controls.Add(this.listBoxStandort);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.destinationText);
            this.Controls.Add(this.standortLabel);
            this.Controls.Add(this.standortText);
            this.Controls.Add(this.Titel);
            this.Name = "app";
            this.Text = "ÖV Applikation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.TextBox standortText;
        private System.Windows.Forms.Label standortLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.TextBox destinationText;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.ListBox listBoxStandort;
        private System.Windows.Forms.Button buttonSuche;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button darkButton;
        private System.Windows.Forms.ListBox listBoxDestination;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.CheckBox checkBoxAn;
        private System.Windows.Forms.CheckBox checkBoxAb;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Von;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
    }
}

