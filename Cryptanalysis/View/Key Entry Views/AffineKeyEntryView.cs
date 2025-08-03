using System;
using System.Windows.Forms;

namespace Cryptanalysis.View.Key_Entry_Views
{
	public partial class AffineKeyEntryView : Form
	{
		#region Fields

		private string text;
		private int m = CommonConstants.englishAlphabet.Length;
		private Func<int, int, int> GCD = MathematicalOperations.GetGreatestCommonDivisor;
		private string alphabet = CommonConstants.englishAlphabet;

		#endregion

		#region Constructors

		public AffineKeyEntryView(string text)
		{
			this.text = text;
			InitializeComponent();
			fromAlphabetTextBox.Text = alphabet;
			toAlphabetTextBox.Text = Encryption.GetEncryptedTextByAffineCipher(alphabet, new Key() { AffineKey = new AffineKey() { A = 3, B = 7, M = m } });
			ShowDialog();
		}

		#endregion

		#region Events

		private void setAKeyTextBox_TextChanged(object sender, EventArgs e)
		{
			Validate(setAKeyTextBox, setBKeyTextBox);
		}

		private void setBKeyTextBox_TextChanged(object sender, EventArgs e)
		{
			Validate(setAKeyTextBox, setBKeyTextBox);
		}

		private void encryptButton_Click(object sender, EventArgs e) => this.CloseViewAndOpenTextViewWithText(
			Encryption.GetEncryptedTextByAffineCipher(
				text,
				new Key()
				{
					AffineKey =
					new AffineKey()
					{
						A = setAKeyTextBox.Text.ToInteger(),
						B = setBKeyTextBox.Text.ToInteger(),
						M = m
					}
				}),
			"Šifrový text (Afinní šifra)"
			);

		private void decryptButton_Click(object sender, EventArgs e) => this.CloseViewAndOpenTextViewWithText(
			Decryption.GetDecryptedTextByAffineCipher(
				text,
				new Key()
				{
					AffineKey =
					new AffineKey()
					{
						A = setAKeyTextBox.Text.ToInteger(),
						B = setBKeyTextBox.Text.ToInteger(),
						M = m,
						InverseOfA = setAKeyTextBox.Text.ToInteger().ToInverseMember()
					}
				}),
			"Dešifrovaný text (Afinní šifra)"
			);

		#endregion

		#region Private methods

		private void Validate(TextBox textBoxA, TextBox textBoxB)
		{
			if (textBoxA.Text.Length > 0 && textBoxB.Text.Length > 0)
				if (textBoxA.Text.ContainsDigitsOnly() && textBoxB.Text.ContainsDigitsOnly())
				{
					encryptButton.Enabled = decryptButton.Enabled = true;
					if (textBoxA.Text.ToInteger().IsNumberInRange(1, m - 1) && GCD(textBoxA.Text.ToInteger(), m) == 1 && textBoxB.Text.ToInteger().IsNumberInRange(1, m - 1))
						toAlphabetTextBox.Text = Encryption.GetEncryptedTextByAffineCipher(alphabet, new Key() { AffineKey = new AffineKey() { A = textBoxA.Text.ToInteger(), B = textBoxB.Text.ToInteger(), M = m } });
					else
						encryptButton.Enabled = decryptButton.Enabled = false;
				}
				else
					ClearTextInTextboxes(textBoxA, textBoxB);
			else
				ClearTextInTextboxes(textBoxA, textBoxB);

		}

		private void ClearTextInTextboxes(TextBox textBoxA, TextBox textBoxB)
		{
			textBoxA.RemoveNonDigitsChars();
			textBoxB.RemoveNonDigitsChars();
			textBoxA.SetCursorAtEnd();
			textBoxB.SetCursorAtEnd();
		}

		#endregion
	}
}