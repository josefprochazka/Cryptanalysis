using System;
using System.Windows.Forms;

namespace Cryptanalysis.View.Key_Entry_Views
{
	public partial class PolybiusKeyEntryView : Form
	{
		#region Fields

		private string text;

		#endregion

		#region Public methods

		public PolybiusKeyEntryView(string text)
		{
			this.text = text;
			InitializeComponent();
			ShowDialog();
		}

		#endregion

		#region Events

		private void encryptButton_Click(object sender, EventArgs e)
			=> this.CloseViewAndOpenTextViewWithText(Encryption.GetEncryptedTextByPolybiusCipher(text, null).ToUpper(), "Šifrový text (Polybiuv čtverec)");

		private void decryptButton_Click(object sender, EventArgs e)
			=> this.CloseViewAndOpenTextViewWithText(Decryption.GetDecryptedTextByPolybiusCipher(text, null).ToUpper(), "Dešifrovaný text (Polybiuv čtverec)");

		#endregion
	}
}
