using System;
using System.Windows.Forms;

namespace Cryptanalysis.View.Key_Entry_Views
{
	public partial class RailfenceKeyEntryView : Form
	{
		#region Fields

		private string text;

		#endregion

		#region Constructors

		public RailfenceKeyEntryView(string text)
		{
			this.text = text;
			InitializeComponent();
			ShowDialog();
		}

		#endregion

		#region Events

		private void letterKeyTextBox_TextChanged(object sender, EventArgs e)
		{
			if (!letterKeyTextBox.Text.IsEmpty())
				if (letterKeyTextBox.Text.ContainsDigitsOnly() && int.Parse(letterKeyTextBox.Text).IsNumberInRange(1, text.Length))
					encryptButton.Enabled = decryptButton.Enabled = true;
				else
				{
					encryptButton.Enabled = decryptButton.Enabled = false;
					letterKeyTextBox.RemoveNonDigitsChars();
					letterKeyTextBox.SetCursorAtEnd();
				}
			else
				encryptButton.Enabled = decryptButton.Enabled = false;
		}

		private void encryptButton_Click(object sender, EventArgs e)
			=> this.CloseViewAndOpenTextViewWithText(Encryption.GetEncryptedTextByRailFenceCipher(text, new Key() { SingleNumber = int.Parse(letterKeyTextBox.Text) }), "Šifrový text (Rail fence šifra)");

		private void decryptButton_Click(object sender, EventArgs e)
			=> this.CloseViewAndOpenTextViewWithText(Decryption.GetDecryptedTextByRailFenceCipher(text, new Key() { SingleNumber = int.Parse(letterKeyTextBox.Text) }), "Dešifrovaný text (Rail fence šifra)");

		#endregion
	}
}
