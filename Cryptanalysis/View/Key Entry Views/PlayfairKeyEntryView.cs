using System;
using System.Linq;
using System.Windows.Forms;

namespace Cryptanalysis.View.Key_Entry_Views
{
	public partial class PlayfairKeyEntryView : Form
	{
		#region Fields

		private string text;
		private int counter;
		private string preparedKey;

		#endregion

		#region Constructors

		public PlayfairKeyEntryView(string text)
		{
			this.text = text;
			InitializeComponent();
			FillMatrix(new Key() { LetterSequence = "".ToList() });
			ShowDialog();
		}

		#endregion

		#region Events

		private void letterKeyTextBox_TextChanged(object sender, EventArgs e)
		{
			if (letterKeyTextBox.Text.Length > 0)
			{
				letterKeyTextBox.RemoveNonLetterChars();
				letterKeyTextBox.Replace("J", "");
			}
			letterKeyTextBox.SetCursorAtEnd();

			FillMatrix(new Key() { LetterSequence = letterKeyTextBox.Text.ToLower().ToList() });
		}

		private void encryptButton_Click(object sender, EventArgs e)
			=> this.CloseViewAndOpenTextViewWithText(Encryption.GetEncryptedTextByPlayfairCipher(text, new Key() { LetterSequence = letterKeyTextBox.Text.ToLower().ToList() }).ToUpper(), "Šifrový text (Playfair šifra)");

		private void decryptButton_Click(object sender, EventArgs e)
			=> this.CloseViewAndOpenTextViewWithText(Decryption.GetDecryptedTextByPlayfairCipher(text.ToLower(), new Key() { LetterSequence = letterKeyTextBox.Text.ToLower().ToList() }).ToUpper(), "Dešifrovaný text (Playfair šifra)");

		#endregion

		#region Private methods

		private void FillMatrix(Key key)
		{
			counter = 0;
			preparedKey = new Playfair().GetKeyAndAlphabetJoined(key);
			letterMatrixGroupBox.Controls.OfType<TextBox>().OrderBy(t => t.Name).ToList().ForEach(t => t.Text = preparedKey[counter++].ToString());
		}

		#endregion
	}
}
