namespace Cryptanalysis.View.Cryptanalysis_Views
{
	partial class CommonCryptanalysisView
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
			this.informationDataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.informationDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// informationDataGridView
			// 
			this.informationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.informationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.informationDataGridView.Location = new System.Drawing.Point(0, 0);
			this.informationDataGridView.Name = "informationDataGridView";
			this.informationDataGridView.ReadOnly = true;
			this.informationDataGridView.RowHeadersVisible = false;
			this.informationDataGridView.Size = new System.Drawing.Size(584, 461);
			this.informationDataGridView.TabIndex = 0;
			this.informationDataGridView.Click += new System.EventHandler(this.InformationDataGridView_Click);
			// 
			// CommonCryptanalysisView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 461);
			this.Controls.Add(this.informationDataGridView);
			this.Name = "CommonCryptanalysisView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Informace z kryptoanalýzy";
			((System.ComponentModel.ISupportInitialize)(this.informationDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView informationDataGridView;
	}
}