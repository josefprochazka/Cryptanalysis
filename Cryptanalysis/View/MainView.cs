using System.Windows.Forms;
using System.Linq;

namespace Cryptanalysis.View
{
	public partial class MainView : Form
	{
		#region Fields

		private static int formsCounter = 1;

		#endregion

		#region Constructors

		public MainView()
		{
			InitializeComponent();
			IsMdiContainer = true;
			CreateTextForm(CommonSettings.longEnglishText, "Testovací anglický text");
			CreateTextForm(CommonSettings.startingText, "");
		}

		#endregion

		#region Public methods

		public void CreateTextForm(string text, string textViewName)
		{
			TextView textForm = new TextView();
			textForm.MdiParent = this;
			textForm.mainTextBox.Text = text;
			textForm.Text = (textViewName == "") ? "Textové okno (" + formsCounter++.ToString() + ")" : textViewName;
			textForm.Show();
		}

		public void SetMainFormAsMdiParent(Form form)
		{
			form.MdiParent = this;
		}

		public void CloseAllFormsAndCreateTextForm()
		{
			MdiChildren.ToList().ForEach(ch => ch.Dispose());
			CreateTextForm("", "");
		}

		public void CreateTextFormIfNoneExists(int minPossibleOpenForms)
		{
			if (MdiChildren.Length < minPossibleOpenForms)
				CreateTextForm("", "");
		}

		public void CloseMainForm() => Close();

		#endregion

		#region Private methods

		private void MainView_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Chcete zavřít aplikaci bez uložení textových oken?", "Kryptoanalýza", MessageBoxButtons.YesNo) == DialogResult.No)
				e.Cancel = true;
		}
		
		#endregion
	}
}
