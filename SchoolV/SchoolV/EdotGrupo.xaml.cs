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
    
	public partial class EdotGrupo : ContentPage
	{
        private List<long> alumnosids;
        public EdotGrupo ()
		{
			InitializeComponent ();
            alumnosids = new List<long>();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            List<Profesor> listaProfesores = App.ProfesorController.GetAll();

            profesorsList.ItemsSource = listaProfesores;

            List<Student> listaAlumnos = App.StudentController.GetAll();
            alumnosList.ItemsSource = listaAlumnos;

        }

        

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            Switch  toggledSwitch= (sender as Switch);
            object binding = toggledSwitch.BindingContext;
            Student student = (binding as Student);

            if (e.Value == true)
                alumnosids.Add(student.id);
            else
                alumnosids.Remove(alumnosids.IndexOf(student.id));
            
        }

        private void AddGrupo(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nombre.Text) && profesorsList.SelectedItem != null && alumnosids.Count >= 5)
            {
                Group grupo = new Group(nombre.Text, profesorsList.SelectedItem.ToString(), alumnosids);
                App.GroupController.SaveGroup(grupo);
            }
            else
                DisplayAlert("Atencion","Complete todos los campos para el grupo, o agregue por lo menos 5 alumnos","aceptar");
           
         
        }
    }
}