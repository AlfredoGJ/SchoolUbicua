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
	public partial class GruposPage : ContentPage
	{
		public GruposPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            List<Group> listaAlumnos = App.GroupController.GetAll();

            groupsList.ItemsSource = listaAlumnos;

        }

        async private void GoEdit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EdotGrupo());
        }
    }

    
}