namespace Cryptanalysis.View.Key_Entry_Views
{
	partial class TranspositionKeyEntryView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranspositionKeyEntryView));
			this.keyEntryGroupBox = new System.Windows.Forms.GroupBox();
			this.letterKeyTextBox = new System.Windows.Forms.TextBox();
			this.cipherDescriptionGroupBox = new System.Windows.Forms.GroupBox();
			this.cipherDescriptionLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.decryptButton = new System.Windows.Forms.Button();
			this.encryptButton = new System.Windows.Forms.Button();
			this.columnTranspositionRadioButton = new System.Windows.Forms.RadioButton();
			this.rowTranspositionRadioButton = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.irregularTableRadioButton = new System.Windows.Forms.RadioButton();
			this.completeTableRadioButton = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cipherAndTableSettingsDescriptionLabel = new System.Windows.Forms.Label();
			this.keyEntryGroupBox.SuspendLayout();
			this.cipherDescriptionGroupBox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// keyEntryGroupBox
			// 
			this.keyEntryGroupBox.Controls.Add(this.letterKeyTextBox);
			this.keyEntryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.keyEntryGroupBox.Location = new System.Drawing.Point(12, 238);
			this.keyEntryGroupBox.Name = "keyEntryGroupBox";
			this.keyEntryGroupBox.Size = new System.Drawing.Size(337, 54);
			this.keyEntryGroupBox.TabIndex = 13;
			this.keyEntryGroupBox.TabStop = false;
			this.keyEntryGroupBox.Text = "Zadejte klíč";
			// 
			// letterKeyTextBox
			// 
			this.letterKeyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.letterKeyTextBox.Location = new System.Drawing.Point(9, 21);
			this.letterKeyTextBox.Name = "letterKeyTextBox";
			this.letterKeyTextBox.Size = new System.Drawing.Size(311, 21);
			this.letterKeyTextBox.TabIndex = 7;
			this.letterKeyTextBox.TextChanged += new System.EventHandler(this.letterKeyTextBox_TextChanged);
			// 
			// cipherDescriptionGroupBox
			// 
			this.cipherDescriptionGroupBox.Controls.Add(this.cipherDescriptionLabel);
			this.cipherDescriptionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cipherDescriptionGroupBox.Location = new System.Drawing.Point(12, 3);
			this.cipherDescriptionGroupBox.Name = "cipherDescriptionGroupBox";
			this.cipherDescriptionGroupBox.Size = new System.Drawing.Size(337, 102);
			this.cipherDescriptionGroupBox.TabIndex = 12;
			this.cipherDescriptionGroupBox.TabStop = false;
			this.cipherDescriptionGroupBox.Text = "Popis";
			// 
			// cipherDescriptionLabel
			// 
			this.cipherDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cipherDescriptionLabel.Location = new System.Drawing.Point(6, 18);
			this.cipherDescriptionLabel.Name = "cipherDescriptionLabel";
			this.cipherDescriptionLabel.Size = new System.Drawing.Size(325, 81);
			this.cipherDescriptionLabel.TabIndex = 0;
			this.cipherDescriptionLabel.Text = resources.GetString("cipherDescriptionLabel.Text");
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.decryptButton);
			this.panel1.Controls.Add(this.encryptButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 316);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(361, 44);
			this.panel1.TabIndex = 11;
			// 
			// decryptButton
			// 
			this.decryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.decryptButton.Location = new System.Drawing.Point(208, 3);
			this.decryptButton.Name = "decryptButton";
			this.decryptButton.Size = new System.Drawing.Size(117, 35);
			this.decryptButton.TabIndex = 2;
			this.decryptButton.Text = "Dešifrovat";
			this.decryptButton.UseVisualStyleBackColor = true;
			this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
			// 
			// encryptButton
			// 
			this.encryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.encryptButton.Location = new System.Drawing.Point(40, 3);
			this.encryptButton.Name = "encryptButton";
			this.encryptButton.Size = new System.Drawing.Size(117, 35);
			this.encryptButton.TabIndex = 1;
			this.encryptButton.Text = "Šifrovat";
			this.encryptButton.UseVisualStyleBackColor = true;
			this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
			// 
			// columnTranspositionRadioButton
			// 
			this.columnTranspositionRadioButton.AutoSize = true;
			this.columnTranspositionRadioButton.Checked = true;
			this.columnTranspositionRadioButton.Location = new System.Drawing.Point(6, 19);
			this.columnTranspositionRadioButton.Name = "columnTranspositionRadioButton";
			this.columnTranspositionRadioButton.Size = new System.Drawing.Size(76, 17);
			this.columnTranspositionRadioButton.TabIndex = 14;
			this.columnTranspositionRadioButton.TabStop = true;
			this.columnTranspositionRadioButton.Text = "Sloupcová";
			this.columnTranspositionRadioButton.UseVisualStyleBackColor = true;
			this.columnTranspositionRadioButton.CheckedChanged += new System.EventHandler(this.columnTranspositionRadioButton_CheckedChanged);
			// 
			// rowTranspositionRadioButton
			// 
			this.rowTranspositionRadioButton.AutoSize = true;
			this.rowTranspositionRadioButton.Location = new System.Drawing.Point(6, 42);
			this.rowTranspositionRadioButton.Name = "rowTranspositionRadioButton";
			this.rowTranspositionRadioButton.Size = new System.Drawing.Size(69, 17);
			this.rowTranspositionRadioButton.TabIndex = 15;
			this.rowTranspositionRadioButton.Text = "Řádková";
			this.rowTranspositionRadioButton.UseVisualStyleBackColor = true;
			this.rowTranspositionRadioButton.CheckedChanged += new System.EventHandler(this.rowTranspositionRadioButton_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rowTranspositionRadioButton);
			this.groupBox1.Controls.Add(this.columnTranspositionRadioButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 111);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(102, 63);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Druh transpozice";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.irregularTableRadioButton);
			this.groupBox2.Controls.Add(this.completeTableRadioButton);
			this.groupBox2.Location = new System.Drawing.Point(129, 111);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(102, 63);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Druh tabulky";
			// 
			// irregularTableRadioButton
			// 
			this.irregularTableRadioButton.AutoSize = true;
			this.irregularTableRadioButton.Checked = true;
			this.irregularTableRadioButton.Location = new System.Drawing.Point(6, 42);
			this.irregularTableRadioButton.Name = "irregularTableRadioButton";
			this.irregularTableRadioButton.Size = new System.Drawing.Size(65, 17);
			this.irregularTableRadioButton.TabIndex = 15;
			this.irregularTableRadioButton.TabStop = true;
			this.irregularTableRadioButton.Text = "Neúplná";
			this.irregularTableRadioButton.UseVisualStyleBackColor = true;
			this.irregularTableRadioButton.CheckedChanged += new System.EventHandler(this.irregularTableRadioButton_CheckedChanged);
			// 
			// completeTableRadioButton
			// 
			this.completeTableRadioButton.AutoSize = true;
			this.completeTableRadioButton.Location = new System.Drawing.Point(6, 19);
			this.completeTableRadioButton.Name = "completeTableRadioButton";
			this.completeTableRadioButton.Size = new System.Drawing.Size(53, 17);
			this.completeTableRadioButton.TabIndex = 14;
			this.completeTableRadioButton.Text = "Úplná";
			this.completeTableRadioButton.UseVisualStyleBackColor = true;
			this.completeTableRadioButton.CheckedChanged += new System.EventHandler(this.completeTableRadioButton_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cipherAndTableSettingsDescriptionLabel);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox3.Location = new System.Drawing.Point(12, 180);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(337, 52);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Nastavení šifry a tabulky";
			// 
			// cipherAndTableSettingsDescriptionLabel
			// 
			this.cipherAndTableSettingsDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cipherAndTableSettingsDescriptionLabel.Location = new System.Drawing.Point(6, 18);
			this.cipherAndTableSettingsDescriptionLabel.Name = "cipherAndTableSettingsDescriptionLabel";
			this.cipherAndTableSettingsDescriptionLabel.Size = new System.Drawing.Size(325, 34);
			this.cipherAndTableSettingsDescriptionLabel.TabIndex = 0;
			this.cipherAndTableSettingsDescriptionLabel.Text = "x";
			// 
			// TranspositionKeyEntryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 360);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.keyEntryGroupBox);
			this.Controls.Add(this.cipherDescriptionGroupBox);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "TranspositionKeyEntryView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Nastavení klíče";
			this.keyEntryGroupBox.ResumeLayout(false);
			this.keyEntryGroupBox.PerformLayout();
			this.cipherDescriptionGroupBox.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox keyEntryGroupBox;
		public System.Windows.Forms.TextBox letterKeyTextBox;
		private System.Windows.Forms.GroupBox cipherDescriptionGroupBox;
		private System.Windows.Forms.Label cipherDescriptionLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button decryptButton;
		private System.Windows.Forms.Button encryptButton;
		private System.Windows.Forms.RadioButton columnTranspositionRadioButton;
		private System.Windows.Forms.RadioButton rowTranspositionRadioButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton irregularTableRadioButton;
		private System.Windows.Forms.RadioButton completeTableRadioButton;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label cipherAndTableSettingsDescriptionLabel;
	}
}