using System.Linq;
using System.Windows.Forms;

namespace Cryptanalysis.View.Key_Entry_Views
{
	public partial class SubstitutionKeyEntryView : Form
	{
		#region Fields

		private string text;
		private string alphabet = CommonConstants.englishAlphabet;

		#endregion

		#region Public methods

		public SubstitutionKeyEntryView(string text)
		{
			this.text = text;
			InitializeComponent();
			fromAlphabetTextBox.Text = alphabet;
			toAlphabetTextBox.Text = alphabet;
			ShowDialog();
		}

		#endregion

		#region Events

		private void letterKeyTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (!letterKeyTextBox.Text.IsEmpty())
			{
				letterKeyTextBox.RemoveNonLetterChars();
				letterKeyTextBox.RemoveDuplicates();
				toAlphabetTextBox.Text = letterKeyTextBox.Text + alphabet.RemoveSomeChars(letterKeyTextBox.Text.ToLower().ToCharArray());
			}
			else
				toAlphabetTextBox.Text = alphabet;
			letterKeyTextBox.SelectionStart = letterKeyTextBox.Text.Length;
		}

		private void randomPermutationButton_Click(object sender, System.EventArgs e)
		{
			toAlphabetTextBox.Text = letterKeyTextBox.Text = RandomsOperations.GetRandomAlphabetPermutation().TransferToString();
		}

		private void encryptButton_Click(object sender, System.EventArgs e)
			=> this.CloseViewAndOpenTextViewWithText(Encryption.GetEncryptedTextBySubstitutionCipher(text, new Key() { LetterSequence = toAlphabetTextBox.Text.ToLower().ToList() }), "Šifrový text (Obecná substituční šifra)");

		private void decryptButton_Click(object sender, System.EventArgs e)
			=> this.CloseViewAndOpenTextViewWithText(Decryption.GetDecryptedTextBySubstitutionCipher(text, new Key() { LetterSequence = toAlphabetTextBox.Text.ToLower().ToList() }), "Dešifrovaný text (Obecná substituční šifra)");

		#endregion
	}
}
