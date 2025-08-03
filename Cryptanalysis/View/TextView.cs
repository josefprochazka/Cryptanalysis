using System;
using System.Windows.Forms;
using Cryptanalysis.View.Analysis_Views;
using Cryptanalysis.View.Cryptanalysis_Views;
using Cryptanalysis.View.Key_Entry;
using Cryptanalysis.View.Key_Entry_Views;

namespace Cryptanalysis.View
{
	public partial class TextView : Form
	{
		#region Constructors

		public TextView()
		{
			InitializeComponent();
		}

		#endregion

		#region Events

		private void caesarMenuItem_Click(object sender, EventArgs e)
		{
			new CaesarKeyEntryView(mainTextBox.Text);
		}

		private void affineMenuItem_Click(object sender, EventArgs e)
		{
			new AffineKeyEntryView(mainTextBox.Text);
		}

		private void vigenereMenuItem_Click(object sender, EventArgs e)
		{
			new VigenereKeyEntryView(mainTextBox.Text);
		}

		private void substitutionMenuItem_Click(object sender, EventArgs e)
		{
			new SubstitutionKeyEntryView(mainTextBox.Text);
		}

		private void vernamMenuItem_Click(object sender, EventArgs e)
		{
			new VernamKeyEntryView(mainTextBox.Text);
		}

		private void hillMenuItem_Click(object sender, EventArgs e)
		{
			new HillKeyEntryView(mainTextBox.Text);
		}

		private void playfairMenuItem_Click(object sender, EventArgs e)
		{
			new PlayfairKeyEntryView(mainTextBox.Text);
		}

		private void polybiusMenuItem_Click(object sender, EventArgs e)
		{
			new PolybiusKeyEntryView(mainTextBox.Text);
		}

		private void railfenceMenuItem_Click(object sender, EventArgs e)
		{
			new RailfenceKeyEntryView(mainTextBox.Text);
		}

		private void transpositionMenuItem_Click(object sender, EventArgs e)
		{
			new TranspositionKeyEntryView(mainTextBox.Text);
		}

		private void doubleTranspositionMenuItem_Click(object sender, EventArgs e)
		{
			new DoubleTranspositionKeyEntryView(mainTextBox.Text);
		}

		private void histogramMenuItem_Click(object sender, EventArgs e)
		{
			FormsUtilities.OpenFormInMainForm(new HistogramView(mainTextBox.Text, Text), true);
		}

		private void indexCoincidenceMenuItem_Click(object sender, EventArgs e)
		{
			new InformationView(
				"Index koincidence ukazuje, jak velká je pravděpodobnost, že dvě náhodně vybraná písmena budou stejná. Výsledná hodnota ohodnocuje, jak je analyzovaný text podobný běžnému anglickému textu, což bývá přibližně 0,067.",
				"Index koincidence",
				new Statistics().GetIndexOfCoincidence(mainTextBox.Text).ToString(),
				Text
				);
		}

		private void chiSquareMenuItem_Click(object sender, EventArgs e)
		{
			new InformationView(
				"Chí kvadrát neboli Test dobré shody udává hodnotu toho, jak moc jsou na sobě dva jevy nezávislé. Čím vyšší hodnota vyjde, tím více jsou dva jevy od sebe odlišné. Zde se porovnává výskyt písmen v daném textu oproti průměrnému výskytu písmen v anglickém textu.",
				"Chí kvadrát",
				new Statistics().GetChiSquaredValue(mainTextBox.Text).ToString(),
				Text
				);
		}

		private void fitnessMenuItem_Click(object sender, EventArgs e)
		{
			new InformationView(
				"Fitness hodnota určuje míru vhodnosti vyjadřující, jak moc je určitý text podobný v našem případě anglickému textu. Tato hodnota se vypočítává podle trigramů, které text obsahuje, protože některé se v anglickém textu vyskytují často a některé jen zřídka, nebo vůbec. Čím je hodnota vyšší, tím více se text podobá anglickému textu.",
				"Fitness hodnota",
				new Statistics().GetTrigramFitness(mainTextBox.Text).ToString(),
				Text
				);
		}

		private void ngramMenuItem_Click(object sender, EventArgs e)
		{
			new NGramView(mainTextBox.Text, Text);
		}

		private void fitnessCaesarMenuItem_Click(object sender, EventArgs e)
		{
			if (mainTextBox.MinCharactersCountValidation(4))
				new CommonCryptanalysisView(mainTextBox.Text, Text, new CaesarCryptanalysis(), "Fitness hodnota", CryptanalysisMeasureType.Fitness, KeyType.Number);
		}

		private void chiSquareCaesarMenuItem_Click(object sender, EventArgs e)
		{
			if (mainTextBox.MinCharactersCountValidation(4))
				new CommonCryptanalysisView(mainTextBox.Text, Text, new CaesarCryptanalysis(), "Chí kvadrát", CryptanalysisMeasureType.ChiSquare, KeyType.Number);
		}

		private void fitnessAffineMenuItem_Click(object sender, EventArgs e)
		{
			if (mainTextBox.MinCharactersCountValidation(4))
				new CommonCryptanalysisView(mainTextBox.Text, Text, new AffineCipherCryptanalysis(), "Fitness hodnota", CryptanalysisMeasureType.Fitness, KeyType.TwoNumbers);
		}

