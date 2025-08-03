using Cryptanalysis.View.Analysis_Views;
using System.Linq;
using System.Windows.Forms;

namespace Cryptanalysis.View.Cryptanalysis_Views
{
	public partial class CommonCryptanalysisView : Form
	{
		#region Fields

		private int counter = 1;
		private string measureName;

		#endregion

		#region Constructors

		public CommonCryptanalysisView(string text, string formName, ICryptanalysis cryptanalysis, string measureName, CryptanalysisMeasureType cryptanalysisMeasureType, KeyType keyType)
		{
			InitializeComponent();
			this.measureName = measureName;
			FormsUtilities.OpenFormInMainForm(new HistogramView());
			FormsUtilities.OpenFormInMainForm(new HistogramView(text, formName, false));
			MessageBox.Show("Zde je k porovnání histogram anglického textu a histogram analyzovaného textu.");

			FormsUtilities.OpenTextViewWithText(
				cryptanalysisMeasureType == CryptanalysisMeasureType.Fitness ? cryptanalysis.BreakByBrutalForceAndFitness(text) : cryptanalysis.BreakByBrutalForceAndChiSquare(text),
				"Dešifrovaný text z " + formName.InAngleBrackets()
				);

			var informationList = cryptanalysis.CryptanalysisInformation.ToList();
			informationList.Sort();
			if (cryptanalysisMeasureType == CryptanalysisMeasureType.ChiSquare)
				informationList = informationList.OrderBy(i => i.Measure).ToList();
			informationList.ForEach(i => i.Sequence = counter++);

			informationDataGridView.DataSource = informationList.Select(i => new
			{
				Column1 = i.Sequence,
				Column2 = i.DecryptedText,
				Column3 = keyType == KeyType.Number ? i.SingleKey : keyType == KeyType.TwoNumbers ? i.MultipleKey : keyType == KeyType.Sequence ? i.SequenceKey : i.TwoSequenciesKey,
				Column4 = i.Measure,
			}).ToList();
			informationDataGridView.Refresh();
			SetGridProperties();
			FormsUtilities.OpenFormInMainForm(this, true);
		}

		#endregion

		#region Private methods

		private void SetGridProperties()
		{
			informationDataGridView.Columns[0].HeaderText = "Pořadí";
			informationDataGridView.Columns[1].HeaderText = "Část textu";
			informationDataGridView.Columns[2].HeaderText = "Klíč";
			informationDataGridView.Columns[3].HeaderText = measureName;
			informationDataGridView.Columns[0].Width = 50;
			informationDataGridView.Columns[1].Width = 325;
			informationDataGridView.Columns[2].Width = 80;
			informationDataGridView.Columns[3].Width = 110;
		}

		#endregion

		private void InformationDataGridView_Click(object sender, System.EventArgs e) => BringToFront();
	}
}
