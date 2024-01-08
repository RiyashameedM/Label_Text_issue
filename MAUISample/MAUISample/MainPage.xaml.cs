namespace MAUISample
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			label.Text = "Label text changed";
		}
	}

}
