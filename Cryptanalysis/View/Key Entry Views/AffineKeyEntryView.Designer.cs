namespace Cryptanalysis.View.Key_Entry_Views
{
	partial class AffineKeyEntryView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffineKeyEntryView));
			this.keyPropertiesGroupBox = new System.Windows.Forms.GroupBox();
			this.toAlphabetTextBox = new System.Windows.Forms.TextBox();
			this.fromAlphabetTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.keyEntryGroupBox = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.setBKeyTextBox = new System.Windows.Forms.TextBox();
			this.setAKeyTextBox = new System.Windows.Forms.TextBox();
			this.cipherDescriptionGroupBox = new System.Windows.Forms.GroupBox();
			this.cipherDescriptionLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.decryptButton = new System.Windows.Forms.Button();
			this.encryptButton = new System.Windows.Forms.Button();
			this.keyPropertiesGroupBox.SuspendLayout();
			this.keyEntryGroupBox.SuspendLayout();
			this.cipherDescriptionGroupBox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// keyPropertiesGroupBox
			// 
			this.keyPropertiesGroupBox.Controls.Add(this.toAlphabetTextBox);
			this.keyPropertiesGroupBox.Controls.Add(this.fromAlphabetTextBox);
			this.keyPropertiesGroupBox.Controls.Add(this.label3);
			this.keyPropertiesGroupBox.Controls.Add(this.label2);
			this.keyPropertiesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.keyPropertiesGroupBox.Location = new System.Drawing.Point(12, 211);
			this.keyPropertiesGroupBox.Name = "keyPropertiesGroupBox";
			this.keyPropertiesGroupBox.Size = new System.Drawing.Size(337, 75);
			this.keyPropertiesGroupBox.TabIndex = 11;
			this.keyPropertiesGroupBox.TabStop = false;
			this.keyPropertiesGroupBox.Text = "Popis nastavení klíče";
			// 
			// toAlphabetTextBox
			// 
			this.toAlphabetTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.toAlphabetTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.toAlphabetTextBox.Location = new System.Drawing.Point(108, 47);
			this.toAlphabetTextBox.Name = "toAlphabetTextBox";
			this.toAlphabetTextBox.ReadOnly = true;
			this.toAlphabetTextBox.Size = new System.Drawing.Size(223, 21);
			this.toAlphabetTextBox.TabIndex = 8;
			// 
			// fromAlphabetTextBox
			// 
			this.fromAlphabetTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.fromAlphabetTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.fromAlphabetTextBox.Location = new System.Drawing.Point(108, 22);
			this.fromAlphabetTextBox.Name = "fromAlphabetTextBox";
			this.fromAlphabetTextBox.ReadOnly = true;
			this.fromAlphabetTextBox.Size = new System.Drawing.Size(223, 21);
			this.fromAlphabetTextBox.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Do";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Z";
			// 
			// keyEntryGroupBox
			// 
			this.keyEntryGroupBox.Controls.Add(this.label4);
			this.keyEntryGroupBox.Controls.Add(this.label1);
			this.keyEntryGroupBox.Controls.Add(this.setBKeyTextBox);
			this.keyEntryGroupBox.Controls.Add(this.setAKeyTextBox);
			this.keyEntryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.keyEntryGroupBox.Location = new System.Drawing.Point(12, 124);
			this.keyEntryGroupBox.Name = "keyEntryGroupBox";
			this.keyEntryGroupBox.Size = new System.Drawing.Size(337, 81);
			this.keyEntryGroupBox.TabIndex = 10;
			this.keyEntryGroupBox.TabStop = false;
			this.keyEntryGroupBox.Text = "Zadejte klíč";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "b";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 15);
			this.label1.TabIndex = 7;
			this.label1.Text = "a";
			// 
			// setBKeyTextBox
			// 
			this.setBKeyTextBox.Location = new System.Drawing.Point(33, 48);
			this.setBKeyTextBox.MaxLength = 2;
			this.setBKeyTextBox.Name = "setBKeyTextBox";
			this.setBKeyTextBox.Size = new System.Drawing.Size(23, 21);
			this.setBKeyTextBox.TabIndex = 6;
			this.setBKeyTextBox.Text = "7";
			this.setBKeyTextBox.TextChanged += new System.EventHandler(this.setBKeyTextBox_TextChanged);
			// 
			// setAKeyTextBox
			// 
			this.setAKeyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.setAKeyTextBox.Location = new System.Drawing.Point(33, 22);
			this.setAKeyTextBox.MaxLength = 2;
			this.setAKeyTextBox.Name = "setAKeyTextBox";
			this.setAKeyTextBox.Size = new System.Drawing.Size(23, 21);
			this.setAKeyTextBox.TabIndex = 4;
			this.setAKeyTextBox.Text = "3";
			this.setAKeyTextBox.TextChanged += new System.EventHandler(this.setAKeyTextBox_TextChanged);
			// 
			// cipherDescriptionGroupBox
			// 
			this.cipherDescriptionGroupBox.Controls.Add(this.cipherDescriptionLabel);
			this.cipherDescriptionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cipherDescriptionGroupBox.Location = new System.Drawing.Point(12, 6);
			this.cipherDescriptionGroupBox.Name = "cipherDescriptionGroupBox";
			this.cipherDescriptionGroupBox.Size = new System.Drawing.Size(337, 115);
			this.cipherDescriptionGroupBox.TabIndex = 9;
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
			this.panel1.Location = new System.Drawing.Point(0, 291);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(361, 44);
			this.panel1.TabIndex = 8;
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
			// AffineKeyEntryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 335);
			this.Controls.Add(this.keyPropertiesGroupBox);
			this.Controls.Add(this.keyEntryGroupBox);
			this.Controls.Add(this.cipherDescriptionGroupBox);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MinimumSize = new System.Drawing.Size(361, 335);
			this.Name = "AffineKeyEntryView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Nastavení klíče";
			this.keyPropertiesGroupBox.ResumeLayout(false);
			this.keyPropertiesGroupBox.PerformLayout();
			this.keyEntryGroupBox.ResumeLayout(false);
			this.keyEntryGroupBox.PerformLayout();
			this.cipherDescriptionGroupBox.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox keyPropertiesGroupBox;
		public System.Windows.Forms.TextBox toAlphabetTextBox;
		public System.Windows.Forms.TextBox fromAlphabetTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox keyEntryGroupBox;
		private System.Windows.Forms.TextBox setBKeyTextBox;
		private System.Windows.Forms.TextBox setAKeyTextBox;
		private System.Windows.Forms.GroupBox cipherDescriptionGroupBox;
		private System.Windows.Forms.Label cipherDescriptionLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button decryptButton;
		private System.Windows.Forms.Button encryptButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
	}
}