using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinanceManagement
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SavingsCalculator : ContentPage
	{
		public SavingsCalculator ()
		{
			InitializeComponent ();
           
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await MainProgressBar.ProgressTo(0.7, 1000, Easing.Linear);

        }

        // Calcutation Button 
        public void BtnCalculate_Clicked(object sender, EventArgs e)
        {
            // Variales for calculator
            String name = Name.Text;
            int hoursWorked = int.Parse(HoursWorked.Text);
            float hourlyRate = float.Parse(HourlyRate.Text);
            float ans;

            ans = hoursWorked * hourlyRate;
            // Your Savings
            Label label = sender as Label;
            RateAns.Text = Name.Text + " Your Savings Are: € " + ans.ToString();
            //  If Statement For Savings Staus
            if (ans > 500)
            {
                healthy.Text = " Your Balance is Looking Healthy!";
            }
            else if (ans < 500)
            {
                unhealthy.Text = " Your Balance is UnHealthy!";
            }


        }
	}
}