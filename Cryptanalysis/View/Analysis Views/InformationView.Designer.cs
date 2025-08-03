namespace Cryptanalysis.View.Analysis_Views
{
	partial class InformationView
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
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.describitonGroupBox = new System.Windows.Forms.GroupBox();
			this.valueNameLabel = new System.Windows.Forms.Label();
			this.valueLabel = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.describitonGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.descriptionLabel.Location = new System.Drawing.Point(6, 16);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(387, 82);
			this.descriptionLabel.TabIndex = 0;
			this.descriptionLabel.Text = "popis";
			// 
			// describitonGroupBox
			// 
			this.describitonGroupBox.Controls.Add(this.descriptionLabel);
			this.describitonGroupBox.Location = new System.Drawing.Point(12, 12);
			this.describitonGroupBox.Name = "describitonGroupBox";
			this.describitonGroupBox.Size = new System.Drawing.Size(399, 101);
			this.describitonGroupBox.TabIndex = 1;
			this.describitonGroupBox.TabStop = false;
			this.describitonGroupBox.Text = "Popis";
			// 
			// valueNameLabel
			// 
			this.valueNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.valueNameLabel.Location = new System.Drawing.Point(12, 116);
			this.valueNameLabel.Name = "valueNameLabel";
			this.valueNameLabel.Size = new System.Drawing.Size(399, 19);
			this.valueNameLabel.TabIndex = 1;
			this.valueNameLabel.Text = "nazev";
			this.valueNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// valueLabel
			// 
			this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.valueLabel.Location = new System.Drawing.Point(12, 135);
			this.valueLabel.Name = "valueLabel";
			this.valueLabel.Size = new System.Drawing.Size(399, 19);
			this.valueLabel.TabIndex = 3;
			this.valueLabel.Text = "0";
			this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(169, 158);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(80, 30);
			this.okButton.TabIndex = 4;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// InformationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(423, 196);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.valueLabel);
			this.Controls.Add(this.valueNameLabel);
			this.Controls.Add(this.describitonGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "InformationView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Informace";
			this.describitonGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.GroupBox describitonGroupBox;
		private System.Windows.Forms.Label valueNameLabel;
		private System.Windows.Forms.Label valueLabel;
		private System.Windows.Forms.Button okButton;
	}
}