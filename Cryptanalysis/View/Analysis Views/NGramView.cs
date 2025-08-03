using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cryptanalysis.View.Analysis_Views
{
	public partial class NGramView : Form
	{
		#region Fields

		private string analysingText;
		private List<NGramData> actualNGramData;
		private string texbBoxFormName;

		#endregion

		#region Constructors

		public NGramView(string text, string formName)
		{
			InitializeComponent();
			texbBoxFormName = formName;
			analysingText = text.GetOnlyValidChars().ToUpper();
			Text = "Seznam n-gramů" + formName.InAngleBrackets();
			histogramRadioButton.Checked = true;
			ShowDialog();
		}

		#endregion

		#region Events

		private void histogramRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			RefreshDataGridView(Analysis.GetMonogramsFrequency(analysingText));
		}

		private void bigramRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			RefreshDataGridView(Analysis.GetBigramsFrequency(analysingText));
		}

		private void trigramRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			RefreshDataGridView(Analysis.GetTrigramsFrequency(analysingText));
		}

		private void nGramRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			computeButton_Click(sender, e);
		}

		private void computeButton_Click(object sender, EventArgs e)
		{
			if (histogramRadioButton.Checked)
				RefreshDataGridView(Analysis.GetMonogramsFrequency(analysingText));
			else if (bigramRadioButton.Checked)
				RefreshDataGridView(Analysis.GetBigramsFrequency(analysingText));
			else if (trigramRadioButton.Checked)
				RefreshDataGridView(Analysis.GetTrigramsFrequency(analysingText));
			else if (nGramRadioButton.Checked)
			{
				if (nGramTextBox.Text.IsEmpty())
					nGramTextBox.Text = "4";
				RefreshDataGridView(new FrequencyAnalysis(analysingText).GetLetterFrequency(nGramTextBox.Text.ToInteger()));
			}
		}

		private void saveListButton_Click(object sender, EventArgs e)
		{
			string message = "N-gramy textu ze souboru " + texbBoxFormName.InAngleBrackets() + "." + Environment.NewLine +
				"Seřazené sestupně v závislosti na četnosti výskytu daného n-gramu." + Environment.NewLine + Environment.NewLine +
				"Pořadí \tN-gram \tČetnost \tČetnost [%]" + Environment.NewLine;

			foreach (var item in actualNGramData)
				message += item.Number.ToString() + "\t" + item.CharacterSequency + "\t" + item.Frequency.ToString() + "\t" + item.FrequencyAsPercent.ToString() + Environment.NewLine;

			this.CloseViewAndOpenTextViewWithText(message, "N-gramy");
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void nGramTextBox_TextChanged(object sender, EventArgs e)
		{
			if (!nGramTextBox.Text.IsEmpty())
				if (nGramTextBox.Text.ContainsDigitsOnly())
					if (nGramTextBox.Text.ToInteger().IsNumberInRange(1, 15))
					{
						nGramTextBox.RemoveNonDigitsChars();
						nGramTextBox.SetCursorAtEnd();
					}
					else
					{
						MessageBox.Show("Počet písmen N-gramu vybírejte v rozsahu 1-15.");
						nGramTextBox.Text = "4";
						nGramTextBox.SetCursorAtEnd();
					}
				else
				{
					nGramTextBox.RemoveNonDigitsChars();
					nGramTextBox.SetCursorAtEnd();
				}
		}

		private void ngramCountTextBox_TextChanged(object sender, EventArgs e)
		{
			ngramCountTextBox.RemoveNonDigitsChars();
			ngramCountTextBox.SetCursorAtEnd();
		}

		#endregion

		#region Private methods

		private void RefreshDataGridView(Dictionary<string, int> nGramFrequencies)
		{
			List<NGramData> nGramData = new List<NGramData>();
			int counter = 1;

			nGramFrequencies.ToList().ForEach(
				f => nGramData.Add(
					new NGramData()
					{
						CharacterSequency = f.Key,
						Frequency = f.Value,
						FrequencyAsPercent = Math.Round(Convert.ToDouble(f.Value) / Convert.ToDouble(analysingText.Length), 4)
					})
				);

			nGramData.Sort();
			nGramData.ForEach(f => f.Number = counter++);
			nGramDataGridView.DataSource = actualNGramData = (ngramCountTextBox.Text.IsEmpty()) ? nGramData.TakeRange(1000) : nGramData.TakeRange(ngramCountTextBox.Text.ToInteger());
			nGramDataGridView.Refresh();

			nGramDataGridView.Columns[0].HeaderText = "Pořadí";
			nGramDataGridView.Columns[1].HeaderText = histogramRadioButton.Checked ? "Monogramy" : bigramRadioButton.Checked ? "Bigramy" : trigramRadioButton.Checked ? "Trigramy" : "N-gramy";
			nGramDataGridView.Columns[2].HeaderText = "Četnost";
			nGramDataGridView.Columns[3].HeaderText = "Četnost [%]";
			nGramDataGridView.Columns[0].Width = 90;
		}

		#endregion
	}

	#region Other classes

	public class NGramData : IComparable<NGramData>
	{
		public int Number { get; set; }

		public string CharacterSequency { get; set; }

		public double Frequency { get; set; }

		public double FrequencyAsPercent { get; set; }

		public int CompareTo(NGramData other) => other.Frequency.CompareTo(Frequency);
	}

	#endregion
}
