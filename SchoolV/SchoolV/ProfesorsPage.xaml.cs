using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SchoolV
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfesorsPage : ContentPage
	{
		public ProfesorsPage ()
		{
			InitializeComponent ();
            Title = "Profesor";
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            List<Profesor> listaProfes = App.ProfesorController.GetAll();

            profesorsList.ItemsSource = listaProfes;
        }


        async public void GoEdit( object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditProfesor());
        }

    }
}