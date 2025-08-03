namespace Cryptanalysis.View.Key_Entry_Views
{
	partial class SubstitutionKeyEntryView
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
			this.keyPropertiesGroupBox = new System.Windows.Forms.GroupBox();
			this.toAlphabetTextBox = new System.Windows.Forms.TextBox();
			this.fromAlphabetTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.keyEntryGroupBox = new System.Windows.Forms.GroupBox();
			this.randomPermutationButton = new System.Windows.Forms.Button();
			this.letterKeyTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
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
			this.keyPropertiesGroupBox.Location = new System.Drawing.Point(12, 180);
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
			this.toAlphabetTextBox.Location = new System.Drawing.Point(108, 45);
			this.toAlphabetTextBox.Name = "toAlphabetTextBox";
			this.toAlphabetTextBox.ReadOnly = true;
			this.toAlphabetTextBox.Size = new System.Drawing.Size(223, 21);
			this.toAlphabetTextBox.TabIndex = 8;
			// 
			// fromAlphabetTextBox
			// 
			this.fromAlphabetTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.fromAlphabetTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.fromAlphabetTextBox.Location = new System.Drawing.Point(108, 20);
			this.fromAlphabetTextBox.Name = "fromAlphabetTextBox";
			this.fromAlphabetTextBox.ReadOnly = true;
			this.fromAlphabetTextBox.Size = new System.Drawing.Size(223, 21);
			this.fromAlphabetTextBox.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Do";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Z";
			// 
			// keyEntryGroupBox
			// 
			this.keyEntryGroupBox.Controls.Add(this.randomPermutationButton);
			this.keyEntryGroupBox.Controls.Add(this.letterKeyTextBox);
			this.keyEntryGroupBox.Controls.Add(this.label1);
			this.keyEntryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.keyEntryGroupBox.Location = new System.Drawing.Point(12, 96);
			this.keyEntryGroupBox.Name = "keyEntryGroupBox";
			this.keyEntryGroupBox.Size = new System.Drawing.Size(337, 81);
			this.keyEntryGroupBox.TabIndex = 10;
			this.keyEntryGroupBox.TabStop = false;
			this.keyEntryGroupBox.Text = "Zadejte klíč";
			// 
			// randomPermutationButton
			// 
			this.randomPermutationButton.Location = new System.Drawing.Point(108, 52);
			this.randomPermutationButton.Name = "randomPermutationButton";
			this.randomPermutationButton.Size = new System.Drawing.Size(223, 23);
			this.randomPermutationButton.TabIndex = 9;
			this.randomPermutationButton.Text = "Vygeneruj náhodný klíč";
			this.randomPermutationButton.UseVisualStyleBackColor = true;
			this.randomPermutationButton.Click += new System.EventHandler(this.randomPermutationButton_Click);
			// 
			// letterKeyTextBox
			// 
			this.letterKeyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.letterKeyTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.letterKeyTextBox.Location = new System.Drawing.Point(108, 23);
			this.letterKeyTextBox.Name = "letterKeyTextBox";
			this.letterKeyTextBox.Size = new System.Drawing.Size(223, 21);
			this.letterKeyTextBox.TabIndex = 8;
			this.letterKeyTextBox.TextChanged += new System.EventHandler(this.letterKeyTextBox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 15);
			this.label1.TabIndex = 7;
			this.label1.Text = "Klíč";
			// 
			// cipherDescriptionGroupBox
			// 
			this.cipherDescriptionGroupBox.Controls.Add(this.cipherDescriptionLabel);
			this.cipherDescriptionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cipherDescriptionGroupBox.Location = new System.Drawing.Point(12, 6);
			this.cipherDescriptionGroupBox.Name = "cipherDescriptionGroupBox";
			this.cipherDescriptionGroupBox.Size = new System.Drawing.Size(337, 88);
			this.cipherDescriptionGroupBox.TabIndex = 9;
			this.cipherDescriptionGroupBox.TabStop = false;
			this.cipherDescriptionGroupBox.Text = "Popis";
			// 
			// cipherDescriptionLabel
			// 
			this.cipherDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cipherDescriptionLabel.Location = new System.Drawing.Point(6, 18);
			this.cipherDescriptionLabel.Name = "cipherDescriptionLabel";
			this.cipherDescriptionLabel.Size = new System.Drawing.Size(325, 65);
			this.cipherDescriptionLabel.TabIndex = 0;
			this.cipherDescriptionLabel.Text = "Zde se nastavuje klíč pro šifrování/dešifrování Obecnou substituční šifrou. Každý" +
    " znak otevřené abecedy je nahrazován za konkrétní znak šifrové abecedy. Klíčem j" +
    "e zde permutace otevřené abecedy. ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.decryptButton);
			this.panel1.Controls.Add(this.encryptButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 260);
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
			// SubstitutionKeyEntryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 304);
			this.Controls.Add(this.keyPropertiesGroupBox);
			this.Controls.Add(this.keyEntryGroupBox);
			this.Controls.Add(this.cipherDescriptionGroupBox);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "SubstitutionKeyEntryView";
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
		private System.Windows.Forms.GroupBox cipherDescriptionGroupBox;
		private System.Windows.Forms.Label cipherDescriptionLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button decryptButton;
		private System.Windows.Forms.Button encryptButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button randomPermutationButton;
		public System.Windows.Forms.TextBox letterKeyTextBox;
	}
}