using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cryptanalysis.View.Cryptanalysis_Views
{
	public partial class SubstitutionManualCryptanalysisView : Form
	{
		#region Fields

		private List<TextBox> allTextBoxes;
		private string cipherText;
		private List<char> actualKeySequency;
		private int sameLettersCount;

		#endregion

		#region Constructors

		public SubstitutionManualCryptanalysisView(string cipherText)
		{
			InitializeComponent();
			this.cipherText = cipherText.ToLower();
			allTextBoxes = textBoxesGroupBox.Controls.OfType<TextBox>().OrderBy(t => t.Name).ToList();
			UpdateDecipheredText();
			ShowDialog();
		}

		#endregion

		#region Events

		private void txbA_TextChanged(object sender, EventArgs e)
		{
			Validation(txbA);
		}

		private void txbB_TextChanged(object sender, EventArgs e)
		{
			Validation(txbB);
		}

		private void txbC_TextChanged(object sender, EventArgs e)
		{
			Validation(txbC);
		}

		private void txbD_TextChanged(object sender, EventArgs e)
		{
			Validation(txbD);
		}

		private void txbE_TextChanged(object sender, EventArgs e)
		{
			Validation(txbE);
		}

		private void txbF_TextChanged(object sender, EventArgs e)
		{
			Validation(txbF);
		}

		private void txbG_TextChanged(object sender, EventArgs e)
		{
			Validation(txbG);
		}

		private void txbH_TextChanged(object sender, EventArgs e)
		{
			Validation(txbH);
		}

		private void txbI_TextChanged(object sender, EventArgs e)
		{
			Validation(txbI);
		}

		private void txbJ_TextChanged(object sender, EventArgs e)
		{
			Validation(txbJ);
		}

		private void txbK_TextChanged(object sender, EventArgs e)
		{
			Validation(txbK);
		}

		private void txbL_TextChanged(object sender, EventArgs e)
		{
			Validation(txbL);
		}

		private void txbM_TextChanged(object sender, EventArgs e)
		{
			Validation(txbM);
		}

		private void txbN_TextChanged(object sender, EventArgs e)
		{
			Validation(txbN);
		}

		private void txbO_TextChanged(object sender, EventArgs e)
		{
			Validation(txbO);
		}

		private void txbP_TextChanged(object sender, EventArgs e)
		{
			Validation(txbP);
		}

		private void txbQ_TextChanged(object sender, EventArgs e)
		{
			Validation(txbQ);
		}

		private void txbR_TextChanged(object sender, EventArgs e)
		{
			Validation(txbR);
		}

		private void txbS_TextChanged(object sender, EventArgs e)
		{
			Validation(txbS);
		}

		private void txbT_TextChanged(object sender, EventArgs e)
		{
			Validation(txbT);
		}

		private void txbU_TextChanged(object sender, EventArgs e)
		{
			Validation(txbU);
		}

		private void txbV_TextChanged(object sender, EventArgs e)
		{
			Validation(txbV);
		}

		private void txbW_TextChanged(object sender, EventArgs e)
		{
			Validation(txbW);
		}

		private void txbX_TextChanged(object sender, EventArgs e)
		{
			Validation(txbX);
		}

		private void txbY_TextChanged(object sender, EventArgs e)
		{
			Validation(txbY);
		}

		private void txbZ_TextChanged(object sender, EventArgs e)
		{
			Validation(txbZ);
		}

		#endregion

		#region Private methods

		private void Validation(TextBox currentTextBox)
		{
			if (currentTextBox.Text.ContainsLettersOnly())
			{
				sameLettersCount = 0;
				foreach (var textBox in allTextBoxes)
					if (textBox.Text.ContainsLettersOnly() && currentTextBox.Text == textBox.Text)
						sameLettersCount++;
				if (sameLettersCount > 1)
				{
					MessageBox.Show("Toto písmeno se již vyskytuje v jiném okénku, a proto nemůže být vloženo zde.");
					currentTextBox.Text = "";
				}
			}
			else
				currentTextBox.Text = "";
			UpdateDecipheredText();
		}

		private void UpdateDecipheredText()
		{
			actualKeySequency = new List<char>();
			actualKeySequency.AddRange(allTextBoxes.Select(t => t.Text.IsEmpty() ? ' ' : t.Text.ToLower()[0]));
			decipheredTextTextBox.Text = new Substitution().GetDecryptedTextIfKeyCharExists(cipherText.ToStringbuilder(), new Key() { LetterSequence = actualKeySequency }).ToString();
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			allTextBoxes.ForEach(t => t.Text = "");
			UpdateDecipheredText();
		}

		#endregion
	}
}