		private void chiSquareAffineMenuItem_Click(object sender, EventArgs e)
		{
			if (mainTextBox.MinCharactersCountValidation(4))
				new CommonCryptanalysisView(mainTextBox.Text, Text, new AffineCipherCryptanalysis(), "Chí kvadrát", CryptanalysisMeasureType.ChiSquare, KeyType.TwoNumbers);
		}

		private void chiSquareVigenereMenuItem_Click(object sender, EventArgs e)
		{
			if (mainTextBox.MinCharactersCountValidation(4))
				new CommonCryptanalysisView(mainTextBox.Text, Text, new VigenereCipherCryptanalysis(), "Chí kvadrát", CryptanalysisMeasureType.ChiSquare, KeyType.Sequence);
		}

		private void substitutionManualCryptanalysisMenuItem_Click(object sender, EventArgs e)
		{
			if (mainTextBox.MinCharactersCountValidation(4))
				new SubstitutionManualCryptanalysisView(mainTextBox.Text);
		}

		private void hillClimbingSubstitutionMenuItem_Click(object sender, EventArgs e)
		{
			if (mainTextBox.MinCharactersCountValidation(4))
			{
				SetKeySpaceView setKeyCryptanalysisSpace = new SetKeySpaceView();
				if (setKeyCryptanalysisSpace.DialogResult == DialogResult.OK)
					new CommonCryptanalysisView(mainTextBox.Text, Text, new SubstitutionCipherCryptanalysis(decimal.ToInt32(setKeyCryptanalysisSpace.numericUpDown.Value)), "Fitness hodnota", CryptanalysisMeasureType.Fitness, KeyType.Sequence);
			}
		}


		private void fitnessColumnarTranspositionMenuItem_Click(object sender, EventArgs e)
		{
			if (mainTextBox.MinCharactersCountValidation(4))
			{
				SetKeySpaceView setKeyCryptanalysisSpace = new SetKeySpaceView(9, 15);
				if (setKeyCryptanalysisSpace.DialogResult == DialogResult.OK)
					new CommonCryptanalysisView(mainTextBox.Text, Text, new TranspositionCipherCryptanalysis(decimal.ToInt32(setKeyCryptanalysisSpace.numericUpDown.Value)), "Fitness hodnota", CryptanalysisMeasureType.Fitness, KeyType.Sequence);
			}
		}

		private void fitnessColumnarDoubleTranspositionMenuItem_Click(object sender, EventArgs e)
		{
			if (mainTextBox.MinCharactersCountValidation(4))
			{
				SetKeySpaceView setKeyCryptanalysisSpace = new SetKeySpaceView(6, 10);
				if (setKeyCryptanalysisSpace.DialogResult == DialogResult.OK)
					new CommonCryptanalysisView(mainTextBox.Text, Text, new DoubleTranspositionCipherCryptanalysis(decimal.ToInt32(setKeyCryptanalysisSpace.numericUpDown.Value)), "Fitness hodnota", CryptanalysisMeasureType.Fitness, KeyType.TwoSequencies);
			}
		}

		private void hillClimbingPlayfairMenuItem_Click(object sender, EventArgs e)
		{
			if (mainTextBox.Text.Length % 2 != 0)
			{
				MessageBox.Show("Tento text nebyl šifrován šifrou Playfair.");
				return;
			}
			if (mainTextBox.MinCharactersCountValidation(4))
			{
				SetKeySpaceView setKeyCryptanalysisSpace = new SetKeySpaceView();
				if (setKeyCryptanalysisSpace.DialogResult == DialogResult.OK)
					new CommonCryptanalysisView(mainTextBox.Text, Text, new PlayfairCipherCryptanalysis(decimal.ToInt32(setKeyCryptanalysisSpace.numericUpDown.Value)), "Fitness hodnota", CryptanalysisMeasureType.Fitness, KeyType.Sequence);
			}
		}

		private void newTextFormMenuItem_Click(object sender, EventArgs e)
		{
			FormsUtilities.OpenTextViewWithText("", "");
		}

		private void closeTextFormMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void newTextFormMenuItem_Click_1(object sender, EventArgs e)
		{
			FormsUtilities.OpenTextViewWithText("", "");
		}

		private void closeTextFormMenuItem_Click_1(object sender, EventArgs e)
		{
			Close();
			FormsUtilities.CreateTextFormIfNoneExists(1);
		}

		private void closeAllFormsMenuItem_Click(object sender, EventArgs e)
		{
			FormsUtilities.CloseAllFormsAndCreateTextForm();
		}

		private void saveMenuItem_Click(object sender, EventArgs e)
		{
			mainTextBox.Text.ShowDialogForSaveTextIntoFile();
		}

		private void TextView_FormClosed_1(object sender, FormClosedEventArgs e)
		{
			FormsUtilities.CreateTextFormIfNoneExists(2);
		}

		private void openMenuItem_Click(object sender, EventArgs e)
		{
			FormsUtilities.ShowDialogForLoadTextFromFile();
		}

		private void closeApplicationMenuItem_Click(object sender, EventArgs e)
		{
			FormsUtilities.CloseMainForm();
		}

		private void cipherKindMenuItem_Click(object sender, EventArgs e)
		{
			FormsUtilities.OpenTextViewWithText(Analysis.GetCipherIdentityMessage(mainTextBox.Text), "Určení druhu šifry");
		}

		private void SettingsTextFormMenuItem_Click(object sender, EventArgs e)
		{
		}

		#endregion

		private void MainTextBox_Click(object sender, EventArgs e) => BringToFront();
	}
}
