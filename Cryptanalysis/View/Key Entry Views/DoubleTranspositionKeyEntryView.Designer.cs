namespace Cryptanalysis.View.Key_Entry_Views
{
	partial class DoubleTranspositionKeyEntryView
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
			this.keyEntryGroupBox = new System.Windows.Forms.GroupBox();
			this.firstLetterKeyTextBox = new System.Windows.Forms.TextBox();
			this.cipherDescriptionGroupBox = new System.Windows.Forms.GroupBox();
			this.cipherDescriptionLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.decryptButton = new System.Windows.Forms.Button();
			this.encryptButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.secondLetterKeyTextBox = new System.Windows.Forms.TextBox();
			this.keyEntryGroupBox.SuspendLayout();
			this.cipherDescriptionGroupBox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// keyEntryGroupBox
			// 
			this.keyEntryGroupBox.Controls.Add(this.firstLetterKeyTextBox);
			this.keyEntryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.keyEntryGroupBox.Location = new System.Drawing.Point(12, 110);
			this.keyEntryGroupBox.Name = "keyEntryGroupBox";
			this.keyEntryGroupBox.Size = new System.Drawing.Size(337, 54);
			this.keyEntryGroupBox.TabIndex = 21;
			this.keyEntryGroupBox.TabStop = false;
			this.keyEntryGroupBox.Text = "Klíč 1";
			// 
			// firstLetterKeyTextBox
			// 
			this.firstLetterKeyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.firstLetterKeyTextBox.Location = new System.Drawing.Point(9, 21);
			this.firstLetterKeyTextBox.Name = "firstLetterKeyTextBox";
			this.firstLetterKeyTextBox.Size = new System.Drawing.Size(311, 21);
			this.firstLetterKeyTextBox.TabIndex = 7;
			this.firstLetterKeyTextBox.TextChanged += new System.EventHandler(this.firstLetterKeyTextBox_TextChanged);
			// 
			// cipherDescriptionGroupBox
			// 
			this.cipherDescriptionGroupBox.Controls.Add(this.cipherDescriptionLabel);
			this.cipherDescriptionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cipherDescriptionGroupBox.Location = new System.Drawing.Point(12, 2);
			this.cipherDescriptionGroupBox.Name = "cipherDescriptionGroupBox";
			this.cipherDescriptionGroupBox.Size = new System.Drawing.Size(337, 102);
			this.cipherDescriptionGroupBox.TabIndex = 19;
			this.cipherDescriptionGroupBox.TabStop = false;
			this.cipherDescriptionGroupBox.Text = "Popis";
			// 
			// cipherDescriptionLabel
			// 
			this.cipherDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cipherDescriptionLabel.Location = new System.Drawing.Point(6, 18);
			this.cipherDescriptionLabel.Name = "cipherDescriptionLabel";
			this.cipherDescriptionLabel.Size = new System.Drawing.Size(325, 64);
			this.cipherDescriptionLabel.TabIndex = 0;
			this.cipherDescriptionLabel.Text = "Zde se nastavuje klíč pro šifrování/dešifrování dvojitou transpoziční šifrou. Ote" +
    "vřený text se zašifruje sloupcovou transpoziční šifrou s použitím prvního klíče " +
    "a poté znova s použítím druhého klíče.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.decryptButton);
			this.panel1.Controls.Add(this.encryptButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 233);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(361, 44);
			this.panel1.TabIndex = 18;
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.secondLetterKeyTextBox);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox1.Location = new System.Drawing.Point(12, 170);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(337, 54);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Klíč 2";
			// 
			// secondLetterKeyTextBox
			// 
			this.secondLetterKeyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.secondLetterKeyTextBox.Location = new System.Drawing.Point(9, 21);
			this.secondLetterKeyTextBox.Name = "secondLetterKeyTextBox";
			this.secondLetterKeyTextBox.Size = new System.Drawing.Size(311, 21);
			this.secondLetterKeyTextBox.TabIndex = 7;
			this.secondLetterKeyTextBox.TextChanged += new System.EventHandler(this.secondLetterKeyTextBox_TextChanged);
			// 
			// DoubleTranspositionKeyEntryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 277);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.keyEntryGroupBox);
			this.Controls.Add(this.cipherDescriptionGroupBox);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "DoubleTranspositionKeyEntryView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Nastavení klíče";
			this.keyEntryGroupBox.ResumeLayout(false);
			this.keyEntryGroupBox.PerformLayout();
			this.cipherDescriptionGroupBox.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox keyEntryGroupBox;
		public System.Windows.Forms.TextBox firstLetterKeyTextBox;
		private System.Windows.Forms.GroupBox cipherDescriptionGroupBox;
		private System.Windows.Forms.Label cipherDescriptionLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button decryptButton;
		private System.Windows.Forms.Button encryptButton;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.TextBox secondLetterKeyTextBox;
	}
}