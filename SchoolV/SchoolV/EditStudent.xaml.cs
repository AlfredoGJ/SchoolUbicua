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
	public partial class EditStudent : ContentPage
	{
		public EditStudent ()
		{
			InitializeComponent ();
            Title = "Alumno";

		}

        async public void ConfirmStudent(object sender, EventArgs e)
        {
            if (nombre.Text != null && materno.Text != null && paterno.Text != null)
            {

                App.StudentController.SaveStudent(new Student(nombre.Text, paterno.Text, materno.Text));
                await Navigation.PushAsync(new AlumnosPage());

            }
            else
                DisplayAlert("Atencion","Complete todos los campos para alumno","Aceptar");
        }

    }
}