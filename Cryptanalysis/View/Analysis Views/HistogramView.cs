using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cryptanalysis.View.Analysis_Views
{
	public partial class HistogramView : Form
	{
		PlotView plotView;
		#region Public methods
			
		public HistogramView(string currentText, string formName, bool dialog = true)
		{
			InitializeComponent();
			Dictionary<string, double> letterFrequencies = GetAllAlphabetFrequenciesSorted(new FrequencyAnalysis(currentText.GetOnlyValidChars().ToUpper()).GetLetterFrequency(1), currentText.Length);
			Controls.Add(plotView = new PlotView() { Model = GetPlotModel(letterFrequencies, "Histogram analyzovaného textu"), Dock = DockStyle.Fill });
			Text += formName.InAngleBrackets();
			plotView.MouseDown += new MouseEventHandler(BringToFront);
			Show();
		}


		public HistogramView(bool showEnglishCommonFrequencies = true, bool dialog = false)
		{
			InitializeComponent();
			Dictionary<string, double> englishCommonFrequencies = new AnalysisUtilities().GetEnglishMonogramFrequenciesFromFile(true, true);
			Controls.Add(plotView = new PlotView() { Model = GetPlotModel(englishCommonFrequencies, "Histogram anglického textu"), Dock = DockStyle.Fill });
			Text += "Histogram anglického textu".InAngleBrackets();
			plotView.MouseDown += new MouseEventHandler(BringToFront);
			Show();
		}

		#endregion

		#region Private methods

		private Dictionary<string, double> GetAllAlphabetFrequenciesSorted(Dictionary<string, int> letterFrequencies, double lettersCount)
		{
			Dictionary<string, double> finalLetterFrequencies = new Dictionary<string, double>();
			int frequency = 0;

			foreach (var letter in CommonConstants.englishAlphabet.ToUpper())
				finalLetterFrequencies.Add(letter.ToString(), letterFrequencies.TryGetValue(letter.ToString(), out frequency) ? frequency / (lettersCount / 100) : 0);

			return finalLetterFrequencies;
		}

		private PlotModel GetPlotModel(Dictionary<string, double> frequencies, string title)
		{
			PlotModel plotModel = new PlotModel { Title = title };

			plotModel.Axes.Add(
				new CategoryAxis
				{
					ItemsSource = frequencies,
					LabelField = "Key",
					Title = "Písmena v textu",
					TitleFont = "15"
				});
			plotModel.Axes.Add(
				new LinearAxis
				{
					AbsoluteMinimum = 0,
					Title = "Četnost [%]",
					TitleFont = "15"
				});
			plotModel.Series.Add(
				new ColumnSeries
				{
					FillColor = OxyColors.Gray,
					ItemsSource = frequencies,
					ValueField = "Value",
				});

			return plotModel;
		}

		#endregion

		private void BringToFront(object sender, MouseEventArgs e) => BringToFront();
		
	}
}
