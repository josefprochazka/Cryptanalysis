namespace Cryptanalysis.View.Analysis_Views
{
	partial class NGramView
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
			this.dataGridViewPanel = new System.Windows.Forms.Panel();
			this.nGramDataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.histogramRadioButton = new System.Windows.Forms.RadioButton();
			this.bigramRadioButton = new System.Windows.Forms.RadioButton();
			this.trigramRadioButton = new System.Windows.Forms.RadioButton();
			this.nGramRadioButton = new System.Windows.Forms.RadioButton();
			this.nGramTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ngramCountTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.computeButton = new System.Windows.Forms.Button();
			this.saveListButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.selectionPanel = new System.Windows.Forms.Panel();
			this.dataGridViewPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nGramDataGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.selectionPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewPanel
			// 
			this.dataGridViewPanel.Controls.Add(this.nGramDataGridView);
			this.dataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.dataGridViewPanel.Location = new System.Drawing.Point(169, 0);
			this.dataGridViewPanel.Name = "dataGridViewPanel";
			this.dataGridViewPanel.Size = new System.Drawing.Size(391, 461);
			this.dataGridViewPanel.TabIndex = 0;
			// 
			// nGramDataGridView
			// 
			this.nGramDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.nGramDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nGramDataGridView.Location = new System.Drawing.Point(0, 0);
			this.nGramDataGridView.Name = "nGramDataGridView";
			this.nGramDataGridView.RowHeadersVisible = false;
			this.nGramDataGridView.Size = new System.Drawing.Size(391, 461);
			this.nGramDataGridView.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.ngramCountTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.nGramTextBox);
			this.groupBox1.Controls.Add(this.nGramRadioButton);
			this.groupBox1.Controls.Add(this.trigramRadioButton);
			this.groupBox1.Controls.Add(this.bigramRadioButton);
			this.groupBox1.Controls.Add(this.histogramRadioButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(137, 157);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Volby";
			// 
			// histogramRadioButton
			// 
			this.histogramRadioButton.AutoSize = true;
			this.histogramRadioButton.Location = new System.Drawing.Point(7, 20);
			this.histogramRadioButton.Name = "histogramRadioButton";
			this.histogramRadioButton.Size = new System.Drawing.Size(80, 17);
			this.histogramRadioButton.TabIndex = 0;
			this.histogramRadioButton.Text = "Monogramy";
			this.histogramRadioButton.UseVisualStyleBackColor = true;
			this.histogramRadioButton.CheckedChanged += new System.EventHandler(this.histogramRadioButton_CheckedChanged);
			// 
			// bigramRadioButton
			// 
			this.bigramRadioButton.AutoSize = true;
			this.bigramRadioButton.Location = new System.Drawing.Point(7, 43);
			this.bigramRadioButton.Name = "bigramRadioButton";
			this.bigramRadioButton.Size = new System.Drawing.Size(62, 17);
			this.bigramRadioButton.TabIndex = 1;
			this.bigramRadioButton.Text = "Bigramy";
			this.bigramRadioButton.UseVisualStyleBackColor = true;
			this.bigramRadioButton.CheckedChanged += new System.EventHandler(this.bigramRadioButton_CheckedChanged);
			// 
			// trigramRadioButton
			// 
			this.trigramRadioButton.AutoSize = true;
			this.trigramRadioButton.Location = new System.Drawing.Point(7, 66);
			this.trigramRadioButton.Name = "trigramRadioButton";
			this.trigramRadioButton.Size = new System.Drawing.Size(65, 17);
			this.trigramRadioButton.TabIndex = 2;
			this.trigramRadioButton.Text = "Trigramy";
			this.trigramRadioButton.UseVisualStyleBackColor = true;
			this.trigramRadioButton.CheckedChanged += new System.EventHandler(this.trigramRadioButton_CheckedChanged);
			// 
			// nGramRadioButton
			// 
			this.nGramRadioButton.AutoSize = true;
			this.nGramRadioButton.Location = new System.Drawing.Point(7, 89);
			this.nGramRadioButton.Name = "nGramRadioButton";
			this.nGramRadioButton.Size = new System.Drawing.Size(14, 13);
			this.nGramRadioButton.TabIndex = 3;
			this.nGramRadioButton.UseVisualStyleBackColor = true;
			this.nGramRadioButton.CheckedChanged += new System.EventHandler(this.nGramRadioButton_CheckedChanged);
			// 
			// nGramTextBox
			// 
			this.nGramTextBox.Location = new System.Drawing.Point(27, 86);
			this.nGramTextBox.MaxLength = 2;
			this.nGramTextBox.Name = "nGramTextBox";
			this.nGramTextBox.Size = new System.Drawing.Size(25, 20);
			this.nGramTextBox.TabIndex = 4;
			this.nGramTextBox.TextChanged += new System.EventHandler(this.nGramTextBox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "- gramy";
			// 
			// ngramCountTextBox
			// 
			this.ngramCountTextBox.Location = new System.Drawing.Point(86, 129);
			this.ngramCountTextBox.MaxLength = 4;
			this.ngramCountTextBox.Name = "ngramCountTextBox";
			this.ngramCountTextBox.Size = new System.Drawing.Size(32, 20);
			this.ngramCountTextBox.TabIndex = 6;
			this.ngramCountTextBox.TextChanged += new System.EventHandler(this.ngramCountTextBox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Počet N-gramů:";
			// 
			// computeButton
			// 
			this.computeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.computeButton.Location = new System.Drawing.Point(12, 320);
			this.computeButton.Name = "computeButton";
			this.computeButton.Size = new System.Drawing.Size(137, 40);
			this.computeButton.TabIndex = 1;
			this.computeButton.Text = "Zobrazit N-gramy";
			this.computeButton.UseVisualStyleBackColor = true;
			this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
			// 
			// saveListButton
			// 
			this.saveListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.saveListButton.Location = new System.Drawing.Point(12, 366);
			this.saveListButton.Name = "saveListButton";
			this.saveListButton.Size = new System.Drawing.Size(137, 40);
			this.saveListButton.TabIndex = 2;
			this.saveListButton.Text = "Uložit seznam";
			this.saveListButton.UseVisualStyleBackColor = true;
			this.saveListButton.Click += new System.EventHandler(this.saveListButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.closeButton.Location = new System.Drawing.Point(12, 412);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(137, 40);
			this.closeButton.TabIndex = 3;
			this.closeButton.Text = "Zavřít";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// selectionPanel
			// 
			this.selectionPanel.Controls.Add(this.closeButton);
			this.selectionPanel.Controls.Add(this.saveListButton);
			this.selectionPanel.Controls.Add(this.computeButton);
			this.selectionPanel.Controls.Add(this.groupBox1);
			this.selectionPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.selectionPanel.Location = new System.Drawing.Point(0, 0);
			this.selectionPanel.Name = "selectionPanel";
			this.selectionPanel.Size = new System.Drawing.Size(161, 461);
			this.selectionPanel.TabIndex = 1;
			// 
			// NGramView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 461);
			this.Controls.Add(this.selectionPanel);
			this.Controls.Add(this.dataGridViewPanel);
			this.Name = "NGramView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "NGram";
			this.dataGridViewPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nGramDataGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.selectionPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel dataGridViewPanel;
		private System.Windows.Forms.DataGridView nGramDataGridView;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ngramCountTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nGramTextBox;
		private System.Windows.Forms.RadioButton nGramRadioButton;
		private System.Windows.Forms.RadioButton trigramRadioButton;
		private System.Windows.Forms.RadioButton bigramRadioButton;
		private System.Windows.Forms.RadioButton histogramRadioButton;
		private System.Windows.Forms.Button computeButton;
		private System.Windows.Forms.Button saveListButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Panel selectionPanel;
	}
}