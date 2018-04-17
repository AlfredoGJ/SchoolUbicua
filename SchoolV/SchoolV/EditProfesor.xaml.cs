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
	public partial class EditProfesor : ContentPage
	{
		public EditProfesor ()
		{
			InitializeComponent ();
            Title = "Profesor";

		}

        async public void UpdateProfesor(object sender, EventArgs e)
        {
            if (nombre.Text != null && paterno.Text != null && materno.Text != null && titulo.Text != null)
            {
                App.ProfesorController.SaveProfesor(new Profesor(nombre.Text, paterno.Text, materno.Text, titulo.Text));
                await Navigation.PushAsync(new ProfesorsPage());
            }
            else
                DisplayAlert("Atencion","Complete todos los campos para el profesor","Aceptar");
        }
    }
}