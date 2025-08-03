using System.Linq;
using System.Windows.Forms;

namespace Cryptanalysis.View.Key_Entry
{
	public partial class VigenereKeyEntryView : Form
	{
		#region Fields

		private string text;

		#endregion

		#region Constructors

		public VigenereKeyEntryView(string text)
		{
			this.text = text;
			InitializeComponent();
			encryptButton.Enabled = decryptButton.Enabled = false;
			ShowDialog();
		}

		#endregion

		#region Events

		private void letterKeyTextBox_TextChanged(object sender, System.EventArgs e)
		{
			letterKeyTextBox.OnlyLettersOrDisableButtons(encryptButton, decryptButton);
		}

		private void encryptButton_Click(object sender, System.EventArgs e)
			=> this.CloseViewAndOpenTextViewWithText(Encryption.GetEncryptedTextByVigenereCipher(text, new Key() { LetterSequence = letterKeyTextBox.Text.ToList() }), "Šifrový text (Vigenerova šifra)");

		private void decryptButton_Click(object sender, System.EventArgs e)
			=> this.CloseViewAndOpenTextViewWithText(Decryption.GetDecryptedTextByVigenereCipher(text, new Key() { LetterSequence = letterKeyTextBox.Text.ToList() }), "Dešifrovaný text (Vigenerova šifra)");

		#endregion
	}
}
