
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SchoolV
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            Title = "My Little School";
            

        }

        
        async public void StudentsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AlumnosPage());
        }

        async public void ProfesorsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfesorsPage());
        }

        async public void GroupsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GruposPage());
        }


    }


}
