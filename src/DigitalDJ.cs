namespace Ergasia3
{
	public partial class DigitalDJForm : Form
	{
		public DigitalDJForm()
		{
			InitializeComponent();
		}

		private void colorButton_Click(object sender, EventArgs e)
		{
			DialogResult dr = colorDialog1.ShowDialog();
			if (dr == DialogResult.OK)
			{
				Application.OpenForms[0].BackColor = colorDialog1.Color;
			}
		}
	}
}
