using System;
using System.Windows.Forms;

namespace Cryptanalysis.View.Analysis_Views
{
	public partial class InformationView : Form
	{
		#region Public methods

		public InformationView(string description, string valueName, string value, string formName)
		{
			InitializeComponent();
			descriptionLabel.Text = description;
			valueNameLabel.Text = valueName + " daného textu je:";
			valueLabel.Text = value;
			Text = valueName + formName.InAngleBrackets();
			ShowDialog();
		}

		#endregion

		#region Events

		private void okButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion
	}
}
