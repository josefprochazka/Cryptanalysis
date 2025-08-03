using Cryptanalysis.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cryptanalysis.View.Key_Entry_Views
{
	public partial class HillKeyEntryView : Form
	{
		#region Fields

		private string text;
		private List<string> hillRandomKeys = new List<string>();
		private Random random = new Random();
		Func<int, int, int> GCD = MathematicalOperations.GetGreatestCommonDivisor;
		string alphabet = CommonConstants.englishAlphabet;

		#endregion

		#region Constructors

		public HillKeyEntryView(string text)
		{
			InitializeComponent();
			this.text = text;
			foreach (string key in Regex.Split(Resources.HillLetterKeys.ToString(), "\r\n"))
				hillRandomKeys.Add(key);
			encryptButton.Enabled = decryptButton.Enabled = false;
			ShowDialog();
		}

		#endregion

		#region Events

		private void setKeyAsCharRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			numberMatrixGroupBox.Enabled = !setKeyAsCharRadioButton.Checked;
			letterMatrixGroupBox.Enabled = setKeyAsCharRadioButton.Checked;
		}

		private void letterKeyLeftUpTextBox_TextChanged(object sender, EventArgs e)
		{
			ValidateLetterTextBox(letterKeyLeftUpTextBox, numberKeyLeftUpTextBox);
		}

		private void letterKeyRightUpTextBox_TextChanged(object sender, EventArgs e)
		{
			ValidateLetterTextBox(letterKeyRightUpTextBox, numberKeyRightUpTextBox);
		}

		private void letterKeyLeftDownTextBox_TextChanged(object sender, EventArgs e)
		{
			ValidateLetterTextBox(letterKeyLeftDownTextBox, numberKeyLeftDownTextBox);
		}

		private void letterKeyRightDownTextBox_TextChanged(object sender, EventArgs e)
		{
			ValidateLetterTextBox(letterKeyRightDownTextBox, numberKeyRightDownTextBox);
		}

		private void numberKeyLeftUpTextBox_TextChanged(object sender, EventArgs e)
		{
			ValidateNumberTextbox(numberKeyLeftUpTextBox, letterKeyLeftUpTextBox);
		}

		private void numberKeyRightUpTextBox_TextChanged(object sender, EventArgs e)
		{
			ValidateNumberTextbox(numberKeyRightUpTextBox, letterKeyRightUpTextBox);
		}

		private void numberKeyLeftDownTextBox_TextChanged(object sender, EventArgs e)
		{
			ValidateNumberTextbox(numberKeyLeftDownTextBox, letterKeyLeftDownTextBox);
		}

		private void numberKeyRightDownTextBox_TextChanged(object sender, EventArgs e)
		{
			ValidateNumberTextbox(numberKeyRightDownTextBox, letterKeyRightDownTextBox);
		}

		private void resetKeyButton_Click(object sender, EventArgs e)
		{
			letterMatrixGroupBox.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = "");
		}

		private void generateKeyButton_Click(object sender, EventArgs e)
		{
			string temp = hillRandomKeys.ElementAt(random.Next(hillRandomKeys.Count));
			letterKeyLeftUpTextBox.Text = temp[0].ToString();
			letterKeyRightUpTextBox.Text = temp[1].ToString();
			letterKeyLeftDownTextBox.Text = temp[2].ToString();
			letterKeyRightDownTextBox.Text = temp[3].ToString();
		}

		private void encryptButton_Click(object sender, EventArgs e)
		{
			int determinant = numberKeyLeftUpTextBox.Text.ToInteger() * numberKeyRightDownTextBox.Text.ToInteger() - numberKeyRightUpTextBox.Text.ToInteger() * numberKeyLeftDownTextBox.Text.ToInteger();
			if (GCD(determinant, alphabet.Length) == 1)
				this.CloseViewAndOpenTextViewWithText(
					Encryption.GetEncryptedTextByHillCipher(
						text,
						new Key()
						{
							LetterSequence = new List<char>()
							{
								letterKeyLeftUpTextBox.Text[0],
								letterKeyRightUpTextBox.Text[0],
								letterKeyLeftDownTextBox.Text[0],
								letterKeyRightDownTextBox.Text[0],
							}
						}),
					"Šifrový text (Hill šifra)");
			else
				MessageBox.Show("Tato matice nemůže být invertována s modulo " + alphabet.Length + " (počet znaků v otevřené abecedě), a proto nemůže být použita pro tuto šifru. Buď změňte obsah matice, nebo klikněte na tlačítko \"Vygenerovat klíč\", které vytvoří použitelnou matici pro tuto šifru.");
		}

		private void decryptButton_Click(object sender, EventArgs e)
		{
			int determinant = numberKeyLeftUpTextBox.Text.ToInteger() * numberKeyRightDownTextBox.Text.ToInteger() - numberKeyRightUpTextBox.Text.ToInteger() * numberKeyLeftDownTextBox.Text.ToInteger();
			if (GCD(determinant, alphabet.Length) == 1)
				this.CloseViewAndOpenTextViewWithText(
					Decryption.GetDecryptedTextByHillCipher(
						text,
						new Key()
						{
							LetterSequence = new List<char>()
							{
								letterKeyLeftUpTextBox.Text[0],
								letterKeyRightUpTextBox.Text[0],
								letterKeyLeftDownTextBox.Text[0],
								letterKeyRightDownTextBox.Text[0],
							}
						}),
					"Šifrový text (Hill šifra)");
			else
				MessageBox.Show("Tato matice nemůže být invertována s modulo " + alphabet.Length + " (počet znaků v otevřené abecedě), a proto nemůže být použita pro tuto šifru. Buď změňte obsah matice, nebo klikněte na tlačítko \"Vygenerovat klíč\", které vytvoří použitelnou matici pro tuto šifru.");
		}

		#endregion

		#region Private methods

		private bool AllLetterTexboxesAreFilled()
		{
			return !letterKeyLeftUpTextBox.Text.IsEmpty() && !letterKeyLeftDownTextBox.Text.IsEmpty() && !letterKeyRightUpTextBox.Text.IsEmpty() && !letterKeyRightDownTextBox.Text.IsEmpty();
		}

		private bool AllNumberTexboxesAreFilled()
		{
			return !numberKeyLeftUpTextBox.Text.IsEmpty() && !numberKeyLeftDownTextBox.Text.IsEmpty() && !numberKeyRightUpTextBox.Text.IsEmpty() && !numberKeyRightDownTextBox.Text.IsEmpty();
		}

		private void ValidateLetterTextBox(TextBox letterTextBox, TextBox numberTextBox)
		{
			if (!letterTextBox.Text.IsEmpty() && letterTextBox.Text[0].IsLetter())
			{
				encryptButton.Enabled = decryptButton.Enabled = true;
				numberTextBox.Text = letterTextBox.Text[0].ToNumber().ToString();
				letterTextBox.SetCursorAtEnd();
			}
			else
			{
				encryptButton.Enabled = decryptButton.Enabled = false;
				letterTextBox.RemoveNonLetterChars();
				letterTextBox.SetCursorAtEnd();
				numberTextBox.Text = "";
			}

			if (!AllLetterTexboxesAreFilled())
				encryptButton.Enabled = decryptButton.Enabled = false;
		}

		private void ValidateNumberTextbox(TextBox numberTextBox, TextBox letterTextBox)
		{
			if (!numberTextBox.Text.IsEmpty())
				if (numberTextBox.Text.ContainsDigitsOnly())
					if (numberTextBox.Text.ToInteger().IsNumberInRange(0, alphabet.Length - 1))
					{
						encryptButton.Enabled = decryptButton.Enabled = true;
						letterTextBox.Text = numberTextBox.Text.ToInteger().ToLetter().ToString();
					}
					else
						numberTextBox.Text = "";
				else
				{
					encryptButton.Enabled = decryptButton.Enabled = false;
					numberTextBox.RemoveNonDigitsChars();
					numberTextBox.SetCursorAtEnd();
				}
			else
				letterTextBox.Text = "";

			if (!AllNumberTexboxesAreFilled())
				encryptButton.Enabled = decryptButton.Enabled = false;
		}

		#endregion
	}
}
