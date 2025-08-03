using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cryptanalysis.View.Key_Entry_Views
{
	public partial class VernamKeyEntryView : Form
	{
		#region Fields

		private List<char> key;
		private string text;

		#endregion

		#region Constructors

		public VernamKeyEntryView(string text)
		{
			this.text = text;
			InitializeComponent();
			ShowDialog();
		}

		#endregion

		#region Events

		private void encryptButton_Click(object sender, EventArgs e)
		{
			key = RandomsOperations.GetRandomCurrentAlphabetLettersList(text.Length);
			this.CloseViewAndOpenTextViewWithText(Encryption.GetEncryptedTextByVernamCipher(text, new Key() { LetterSequence = key }), "Šifrový text (Vernamova šifra)");
			this.CloseViewAndOpenTextViewWithText(key.TransferToString(), "Klíč (Vernamova šifra)");
		}

		#endregion
	}
}
