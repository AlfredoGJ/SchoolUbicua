using School.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SchoolV.Droid;


namespace SchoolV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlumnosPage : ContentPage
    {


        public AlumnosPage()
        {
            InitializeComponent();
            this.Title = "Alumnos";

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            List<Student> listaAlumnos = App.StudentController.GetAll();
           
            alumnosList.ItemsSource = listaAlumnos;
            
        }

        async private void GoEdit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditStudent());
        }

        private void Eliminar(object sender, EventArgs e)
        {
            Student s = (Student)(sender as MenuItem).CommandParameter;
            App.StudentController.DeleteStudent(s.id);
        }
    }
}