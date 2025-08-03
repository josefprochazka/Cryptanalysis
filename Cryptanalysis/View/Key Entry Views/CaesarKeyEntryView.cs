using System;
using System.Windows.Forms;

namespace Cryptanalysis.View.Key_Entry
{
	public partial class CaesarKeyEntryView : Form
	{
		#region Fields

		private string text;

		#endregion

		#region Constructors

		public CaesarKeyEntryView(string text)
		{
			this.text = text;
			InitializeComponent();
			fromAlphabetTextBox.Text = CommonConstants.englishAlphabet;
			toAlphabetTextBox.Text = Encryption.GetEncryptedTextByCaesarCipher(CommonConstants.englishAlphabet, new Key() { SingleNumber = 1 });
			ShowDialog();
		}

		#endregion

		#region Events

		private void setKeyAsCharRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			setKeyAsNumberTextBox.ReadOnly = setKeyAsCharRadioButton.Checked;
			setKeyAsCharTextBox.ReadOnly = !setKeyAsCharRadioButton.Checked;
		}

		private void setKeyAsCharTextBox_TextChanged(object sender, EventArgs e)
		{
			if (!setKeyAsCharTextBox.Text.IsEmpty() && setKeyAsCharTextBox.Text[0].IsLetter())
			{
				encryptButton.Enabled = decryptButton.Enabled = true;
				setKeyAsNumberTextBox.Text = setKeyAsCharTextBox.Text[0].ToNumber().ToString();
				setKeyAsCharTextBox.SetCursorAtEnd();
			}
			else
				DisableButtonsAndClearTextBoxes();
		}

		private void setKeyAsNumberTextBox_TextChanged(object sender, EventArgs e)
		{
			if (!setKeyAsNumberTextBox.Text.IsEmpty())
				if (setKeyAsNumberTextBox.Text.ContainsDigitsOnly() && setKeyAsNumberTextBox.Text.ToInteger().IsNumberInRange(0, CommonConstants.englishAlphabet.Length - 1))
				{
					encryptButton.Enabled = decryptButton.Enabled = true;
					setKeyAsCharTextBox.Text = setKeyAsNumberTextBox.Text.ToInteger().ToLetter().ToString();
					toAlphabetTextBox.Text = Encryption.GetEncryptedTextByCaesarCipher(CommonConstants.englishAlphabet, new Key() { SingleNumber = int.Parse(setKeyAsNumberTextBox.Text) });
					shiftValueLabel.Text = setKeyAsNumberTextBox.Text;
				}
				else
				{
					encryptButton.Enabled = decryptButton.Enabled = false;
					shiftValueLabel.Text = toAlphabetTextBox.Text = "";
					setKeyAsNumberTextBox.RemoveNonDigitsChars();
					setKeyAsNumberTextBox.SetCursorAtEnd();
				}
			else
				DisableButtonsAndClearTextBoxes();
		}

		private void encryptButton_Click(object sender, EventArgs e)
			=> this.CloseViewAndOpenTextViewWithText(Encryption.GetEncryptedTextByCaesarCipher(text, new Key() { SingleNumber = setKeyAsNumberTextBox.Text.ToInteger() }), "Šifrový text (Caesarova šifra)");

		private void decryptButton_Click(object sender, EventArgs e)
			=> this.CloseViewAndOpenTextViewWithText(Decryption.GetDecryptedTextByCaesarCipher(text, new Key() { SingleNumber = setKeyAsNumberTextBox.Text.ToInteger() }), "Dešifrovaný text (Caesarova šifra)");

		#endregion

		#region Private methods

		private void DisableButtonsAndClearTextBoxes()
		{
			encryptButton.Enabled = decryptButton.Enabled = false;
			shiftValueLabel.Text = toAlphabetTextBox.Text = setKeyAsCharTextBox.Text = setKeyAsNumberTextBox.Text = "";
		}

		#endregion
	}
}
