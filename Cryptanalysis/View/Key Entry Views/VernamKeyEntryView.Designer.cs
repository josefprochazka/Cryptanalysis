namespace Cryptanalysis.View.Key_Entry_Views
{
	partial class VernamKeyEntryView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VernamKeyEntryView));
			this.cipherDescriptionGroupBox = new System.Windows.Forms.GroupBox();
			this.cipherDescriptionLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.encryptButton = new System.Windows.Forms.Button();
			this.cipherDescriptionGroupBox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cipherDescriptionGroupBox
			// 
			this.cipherDescriptionGroupBox.Controls.Add(this.cipherDescriptionLabel);
			this.cipherDescriptionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cipherDescriptionGroupBox.Location = new System.Drawing.Point(12, 3);
			this.cipherDescriptionGroupBox.Name = "cipherDescriptionGroupBox";
			this.cipherDescriptionGroupBox.Size = new System.Drawing.Size(337, 118);
			this.cipherDescriptionGroupBox.TabIndex = 12;
			this.cipherDescriptionGroupBox.TabStop = false;
			this.cipherDescriptionGroupBox.Text = "Popis";
			// 
			// cipherDescriptionLabel
			// 
			this.cipherDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cipherDescriptionLabel.Location = new System.Drawing.Point(6, 18);
			this.cipherDescriptionLabel.Name = "cipherDescriptionLabel";
			this.cipherDescriptionLabel.Size = new System.Drawing.Size(325, 97);
			this.cipherDescriptionLabel.TabIndex = 0;
			this.cipherDescriptionLabel.Text = resources.GetString("cipherDescriptionLabel.Text");
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.encryptButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 131);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(361, 44);
			this.panel1.TabIndex = 11;
			// 
			// encryptButton
			// 
			this.encryptButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.encryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.encryptButton.Location = new System.Drawing.Point(0, 0);
			this.encryptButton.Name = "encryptButton";
			this.encryptButton.Size = new System.Drawing.Size(361, 44);
			this.encryptButton.TabIndex = 1;
			this.encryptButton.Text = "Šifrovat";
			this.encryptButton.UseVisualStyleBackColor = true;
			this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
			// 
			// VernamKeyEntryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 175);
			this.Controls.Add(this.cipherDescriptionGroupBox);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "VernamKeyEntryView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "VernamKeyEntryView";
			this.cipherDescriptionGroupBox.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox cipherDescriptionGroupBox;
		private System.Windows.Forms.Label cipherDescriptionLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button encryptButton;
	}
}