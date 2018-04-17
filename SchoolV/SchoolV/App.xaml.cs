using School.Data;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SchoolV
{
	public partial class App : Application
	{
        static GroupController groupController;
        static StudentController studentController;
        static ProfesorController profesorController;

        public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage( new SchoolV.MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}


        public static StudentController StudentController
        {
            get
            {
                if (studentController == null)
                    studentController = new StudentController();

                return studentController;

            }
        }


        public static GroupController GroupController
        {
            get
            {
                if (groupController == null)
                    groupController = new GroupController();

                return groupController;

            }
        }


        public static ProfesorController ProfesorController
        {
            get
            {
                if (profesorController == null)
                    profesorController = new ProfesorController();

                return profesorController;

            }
        }

        
    }
}
