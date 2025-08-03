using System;
using System.Linq;
using System.Windows.Forms;

namespace Cryptanalysis.View.Key_Entry_Views
{
	public partial class TranspositionKeyEntryView : Form
	{
		#region Fields

		private string text;
		private string cipherSettingDescription;
		private string tableSettingDescription;

		#endregion

		#region Constructors

		public TranspositionKeyEntryView(string text)
		{
			this.text = text;
			InitializeComponent();
			encryptButton.Enabled = decryptButton.Enabled = false;
			cipherSettingDescription = "sloupcích";
			tableSettingDescription = "neúplná";
			UpdateSettingDescription();
			ShowDialog();
		}

		#endregion

		#region Events

		private void letterKeyTextBox_TextChanged(object sender, EventArgs e)
		{
			letterKeyTextBox.OnlyLettersOrDisableButtons(encryptButton, decryptButton);
			UpdateSettingDescription();
		}

		private void columnTranspositionRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			rowTranspositionRadioButton.Checked = !columnTranspositionRadioButton.Checked;
			cipherSettingDescription = "sloupcích";
			UpdateSettingDescription();
		}

		private void rowTranspositionRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			columnTranspositionRadioButton.Checked = !rowTranspositionRadioButton.Checked;
			cipherSettingDescription = "řádcích";
			UpdateSettingDescription();
		}

		private void completeTableRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			irregularTableRadioButton.Checked = !completeTableRadioButton.Checked;
			tableSettingDescription = "doplněna náhodnými písmeny";
			UpdateSettingDescription();
		}

		private void irregularTableRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			completeTableRadioButton.Checked = !irregularTableRadioButton.Checked;
			tableSettingDescription = "neúplná";
			UpdateSettingDescription();
		}

		private void encryptButton_Click(object sender, EventArgs e)
		{
			if (columnTranspositionRadioButton.Checked)
				this.CloseViewAndOpenTextViewWithText(
					Encryption.GetEncryptedTextByColumnTranspositionCipher(
						text,
						new Key() { LetterSequence = letterKeyTextBox.Text.ToLower().ToList() },
						irregularTableRadioButton.Checked),
					"Šifrový text (Transpoziční šifra)");
			else
				this.CloseViewAndOpenTextViewWithText(
					Encryption.GetEncryptedTextByRowTranspositionCipher(
						text,
						new Key() { LetterSequence = letterKeyTextBox.Text.ToLower().ToList() },
						irregularTableRadioButton.Checked),
					"Šifrový text (Transpoziční šifra)");
		}

		private void decryptButton_Click(object sender, EventArgs e)
		{
			if (columnTranspositionRadioButton.Checked)
				this.CloseViewAndOpenTextViewWithText(
					Decryption.GetDecryptedTextByColumnTranspositionCipher(
						text,
						new Key() { LetterSequence = letterKeyTextBox.Text.ToLower().ToList() },
						irregularTableRadioButton.Checked),
					"Dešiforvaný text (Transpoziční šifra)");
			else
				this.CloseViewAndOpenTextViewWithText(
					Decryption.GetDecryptedTextByRowTranspositionCipher(
						text,
						new Key() { LetterSequence = letterKeyTextBox.Text.ToLower().ToList() },
						irregularTableRadioButton.Checked),
					"Dešiforvaný text (Transpoziční šifra)");
		}

		#endregion

		#region Private methods

		private void UpdateSettingDescription()
		{
			cipherAndTableSettingsDescriptionLabel.Text = "Text se bude do tabulky vkládat po řádcích a číst po " + cipherSettingDescription + ". Tabulka bude " + tableSettingDescription + ".";
		}

		#endregion
	}
}
