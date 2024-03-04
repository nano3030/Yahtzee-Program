namespace Yahtzee_Program;

public partial class MainPage : ContentPage
{
	Random numberRandom = new Random();
	int intNum1, intNum2, intNum3, intNum4, intNum5, intCount, intTotal;
	String strCount;
	String strWinner;

	public MainPage()
	{
		InitializeComponent();
	}

	private void btnReset_Clicked(object sender, EventArgs e)
	{
		strWinner = "";
		LblWinner.Text = "Lucky Winners";
		intTotal = 0;
	}

	private void btnPlay_Clicked(object sender, EventArgs e)
	{
		intCount = 1;
		strCount = "";

		while (intCount <= 10000)
		{
			intNum1 = numberRandom.Next(6) + 1;
            intNum2 = numberRandom.Next(6) + 1;
            intNum3 = numberRandom.Next(6) + 1;
            intNum4 = numberRandom.Next(6) + 1;
            intNum5 = numberRandom.Next(6) + 1;

			if (intNum1 == intNum2 && intNum1 == intNum3 && intNum1 == intNum4 && intNum1 == intNum5)
			{
				strCount = intCount.ToString();
				strWinner += "The roll was " + strCount + " with dice " + intNum1.ToString() + "\n";
				intTotal += 1;
			}
			intCount += 1;

        }
		strWinner += "Finished! Total wins: " + intTotal.ToString();
		LblWinner.Text = strWinner;

	}


}

