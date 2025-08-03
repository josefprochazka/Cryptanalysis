using System.Windows.Forms;

namespace Cryptanalysis.View.Cryptanalysis_Views
{
	public partial class SetKeySpaceView : Form
	{
		#region Constructors

		public SetKeySpaceView()
		{
			CommonConstructorSetting(20000);
			label1.Text = "Zvolte počet iterací určující kolikrát se bude vytvářet nový klíč obsahující náhodnou permutaci abecedy. Pro každou permutaci se provede hledání nejvhodnějšího sousedního klíče. Zvolit lze maximálně 20000 iterací.";
			ShowDialog();
		}


		public SetKeySpaceView(int keySpace, int maximumRange)
		{
			CommonConstructorSetting(maximumRange);
			label1.Text = "Zvolte jak veliký prostor klíčů se má analyzovat. Od velikosti klíčů, které obsahují " + keySpace + " znaků a více, je potřeba počítat s délkou trvání kryptoanalýzy v řádu minut. Zvolit lze maximálně " + maximumRange + " znaků.";
			ShowDialog();
		}

		#endregion

		#region Private methods

		private void CommonConstructorSetting(int maximumRange)
		{
			InitializeComponent();
			numericUpDown.Minimum = 2;
			numericUpDown.Maximum = maximumRange;
			Text = "Volba počtu iterací";
		}

		#endregion
	}
}
