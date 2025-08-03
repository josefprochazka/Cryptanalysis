using System.Linq;
using System.Windows.Forms;

namespace Cryptanalysis.View.Key_Entry_Views
{
	public partial class DoubleTranspositionKeyEntryView : Form
	{
		#region Fields

		private string text;

		#endregion

		#region Constructors

		public DoubleTranspositionKeyEntryView(string text)
		{
			this.text = text;
			InitializeComponent();
			encryptButton.Enabled = decryptButton.Enabled = false;
			ShowDialog();
		}

		#endregion

		#region Events

		private void firstLetterKeyTextBox_TextChanged(object sender, System.EventArgs e)
		{
			firstLetterKeyTextBox.OnlyLettersOrDisableButtons(encryptButton, decryptButton);
			encryptButton.Enabled = decryptButton.Enabled = firstLetterKeyTextBox.Text.Length > 0 && secondLetterKeyTextBox.Text.Length > 0;
		}

		private void secondLetterKeyTextBox_TextChanged(object sender, System.EventArgs e)
		{
			secondLetterKeyTextBox.OnlyLettersOrDisableButtons(encryptButton, decryptButton);
			encryptButton.Enabled = decryptButton.Enabled = firstLetterKeyTextBox.Text.Length > 0 && secondLetterKeyTextBox.Text.Length > 0;
		}

		private void encryptButton_Click(object sender, System.EventArgs e) =>
			this.CloseViewAndOpenTextViewWithText(
					Encryption.GetEncryptedTextByDoubleTranspositionCipher(
						text,
						new Key()
						{
							DoubleTranspositionKey = new DoubleTranspositionKey()
							{
								Key1 = firstLetterKeyTextBox.Text.ToLower().ToList(),
								Key2 = secondLetterKeyTextBox.Text.ToLower().ToList()
							}
						}),
					"Šifrový text (Dvojitá transpoziční šifra)");

		private void decryptButton_Click(object sender, System.EventArgs e) =>
			this.CloseViewAndOpenTextViewWithText(
					Decryption.GetDecryptedTextByDoubleTranspositionCipher(
						text,
						new Key()
						{
							DoubleTranspositionKey = new DoubleTranspositionKey()
							{
								Key1 = firstLetterKeyTextBox.Text.ToLower().ToList(),
								Key2 = secondLetterKeyTextBox.Text.ToLower().ToList()
							}
						}),
					"Dešifrovaný text (Dvojitá transpoziční šifra)");

		#endregion
	}
}
