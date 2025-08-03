namespace Cryptanalysis.View.Key_Entry_Views
{
	partial class HillKeyEntryView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HillKeyEntryView));
			this.keyEntryGroupBox = new System.Windows.Forms.GroupBox();
			this.resetKeyButton = new System.Windows.Forms.Button();
			this.generateKeyButton = new System.Windows.Forms.Button();
			this.numberMatrixGroupBox = new System.Windows.Forms.GroupBox();
			this.numberKeyLeftUpTextBox = new System.Windows.Forms.TextBox();
			this.numberKeyRightDownTextBox = new System.Windows.Forms.TextBox();
			this.numberKeyRightUpTextBox = new System.Windows.Forms.TextBox();
			this.numberKeyLeftDownTextBox = new System.Windows.Forms.TextBox();
			this.letterMatrixGroupBox = new System.Windows.Forms.GroupBox();
			this.letterKeyLeftUpTextBox = new System.Windows.Forms.TextBox();
			this.letterKeyRightDownTextBox = new System.Windows.Forms.TextBox();
			this.letterKeyRightUpTextBox = new System.Windows.Forms.TextBox();
			this.letterKeyLeftDownTextBox = new System.Windows.Forms.TextBox();
			this.setKeyAsNumberRadioButton = new System.Windows.Forms.RadioButton();
			this.setKeyAsCharRadioButton = new System.Windows.Forms.RadioButton();
			this.cipherDescriptionGroupBox = new System.Windows.Forms.GroupBox();
			this.cipherDescriptionLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.decryptButton = new System.Windows.Forms.Button();
			this.encryptButton = new System.Windows.Forms.Button();
			this.keyEntryGroupBox.SuspendLayout();
			this.numberMatrixGroupBox.SuspendLayout();
			this.letterMatrixGroupBox.SuspendLayout();
			this.cipherDescriptionGroupBox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// keyEntryGroupBox
			// 
			this.keyEntryGroupBox.Controls.Add(this.resetKeyButton);
			this.keyEntryGroupBox.Controls.Add(this.generateKeyButton);
			this.keyEntryGroupBox.Controls.Add(this.numberMatrixGroupBox);
			this.keyEntryGroupBox.Controls.Add(this.letterMatrixGroupBox);
			this.keyEntryGroupBox.Controls.Add(this.setKeyAsNumberRadioButton);
			this.keyEntryGroupBox.Controls.Add(this.setKeyAsCharRadioButton);
			this.keyEntryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.keyEntryGroupBox.Location = new System.Drawing.Point(12, 124);
			this.keyEntryGroupBox.Name = "keyEntryGroupBox";
			this.keyEntryGroupBox.Size = new System.Drawing.Size(337, 127);
			this.keyEntryGroupBox.TabIndex = 10;
			this.keyEntryGroupBox.TabStop = false;
			this.keyEntryGroupBox.Text = "Nastavení klíče";
			// 
			// resetKeyButton
			// 
			this.resetKeyButton.Location = new System.Drawing.Point(214, 90);
			this.resetKeyButton.Name = "resetKeyButton";
			this.resetKeyButton.Size = new System.Drawing.Size(117, 23);
			this.resetKeyButton.TabIndex = 13;
			this.resetKeyButton.Text = "Resetovat klíč";
			this.resetKeyButton.UseVisualStyleBackColor = true;
			this.resetKeyButton.Click += new System.EventHandler(this.resetKeyButton_Click);
			// 
			// generateKeyButton
			// 
			this.generateKeyButton.Location = new System.Drawing.Point(214, 61);
			this.generateKeyButton.Name = "generateKeyButton";
			this.generateKeyButton.Size = new System.Drawing.Size(117, 23);
			this.generateKeyButton.TabIndex = 12;
			this.generateKeyButton.Text = "Vygenerovat klíč";
			this.generateKeyButton.UseVisualStyleBackColor = true;
			this.generateKeyButton.Click += new System.EventHandler(this.generateKeyButton_Click);
			// 
			// numberMatrixGroupBox
			// 
			this.numberMatrixGroupBox.Controls.Add(this.numberKeyLeftUpTextBox);
			this.numberMatrixGroupBox.Controls.Add(this.numberKeyRightDownTextBox);
			this.numberMatrixGroupBox.Controls.Add(this.numberKeyRightUpTextBox);
			this.numberMatrixGroupBox.Controls.Add(this.numberKeyLeftDownTextBox);
			this.numberMatrixGroupBox.Enabled = false;
			this.numberMatrixGroupBox.Location = new System.Drawing.Point(108, 45);
			this.numberMatrixGroupBox.Name = "numberMatrixGroupBox";
			this.numberMatrixGroupBox.Size = new System.Drawing.Size(71, 75);
			this.numberMatrixGroupBox.TabIndex = 11;
			this.numberMatrixGroupBox.TabStop = false;
			this.numberMatrixGroupBox.Text = "Čísla";
			// 
			// numberKeyLeftUpTextBox
			// 
			this.numberKeyLeftUpTextBox.Location = new System.Drawing.Point(11, 18);
			this.numberKeyLeftUpTextBox.MaxLength = 2;
			this.numberKeyLeftUpTextBox.Name = "numberKeyLeftUpTextBox";
			this.numberKeyLeftUpTextBox.Size = new System.Drawing.Size(21, 21);
			this.numberKeyLeftUpTextBox.TabIndex = 6;
			this.numberKeyLeftUpTextBox.TextChanged += new System.EventHandler(this.numberKeyLeftUpTextBox_TextChanged);
			// 
			// numberKeyRightDownTextBox
			// 
			this.numberKeyRightDownTextBox.Location = new System.Drawing.Point(38, 45);
			this.numberKeyRightDownTextBox.MaxLength = 2;
			this.numberKeyRightDownTextBox.Name = "numberKeyRightDownTextBox";
			this.numberKeyRightDownTextBox.Size = new System.Drawing.Size(21, 21);
			this.numberKeyRightDownTextBox.TabIndex = 9;
			this.numberKeyRightDownTextBox.TextChanged += new System.EventHandler(this.numberKeyRightDownTextBox_TextChanged);
			// 
			// numberKeyRightUpTextBox
			// 
			this.numberKeyRightUpTextBox.Location = new System.Drawing.Point(38, 18);
			this.numberKeyRightUpTextBox.MaxLength = 2;
			this.numberKeyRightUpTextBox.Name = "numberKeyRightUpTextBox";
			this.numberKeyRightUpTextBox.Size = new System.Drawing.Size(21, 21);
			this.numberKeyRightUpTextBox.TabIndex = 7;
			this.numberKeyRightUpTextBox.TextChanged += new System.EventHandler(this.numberKeyRightUpTextBox_TextChanged);
			// 
			// numberKeyLeftDownTextBox
			// 
			this.numberKeyLeftDownTextBox.Location = new System.Drawing.Point(11, 45);
			this.numberKeyLeftDownTextBox.MaxLength = 2;
			this.numberKeyLeftDownTextBox.Name = "numberKeyLeftDownTextBox";
			this.numberKeyLeftDownTextBox.Size = new System.Drawing.Size(21, 21);
			this.numberKeyLeftDownTextBox.TabIndex = 8;
			this.numberKeyLeftDownTextBox.TextChanged += new System.EventHandler(this.numberKeyLeftDownTextBox_TextChanged);
			// 
			// letterMatrixGroupBox
			// 
			this.letterMatrixGroupBox.Controls.Add(this.letterKeyLeftUpTextBox);
			this.letterMatrixGroupBox.Controls.Add(this.letterKeyRightDownTextBox);
			this.letterMatrixGroupBox.Controls.Add(this.letterKeyRightUpTextBox);
			this.letterMatrixGroupBox.Controls.Add(this.letterKeyLeftDownTextBox);
			this.letterMatrixGroupBox.Location = new System.Drawing.Point(7, 45);
			this.letterMatrixGroupBox.Name = "letterMatrixGroupBox";
			this.letterMatrixGroupBox.Size = new System.Drawing.Size(71, 75);
			this.letterMatrixGroupBox.TabIndex = 10;
			this.letterMatrixGroupBox.TabStop = false;
			this.letterMatrixGroupBox.Text = "Písmena";
			// 
			// letterKeyLeftUpTextBox
			// 
			this.letterKeyLeftUpTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.letterKeyLeftUpTextBox.Location = new System.Drawing.Point(11, 18);
			this.letterKeyLeftUpTextBox.MaxLength = 1;
			this.letterKeyLeftUpTextBox.Name = "letterKeyLeftUpTextBox";
			this.letterKeyLeftUpTextBox.Size = new System.Drawing.Size(21, 21);
			this.letterKeyLeftUpTextBox.TabIndex = 6;
			this.letterKeyLeftUpTextBox.TextChanged += new System.EventHandler(this.letterKeyLeftUpTextBox_TextChanged);
			// 
			// letterKeyRightDownTextBox
			// 
			this.letterKeyRightDownTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.letterKeyRightDownTextBox.Location = new System.Drawing.Point(38, 45);
			this.letterKeyRightDownTextBox.MaxLength = 1;
			this.letterKeyRightDownTextBox.Name = "letterKeyRightDownTextBox";
			this.letterKeyRightDownTextBox.Size = new System.Drawing.Size(21, 21);
			this.letterKeyRightDownTextBox.TabIndex = 9;
			this.letterKeyRightDownTextBox.TextChanged += new System.EventHandler(this.letterKeyRightDownTextBox_TextChanged);
			// 
			// letterKeyRightUpTextBox
			// 
			this.letterKeyRightUpTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.letterKeyRightUpTextBox.Location = new System.Drawing.Point(38, 18);
			this.letterKeyRightUpTextBox.MaxLength = 1;
			this.letterKeyRightUpTextBox.Name = "letterKeyRightUpTextBox";
			this.letterKeyRightUpTextBox.Size = new System.Drawing.Size(21, 21);
			this.letterKeyRightUpTextBox.TabIndex = 7;
			this.letterKeyRightUpTextBox.TextChanged += new System.EventHandler(this.letterKeyRightUpTextBox_TextChanged);
			// 
			// letterKeyLeftDownTextBox
			// 
			this.letterKeyLeftDownTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.letterKeyLeftDownTextBox.Location = new System.Drawing.Point(11, 45);
			this.letterKeyLeftDownTextBox.MaxLength = 1;
			this.letterKeyLeftDownTextBox.Name = "letterKeyLeftDownTextBox";
			this.letterKeyLeftDownTextBox.Size = new System.Drawing.Size(21, 21);
			this.letterKeyLeftDownTextBox.TabIndex = 8;
			this.letterKeyLeftDownTextBox.TextChanged += new System.EventHandler(this.letterKeyLeftDownTextBox_TextChanged);
			// 
			// setKeyAsNumberRadioButton
			// 
			this.setKeyAsNumberRadioButton.AutoSize = true;
			this.setKeyAsNumberRadioButton.Location = new System.Drawing.Point(108, 20);
			this.setKeyAsNumberRadioButton.Name = "setKeyAsNumberRadioButton";
			this.setKeyAsNumberRadioButton.Size = new System.Drawing.Size(52, 19);
			this.setKeyAsNumberRadioButton.TabIndex = 5;
			this.setKeyAsNumberRadioButton.Text = "Čísla";
			this.setKeyAsNumberRadioButton.UseVisualStyleBackColor = true;
			// 
			// setKeyAsCharRadioButton
			// 
			this.setKeyAsCharRadioButton.AutoSize = true;
			this.setKeyAsCharRadioButton.Checked = true;
			this.setKeyAsCharRadioButton.Location = new System.Drawing.Point(7, 20);
			this.setKeyAsCharRadioButton.Name = "setKeyAsCharRadioButton";
			this.setKeyAsCharRadioButton.Size = new System.Drawing.Size(74, 19);
			this.setKeyAsCharRadioButton.TabIndex = 3;
			this.setKeyAsCharRadioButton.TabStop = true;
			this.setKeyAsCharRadioButton.Text = "Písmena";
			this.setKeyAsCharRadioButton.UseVisualStyleBackColor = true;
			this.setKeyAsCharRadioButton.CheckedChanged += new System.EventHandler(this.setKeyAsCharRadioButton_CheckedChanged);
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
			this.panel1.Location = new System.Drawing.Point(0, 259);
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
			// HillKeyEntryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 303);
			this.Controls.Add(this.keyEntryGroupBox);
			this.Controls.Add(this.cipherDescriptionGroupBox);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "HillKeyEntryView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Nastavení klíče";
			this.keyEntryGroupBox.ResumeLayout(false);
			this.keyEntryGroupBox.PerformLayout();
			this.numberMatrixGroupBox.ResumeLayout(false);
			this.numberMatrixGroupBox.PerformLayout();
			this.letterMatrixGroupBox.ResumeLayout(false);
			this.letterMatrixGroupBox.PerformLayout();
			this.cipherDescriptionGroupBox.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox keyEntryGroupBox;
		private System.Windows.Forms.Button resetKeyButton;
		private System.Windows.Forms.Button generateKeyButton;
		private System.Windows.Forms.GroupBox numberMatrixGroupBox;
		private System.Windows.Forms.TextBox numberKeyLeftUpTextBox;
		private System.Windows.Forms.TextBox numberKeyRightDownTextBox;
		private System.Windows.Forms.TextBox numberKeyRightUpTextBox;
		private System.Windows.Forms.TextBox numberKeyLeftDownTextBox;
		private System.Windows.Forms.GroupBox letterMatrixGroupBox;
		private System.Windows.Forms.TextBox letterKeyLeftUpTextBox;
		private System.Windows.Forms.TextBox letterKeyRightDownTextBox;
		private System.Windows.Forms.TextBox letterKeyRightUpTextBox;
		private System.Windows.Forms.TextBox letterKeyLeftDownTextBox;
		private System.Windows.Forms.RadioButton setKeyAsNumberRadioButton;
		private System.Windows.Forms.RadioButton setKeyAsCharRadioButton;
		private System.Windows.Forms.GroupBox cipherDescriptionGroupBox;
		private System.Windows.Forms.Label cipherDescriptionLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button decryptButton;
		private System.Windows.Forms.Button encryptButton;
	}
}