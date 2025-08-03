namespace Cryptanalysis.View.Key_Entry
{
	partial class CaesarKeyEntryView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaesarKeyEntryView));
			this.keyEntryGroupBox = new System.Windows.Forms.GroupBox();
			this.setKeyAsNumberTextBox = new System.Windows.Forms.TextBox();
			this.setKeyAsNumberRadioButton = new System.Windows.Forms.RadioButton();
			this.setKeyAsCharTextBox = new System.Windows.Forms.TextBox();
			this.setKeyAsCharRadioButton = new System.Windows.Forms.RadioButton();
			this.cipherDescriptionGroupBox = new System.Windows.Forms.GroupBox();
			this.cipherDescriptionLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.decryptButton = new System.Windows.Forms.Button();
			this.encryptButton = new System.Windows.Forms.Button();
			this.keyPropertiesGroupBox = new System.Windows.Forms.GroupBox();
			this.toAlphabetTextBox = new System.Windows.Forms.TextBox();
			this.fromAlphabetTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.shiftValueLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.keyEntryGroupBox.SuspendLayout();
			this.cipherDescriptionGroupBox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.keyPropertiesGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// keyEntryGroupBox
			// 
			this.keyEntryGroupBox.Controls.Add(this.setKeyAsNumberTextBox);
			this.keyEntryGroupBox.Controls.Add(this.setKeyAsNumberRadioButton);
			this.keyEntryGroupBox.Controls.Add(this.setKeyAsCharTextBox);
			this.keyEntryGroupBox.Controls.Add(this.setKeyAsCharRadioButton);
			this.keyEntryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.keyEntryGroupBox.Location = new System.Drawing.Point(12, 130);
			this.keyEntryGroupBox.Name = "keyEntryGroupBox";
			this.keyEntryGroupBox.Size = new System.Drawing.Size(337, 81);
			this.keyEntryGroupBox.TabIndex = 5;
			this.keyEntryGroupBox.TabStop = false;
			this.keyEntryGroupBox.Text = "Zadání klíče jako";
			// 
			// setKeyAsNumberTextBox
			// 
			this.setKeyAsNumberTextBox.Location = new System.Drawing.Point(97, 48);
			this.setKeyAsNumberTextBox.MaxLength = 2;
			this.setKeyAsNumberTextBox.Name = "setKeyAsNumberTextBox";
			this.setKeyAsNumberTextBox.ReadOnly = true;
			this.setKeyAsNumberTextBox.Size = new System.Drawing.Size(23, 21);
			this.setKeyAsNumberTextBox.TabIndex = 6;
			this.setKeyAsNumberTextBox.Text = "1";
			this.setKeyAsNumberTextBox.TextChanged += new System.EventHandler(this.setKeyAsNumberTextBox_TextChanged);
			// 
			// setKeyAsNumberRadioButton
			// 
			this.setKeyAsNumberRadioButton.AutoSize = true;
			this.setKeyAsNumberRadioButton.Location = new System.Drawing.Point(7, 48);
			this.setKeyAsNumberRadioButton.Name = "setKeyAsNumberRadioButton";
			this.setKeyAsNumberRadioButton.Size = new System.Drawing.Size(52, 19);
			this.setKeyAsNumberRadioButton.TabIndex = 5;
			this.setKeyAsNumberRadioButton.TabStop = true;
			this.setKeyAsNumberRadioButton.Text = "Číslo";
			this.setKeyAsNumberRadioButton.UseVisualStyleBackColor = true;
			// 
			// setKeyAsCharTextBox
			// 
			this.setKeyAsCharTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.setKeyAsCharTextBox.Location = new System.Drawing.Point(97, 22);
			this.setKeyAsCharTextBox.MaxLength = 1;
			this.setKeyAsCharTextBox.Name = "setKeyAsCharTextBox";
			this.setKeyAsCharTextBox.Size = new System.Drawing.Size(23, 21);
			this.setKeyAsCharTextBox.TabIndex = 4;
			this.setKeyAsCharTextBox.Text = "B";
			this.setKeyAsCharTextBox.TextChanged += new System.EventHandler(this.setKeyAsCharTextBox_TextChanged);
			// 
			// setKeyAsCharRadioButton
			// 
			this.setKeyAsCharRadioButton.AutoSize = true;
			this.setKeyAsCharRadioButton.Checked = true;
			this.setKeyAsCharRadioButton.Location = new System.Drawing.Point(7, 22);
			this.setKeyAsCharRadioButton.Name = "setKeyAsCharRadioButton";
			this.setKeyAsCharRadioButton.Size = new System.Drawing.Size(74, 19);
			this.setKeyAsCharRadioButton.TabIndex = 3;
			this.setKeyAsCharRadioButton.TabStop = true;
			this.setKeyAsCharRadioButton.Text = "Písmeno";
			this.setKeyAsCharRadioButton.UseVisualStyleBackColor = true;
			this.setKeyAsCharRadioButton.CheckedChanged += new System.EventHandler(this.setKeyAsCharRadioButton_CheckedChanged);
			// 
			// cipherDescriptionGroupBox
			// 
			this.cipherDescriptionGroupBox.Controls.Add(this.cipherDescriptionLabel);
			this.cipherDescriptionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cipherDescriptionGroupBox.Location = new System.Drawing.Point(12, 12);
			this.cipherDescriptionGroupBox.Name = "cipherDescriptionGroupBox";
			this.cipherDescriptionGroupBox.Size = new System.Drawing.Size(337, 115);
			this.cipherDescriptionGroupBox.TabIndex = 4;
			this.cipherDescriptionGroupBox.TabStop = false;
			this.cipherDescriptionGroupBox.Text = "Popis";
			// 
			// cipherDescriptionLabel
			// 
			this.cipherDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cipherDescriptionLabel.Location = new System.Drawing.Point(6, 18);
			this.cipherDescriptionLabel.Name = "cipherDescriptionLabel";
			this.cipherDescriptionLabel.Size = new System.Drawing.Size(325, 98);
			this.cipherDescriptionLabel.TabIndex = 0;
			this.cipherDescriptionLabel.Text = resources.GetString("cipherDescriptionLabel.Text");
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.decryptButton);
			this.panel1.Controls.Add(this.encryptButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 327);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(361, 44);
			this.panel1.TabIndex = 3;
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
			// keyPropertiesGroupBox
			// 
			this.keyPropertiesGroupBox.Controls.Add(this.toAlphabetTextBox);
			this.keyPropertiesGroupBox.Controls.Add(this.fromAlphabetTextBox);
			this.keyPropertiesGroupBox.Controls.Add(this.label3);
			this.keyPropertiesGroupBox.Controls.Add(this.label2);
			this.keyPropertiesGroupBox.Controls.Add(this.shiftValueLabel);
			this.keyPropertiesGroupBox.Controls.Add(this.label1);
			this.keyPropertiesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.keyPropertiesGroupBox.Location = new System.Drawing.Point(12, 217);
			this.keyPropertiesGroupBox.Name = "keyPropertiesGroupBox";
			this.keyPropertiesGroupBox.Size = new System.Drawing.Size(337, 99);
			this.keyPropertiesGroupBox.TabIndex = 7;
			this.keyPropertiesGroupBox.TabStop = false;
			this.keyPropertiesGroupBox.Text = "Popis nastavení klíče";
			// 
			// toAlphabetTextBox
			// 
			this.toAlphabetTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.toAlphabetTextBox.Font = new System.Drawing.Font("Courier New", 9F);
			this.toAlphabetTextBox.Location = new System.Drawing.Point(108, 71);
			this.toAlphabetTextBox.Name = "toAlphabetTextBox";
			this.toAlphabetTextBox.ReadOnly = true;
			this.toAlphabetTextBox.Size = new System.Drawing.Size(223, 21);
			this.toAlphabetTextBox.TabIndex = 8;
			// 
			// fromAlphabetTextBox
			// 
			this.fromAlphabetTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.fromAlphabetTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.fromAlphabetTextBox.Location = new System.Drawing.Point(108, 46);
			this.fromAlphabetTextBox.Name = "fromAlphabetTextBox";
			this.fromAlphabetTextBox.ReadOnly = true;
			this.fromAlphabetTextBox.Size = new System.Drawing.Size(223, 21);
			this.fromAlphabetTextBox.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Do";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Z";
			// 
			// shiftValueLabel
			// 
			this.shiftValueLabel.AutoSize = true;
			this.shiftValueLabel.Location = new System.Drawing.Point(105, 25);
			this.shiftValueLabel.Name = "shiftValueLabel";
			this.shiftValueLabel.Size = new System.Drawing.Size(14, 15);
			this.shiftValueLabel.TabIndex = 1;
			this.shiftValueLabel.Text = "1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Velikost posunu";
			// 
			// CaesarKeyEntryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 371);
			this.Controls.Add(this.keyPropertiesGroupBox);
			this.Controls.Add(this.keyEntryGroupBox);
			this.Controls.Add(this.cipherDescriptionGroupBox);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "CaesarKeyEntryView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Nastavení klíče";
			this.keyEntryGroupBox.ResumeLayout(false);
			this.keyEntryGroupBox.PerformLayout();
			this.cipherDescriptionGroupBox.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.keyPropertiesGroupBox.ResumeLayout(false);
			this.keyPropertiesGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox keyEntryGroupBox;
		private System.Windows.Forms.TextBox setKeyAsNumberTextBox;
		private System.Windows.Forms.RadioButton setKeyAsNumberRadioButton;
		private System.Windows.Forms.TextBox setKeyAsCharTextBox;
		private System.Windows.Forms.RadioButton setKeyAsCharRadioButton;
		private System.Windows.Forms.GroupBox cipherDescriptionGroupBox;
		private System.Windows.Forms.Label cipherDescriptionLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button decryptButton;
		private System.Windows.Forms.Button encryptButton;
		private System.Windows.Forms.GroupBox keyPropertiesGroupBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label shiftValueLabel;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox toAlphabetTextBox;
		public System.Windows.Forms.TextBox fromAlphabetTextBox;
	}
}