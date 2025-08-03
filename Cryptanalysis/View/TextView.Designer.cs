namespace Cryptanalysis.View
{
	partial class TextView
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextView));
			this.textFormMainMenu = new System.Windows.Forms.MainMenu(this.components);
			this.fileMenuItem = new System.Windows.Forms.MenuItem();
			this.newTextFormMenuItem = new System.Windows.Forms.MenuItem();
			this.openMenuItem = new System.Windows.Forms.MenuItem();
			this.saveMenuItem = new System.Windows.Forms.MenuItem();
			this.closeTextFormMenuItem = new System.Windows.Forms.MenuItem();
			this.closeAllFormsMenuItem = new System.Windows.Forms.MenuItem();
			this.closeApplicationMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.caesarMenuItem = new System.Windows.Forms.MenuItem();
			this.affineMenuItem = new System.Windows.Forms.MenuItem();
			this.vigenereMenuItem = new System.Windows.Forms.MenuItem();
			this.substitutionMenuItem = new System.Windows.Forms.MenuItem();
			this.vernamMenuItem = new System.Windows.Forms.MenuItem();
			this.hillMenuItem = new System.Windows.Forms.MenuItem();
			this.playfairMenuItem = new System.Windows.Forms.MenuItem();
			this.polybiusMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.railfenceMenuItem = new System.Windows.Forms.MenuItem();
			this.transpositionMenuItem = new System.Windows.Forms.MenuItem();
			this.doubleTranspositionMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.cipherKindMenuItem = new System.Windows.Forms.MenuItem();
			this.indexCoincidenceMenuItem = new System.Windows.Forms.MenuItem();
			this.chiSquareMenuItem = new System.Windows.Forms.MenuItem();
			this.fitnessMenuItem = new System.Windows.Forms.MenuItem();
			this.histogramMenuItem = new System.Windows.Forms.MenuItem();
			this.ngramMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.caesarCryptanalysisMenuItem = new System.Windows.Forms.MenuItem();
			this.fitnessCaesarMenuItem = new System.Windows.Forms.MenuItem();
			this.fitnessAffineMenuItem = new System.Windows.Forms.MenuItem();
			this.fitnessColumnarTranspositionMenuItem = new System.Windows.Forms.MenuItem();
			this.fitnessColumnarDoubleTranspositionMenuItem = new System.Windows.Forms.MenuItem();
			this.hillClimbingSubstitutionMenuItem = new System.Windows.Forms.MenuItem();
			this.hillClimbingPlayfairMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.chiSquareCaesarMenuItem = new System.Windows.Forms.MenuItem();
			this.chiSquareAffineMenuItem = new System.Windows.Forms.MenuItem();
			this.chiSquareVigenereMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.substitutionManualCryptanalysisMenuItem = new System.Windows.Forms.MenuItem();
			this.mainTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textFormMainMenu
			// 
			this.textFormMainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem,
            this.menuItem1,
            this.menuItem13,
            this.menuItem14});
			// 
			// fileMenuItem
			// 
			this.fileMenuItem.Index = 0;
			this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.newTextFormMenuItem,
            this.openMenuItem,
            this.saveMenuItem,
            this.closeTextFormMenuItem,
            this.closeAllFormsMenuItem,
            this.closeApplicationMenuItem});
			this.fileMenuItem.Text = "Soubor";
			// 
			// newTextFormMenuItem
			// 
			this.newTextFormMenuItem.Index = 0;
			this.newTextFormMenuItem.Text = "Nový";
			this.newTextFormMenuItem.Click += new System.EventHandler(this.newTextFormMenuItem_Click);
			// 
			// openMenuItem
			// 
			this.openMenuItem.Index = 1;
			this.openMenuItem.Text = "Otevřít";
			this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
			// 
			// saveMenuItem
			// 
			this.saveMenuItem.Index = 2;
			this.saveMenuItem.Text = "Uložit";
			this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
			// 
			// closeTextFormMenuItem
			// 
			this.closeTextFormMenuItem.Index = 3;
			this.closeTextFormMenuItem.Text = "Zavřít okno";
			this.closeTextFormMenuItem.Click += new System.EventHandler(this.closeTextFormMenuItem_Click);
			// 
			// closeAllFormsMenuItem
			// 
			this.closeAllFormsMenuItem.Index = 4;
			this.closeAllFormsMenuItem.Text = "Zavřít všechna okna";
			this.closeAllFormsMenuItem.Click += new System.EventHandler(this.closeAllFormsMenuItem_Click);
			// 
			// closeApplicationMenuItem
			// 
			this.closeApplicationMenuItem.Index = 5;
			this.closeApplicationMenuItem.Text = "Ukončit aplikaci";
			this.closeApplicationMenuItem.Click += new System.EventHandler(this.closeApplicationMenuItem_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem6});
			this.menuItem1.Text = "Šifrování/Dešifrování";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.caesarMenuItem,
            this.affineMenuItem,
            this.vigenereMenuItem,
            this.substitutionMenuItem,
            this.vernamMenuItem,
            this.hillMenuItem,
            this.playfairMenuItem,
            this.polybiusMenuItem});
			this.menuItem2.Text = "Substituční šifry";
			// 
			// caesarMenuItem
			// 
			this.caesarMenuItem.Index = 0;
			this.caesarMenuItem.Text = "Caesar";
			this.caesarMenuItem.Click += new System.EventHandler(this.caesarMenuItem_Click);
			// 
			// affineMenuItem
			// 
			this.affineMenuItem.Index = 1;
			this.affineMenuItem.Text = "Afinní";
			this.affineMenuItem.Click += new System.EventHandler(this.affineMenuItem_Click);
			// 
			// vigenereMenuItem
			// 
			this.vigenereMenuItem.Index = 2;
			this.vigenereMenuItem.Text = "Vigenèr";
			this.vigenereMenuItem.Click += new System.EventHandler(this.vigenereMenuItem_Click);
			// 
			// substitutionMenuItem
			// 
			this.substitutionMenuItem.Index = 3;
			this.substitutionMenuItem.Text = "Obecná substituce";
			this.substitutionMenuItem.Click += new System.EventHandler(this.substitutionMenuItem_Click);
			// 
			// vernamMenuItem
			// 
			this.vernamMenuItem.Index = 4;
			this.vernamMenuItem.Text = "Vernam";
			this.vernamMenuItem.Click += new System.EventHandler(this.vernamMenuItem_Click);
			// 
			// hillMenuItem
			// 
			this.hillMenuItem.Index = 5;
			this.hillMenuItem.Text = "Hill";
			this.hillMenuItem.Click += new System.EventHandler(this.hillMenuItem_Click);
			// 
			// playfairMenuItem
			// 
			this.playfairMenuItem.Index = 6;
			this.playfairMenuItem.Text = "Playfair";
			this.playfairMenuItem.Click += new System.EventHandler(this.playfairMenuItem_Click);
			// 
			// polybiusMenuItem
			// 
			this.polybiusMenuItem.Index = 7;
			this.polybiusMenuItem.Text = "Polybius";
			this.polybiusMenuItem.Click += new System.EventHandler(this.polybiusMenuItem_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.railfenceMenuItem,
            this.transpositionMenuItem,
            this.doubleTranspositionMenuItem});
			this.menuItem6.Text = "Transpoziční";
			// 
			// railfenceMenuItem
			// 
			this.railfenceMenuItem.Index = 0;
			this.railfenceMenuItem.Text = "Rail fence";
			this.railfenceMenuItem.Click += new System.EventHandler(this.railfenceMenuItem_Click);
			// 
			// transpositionMenuItem
			// 
			this.transpositionMenuItem.Index = 1;
			this.transpositionMenuItem.Text = "Transpozice";
			this.transpositionMenuItem.Click += new System.EventHandler(this.transpositionMenuItem_Click);
			// 
			// doubleTranspositionMenuItem
			// 
			this.doubleTranspositionMenuItem.Index = 2;
			this.doubleTranspositionMenuItem.Text = "Dvojitá transpozice";
			this.doubleTranspositionMenuItem.Click += new System.EventHandler(this.doubleTranspositionMenuItem_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 2;
			this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cipherKindMenuItem,
            this.indexCoincidenceMenuItem,
            this.chiSquareMenuItem,
            this.fitnessMenuItem,
            this.histogramMenuItem,
            this.ngramMenuItem});
			this.menuItem13.Text = "Analýza";
			// 
			// cipherKindMenuItem
			// 
			this.cipherKindMenuItem.Index = 0;
			this.cipherKindMenuItem.Text = "Druh šifry";
			this.cipherKindMenuItem.Click += new System.EventHandler(this.cipherKindMenuItem_Click);
			// 
			// indexCoincidenceMenuItem
			// 
			this.indexCoincidenceMenuItem.Index = 1;
			this.indexCoincidenceMenuItem.Text = "Index koincidence";
			this.indexCoincidenceMenuItem.Click += new System.EventHandler(this.indexCoincidenceMenuItem_Click);
			// 
			// chiSquareMenuItem
			// 
			this.chiSquareMenuItem.Index = 2;
			this.chiSquareMenuItem.Text = "Chí kvadrát";
			this.chiSquareMenuItem.Click += new System.EventHandler(this.chiSquareMenuItem_Click);
			// 
			// fitnessMenuItem
			// 
			this.fitnessMenuItem.Index = 3;
			this.fitnessMenuItem.Text = "Fitness";
			this.fitnessMenuItem.Click += new System.EventHandler(this.fitnessMenuItem_Click);
			// 
			// histogramMenuItem
			// 
			this.histogramMenuItem.Index = 4;
			this.histogramMenuItem.Text = "Histogram";
			this.histogramMenuItem.Click += new System.EventHandler(this.histogramMenuItem_Click);
			// 
			// ngramMenuItem
			// 
			this.ngramMenuItem.Index = 5;
			this.ngramMenuItem.Text = "N-gram";
			this.ngramMenuItem.Click += new System.EventHandler(this.ngramMenuItem_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 3;
			this.menuItem14.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem15,
            this.menuItem17});
			this.menuItem14.Text = "Kyptoanalýza";
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 0;
			this.menuItem15.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.caesarCryptanalysisMenuItem,
            this.menuItem5});
			this.menuItem15.Text = "Pouze šifrový text";
			// 
			// caesarCryptanalysisMenuItem
			// 
			this.caesarCryptanalysisMenuItem.Index = 0;
			this.caesarCryptanalysisMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fitnessCaesarMenuItem,
            this.fitnessAffineMenuItem,
            this.fitnessColumnarTranspositionMenuItem,
            this.fitnessColumnarDoubleTranspositionMenuItem,
            this.hillClimbingSubstitutionMenuItem,
            this.hillClimbingPlayfairMenuItem});
			this.caesarCryptanalysisMenuItem.Text = "Fitness";
			// 
			// fitnessCaesarMenuItem
			// 
			this.fitnessCaesarMenuItem.Index = 0;
			this.fitnessCaesarMenuItem.Text = "Caesar (Útok hrubou silou)";
			this.fitnessCaesarMenuItem.Click += new System.EventHandler(this.fitnessCaesarMenuItem_Click);
			// 
			// fitnessAffineMenuItem
			// 
			this.fitnessAffineMenuItem.Index = 1;
			this.fitnessAffineMenuItem.Text = "Afinní (Útok hrubou silou)";
			this.fitnessAffineMenuItem.Click += new System.EventHandler(this.fitnessAffineMenuItem_Click);
			// 
			// fitnessColumnarTranspositionMenuItem
			// 
			this.fitnessColumnarTranspositionMenuItem.Index = 2;
			this.fitnessColumnarTranspositionMenuItem.Text = "Sloupcová transpozice (Útok hrubou silou)";
			this.fitnessColumnarTranspositionMenuItem.Click += new System.EventHandler(this.fitnessColumnarTranspositionMenuItem_Click);
			// 
			// fitnessColumnarDoubleTranspositionMenuItem
			// 
			this.fitnessColumnarDoubleTranspositionMenuItem.Index = 3;
			this.fitnessColumnarDoubleTranspositionMenuItem.Text = "Dvojitá transpozice (Útok hrubou silou)";
			this.fitnessColumnarDoubleTranspositionMenuItem.Click += new System.EventHandler(this.fitnessColumnarDoubleTranspositionMenuItem_Click);
			// 
			// hillClimbingSubstitutionMenuItem
			// 
			this.hillClimbingSubstitutionMenuItem.Index = 4;
			this.hillClimbingSubstitutionMenuItem.Text = "Obecná substituce (Shotgun Hill climbing)";
			this.hillClimbingSubstitutionMenuItem.Click += new System.EventHandler(this.hillClimbingSubstitutionMenuItem_Click);
			// 
			// hillClimbingPlayfairMenuItem
			// 
			this.hillClimbingPlayfairMenuItem.Index = 5;
			this.hillClimbingPlayfairMenuItem.Text = "Playfair (Shotgun Hill climbing)";
			this.hillClimbingPlayfairMenuItem.Click += new System.EventHandler(this.hillClimbingPlayfairMenuItem_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.chiSquareCaesarMenuItem,
            this.chiSquareAffineMenuItem,
            this.chiSquareVigenereMenuItem});
			this.menuItem5.Text = "Chí kvadrát";
			// 
			// chiSquareCaesarMenuItem
			// 
			this.chiSquareCaesarMenuItem.Index = 0;
			this.chiSquareCaesarMenuItem.Text = "Caesar (Útok hrubou silou)";
			this.chiSquareCaesarMenuItem.Click += new System.EventHandler(this.chiSquareCaesarMenuItem_Click);
			// 
			// chiSquareAffineMenuItem
			// 
			this.chiSquareAffineMenuItem.Index = 1;
			this.chiSquareAffineMenuItem.Text = "Afinní (Útok hrubou silou)";
			this.chiSquareAffineMenuItem.Click += new System.EventHandler(this.chiSquareAffineMenuItem_Click);
			// 
			// chiSquareVigenereMenuItem
			// 
			this.chiSquareVigenereMenuItem.Index = 2;
			this.chiSquareVigenereMenuItem.Text = "Vigenèr (Index koincidence)";
			this.chiSquareVigenereMenuItem.Click += new System.EventHandler(this.chiSquareVigenereMenuItem_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 1;
			this.menuItem17.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.substitutionManualCryptanalysisMenuItem});
			this.menuItem17.Text = "Manuální kryptoanalýza";
			// 
			// substitutionManualCryptanalysisMenuItem
			// 
			this.substitutionManualCryptanalysisMenuItem.Index = 0;
			this.substitutionManualCryptanalysisMenuItem.Text = "Obecná substituce";
			this.substitutionManualCryptanalysisMenuItem.Click += new System.EventHandler(this.substitutionManualCryptanalysisMenuItem_Click);
			// 
			// mainTextBox
			// 
			this.mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.mainTextBox.Location = new System.Drawing.Point(0, 0);
			this.mainTextBox.Multiline = true;
			this.mainTextBox.Name = "mainTextBox";
			this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.mainTextBox.Size = new System.Drawing.Size(734, 340);
			this.mainTextBox.TabIndex = 0;
			this.mainTextBox.Click += new System.EventHandler(this.MainTextBox_Click);
			// 
			// TextView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 340);
			this.Controls.Add(this.mainTextBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.textFormMainMenu;
			this.Name = "TextView";
			this.Text = "TextForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TextView_FormClosed_1);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MainMenu textFormMainMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		public System.Windows.Forms.TextBox mainTextBox;
		private System.Windows.Forms.MenuItem caesarMenuItem;
		private System.Windows.Forms.MenuItem vigenereMenuItem;
		private System.Windows.Forms.MenuItem affineMenuItem;
		private System.Windows.Forms.MenuItem vernamMenuItem;
		private System.Windows.Forms.MenuItem substitutionMenuItem;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem railfenceMenuItem;
		private System.Windows.Forms.MenuItem hillMenuItem;
		private System.Windows.Forms.MenuItem playfairMenuItem;
		private System.Windows.Forms.MenuItem polybiusMenuItem;
		private System.Windows.Forms.MenuItem transpositionMenuItem;
		private System.Windows.Forms.MenuItem doubleTranspositionMenuItem;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem caesarCryptanalysisMenuItem;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem histogramMenuItem;
		private System.Windows.Forms.MenuItem indexCoincidenceMenuItem;
		private System.Windows.Forms.MenuItem chiSquareMenuItem;
		private System.Windows.Forms.MenuItem fitnessMenuItem;
		private System.Windows.Forms.MenuItem ngramMenuItem;
		private System.Windows.Forms.MenuItem fitnessCaesarMenuItem;
		private System.Windows.Forms.MenuItem fitnessAffineMenuItem;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem chiSquareCaesarMenuItem;
		private System.Windows.Forms.MenuItem chiSquareAffineMenuItem;
		private System.Windows.Forms.MenuItem chiSquareVigenereMenuItem;
		private System.Windows.Forms.MenuItem fitnessColumnarTranspositionMenuItem;
		private System.Windows.Forms.MenuItem fitnessColumnarDoubleTranspositionMenuItem;
		private System.Windows.Forms.MenuItem substitutionManualCryptanalysisMenuItem;
		private System.Windows.Forms.MenuItem hillClimbingSubstitutionMenuItem;
		private System.Windows.Forms.MenuItem hillClimbingPlayfairMenuItem;
		private System.Windows.Forms.MenuItem fileMenuItem;
		private System.Windows.Forms.MenuItem newTextFormMenuItem;
		private System.Windows.Forms.MenuItem closeTextFormMenuItem;
		private System.Windows.Forms.MenuItem closeAllFormsMenuItem;
		private System.Windows.Forms.MenuItem saveMenuItem;
		private System.Windows.Forms.MenuItem openMenuItem;
		private System.Windows.Forms.MenuItem closeApplicationMenuItem;
		private System.Windows.Forms.MenuItem cipherKindMenuItem;
	}
}