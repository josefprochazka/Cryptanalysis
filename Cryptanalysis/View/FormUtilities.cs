using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cryptanalysis.View
{
	public static class FormsUtilities
	{
		#region Public methods

		public static void CloseViewAndOpenTextViewWithText(this Form form, string text, string textViewName)
		{
			if (Application.OpenForms["MainView"] != null)
			{
				(Application.OpenForms["MainView"] as MainView).CreateTextForm(text, textViewName);
				form.Dispose();
			}
		}

		public static void OpenTextViewWithText(string text, string textViewName)
		{
			if (Application.OpenForms["MainView"] != null)
			{
				(Application.OpenForms["MainView"] as MainView).CreateTextForm(text, textViewName);
			}
		}

		public static void OpenFormInMainForm(Form form, bool show = false)
		{
			if (Application.OpenForms["MainView"] != null)
			{
				(Application.OpenForms["MainView"] as MainView).SetMainFormAsMdiParent(form);
				if (show)
					form.Show();
			}
		}

		public static void CloseAllFormsAndCreateTextForm()
		{
			if (Application.OpenForms["MainView"] != null)
			{
				(Application.OpenForms["MainView"] as MainView).CloseAllFormsAndCreateTextForm();
			}
		}

		public static void CreateTextFormIfNoneExists(int minPossibleOpenForms)
		{
			if (Application.OpenForms["MainView"] != null)
			{
				(Application.OpenForms["MainView"] as MainView).CreateTextFormIfNoneExists(minPossibleOpenForms);
			}
		}

		public static void CloseMainForm()
		{
			if (Application.OpenForms["MainView"] != null)
			{
				(Application.OpenForms["MainView"] as MainView).CloseMainForm();
			}
		}

		public static string InAngleBrackets(this string text)
		{
			return " <" + text + ">";
		}

		public static void SetCursorAtEnd(this TextBox textBox)
		{
			textBox.SelectionStart = textBox.Text.Length;
		}

		public static void RemoveNonDigitsChars(this TextBox textBox)
		{
			textBox.Text = textBox.Text.GetOnlyNumbers();
		}

		public static void RemoveNonLetterChars(this TextBox textBox)
		{
			textBox.Text = textBox.Text.GetOnlyValidChars();
		}

		public static void RemoveDuplicates(this TextBox textBox)
		{
			textBox.Text = textBox.Text.ToList().RemoveDuplicates().TransferToString();
		}

		public static void Replace(this TextBox textBox, string oldString, string newString)
		{
			textBox.Text = textBox.Text.Replace(oldString, newString);
		}

		public static void OnlyLettersOrDisableButtons(this TextBox textBox, Button encryptButton, Button decryptButton)
		{
			encryptButton.Enabled = textBox.Text.Length > 0;
			decryptButton.Enabled = textBox.Text.Length > 0;

			if (textBox.Text.Length > 0)
				textBox.RemoveNonLetterChars();
			textBox.SetCursorAtEnd();
		}

		public static void ShowDialogForSaveTextIntoFile(this string text)
		{
			using (SaveFileDialog dialog = new SaveFileDialog())
			{
				string pathToFile = "";

				dialog.Filter = "txt files (*.txt)|*.txt";
				dialog.RestoreDirectory = true;

				if (dialog.ShowDialog() == DialogResult.OK)
					pathToFile = dialog.FileName;

				if (!string.IsNullOrEmpty(pathToFile))
					using (StreamWriter sw = new StreamWriter(pathToFile))
						sw.Write(text);
			}
		}

		public static void ShowDialogForLoadTextFromFile()
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			if (fileDialog.ShowDialog() == DialogResult.OK)
				OpenTextViewWithText(File.ReadAllText(fileDialog.FileName), "");
		}

		public static bool MinCharactersCountValidation(this TextBox textbox, int minimumCharacters)
		{
			if (textbox.Text.Length < minimumCharacters)
			{
				MessageBox.Show("Text musí obsahovat minimálně " + minimumCharacters + " znaky. Pro kvalitnější výsledky je potřeba delší text.");
				return false;
			}
			return true;
		}

		#endregion
	}
}
