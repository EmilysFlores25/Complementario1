namespace _4numeroseinvertidos2429841;

public partial class numerosinversos : ContentPage
{
	public numerosinversos()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty(entry1.Text)&& !string.IsNullOrEmpty(entry2.Text) && !string.IsNullOrEmpty(entry3.Text) && !string.IsNullOrEmpty(entry4.Text))
		{
			string num1, num2, num3, num4, invertir;
			num1 = Convert.ToString(entry1.Text);
			num2 = Convert.ToString(entry2.Text);
			num3 = Convert.ToString(entry3.Text);
			num4 = Convert.ToString(entry4.Text);

			invertir = num4 + num3 + num2 + num1;

			entryAlreves.Text = invertir.ToString();
		}

		else
		{
			DisplayAlert("Error"," introduce todos los numeros reuqeridos", "Ok");
		}
    }
}