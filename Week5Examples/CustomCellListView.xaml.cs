using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Week5Examples.Models;
using Xamarin.Forms;

namespace Week5Examples
{
    public partial class CustomCellListView : ContentPage
    {
        public CustomCellListView()
        {
            InitializeComponent();

            PopulateListView();
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            // Do whatever refresh logic you want here

            // Remember you have to set IsRefreshing False
            ListViewWithCustomCells.IsRefreshing = false;

        }

        private void PopulateListView()
        {
            var studentCollection = new ObservableCollection<Student>();

            var student1 = new Student
            {
                Name = "John Smith",
                Age = 45,
                GradeLevel = "Freshman",
                Gpa = 3.09,
                MoreInfoText="Student is a class pet",
            };
            var student2 = new Student
            {
                Name = "Rick Morty",
                Age = 42,
                GradeLevel = "Senior",
                Gpa = 3.54,
                MoreInfoText="Student is the best",
            };
			var student3 = new Student
			{
				Name = "Dustin Jon",
				Age = 34,
				GradeLevel = "Junior",
				Gpa = 3.54,
                MoreInfoText="Student is okay",
			};
			var student4 = new Student
			{
				Name = "Sarah Post",
				Age = 4,
				GradeLevel = "Senior",
				Gpa = 3.54,
                MoreInfoText="Student is the worst",
			};

            studentCollection.Add(student1);
            studentCollection.Add(student2);
			studentCollection.Add(student3);
			studentCollection.Add(student4);

			ListViewWithCustomCells.ItemsSource = studentCollection;
        }

        void Handle_SwitchToggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            var userSwitch = (Switch)sender;
            var grid = (Grid)userSwitch.Parent;

            var random = new Random(DateTime.Now.Millisecond);
            Color randomColor = Color.FromRgb(random.Next(256), random.Next(256), random.Next(256));
            grid.BackgroundColor = randomColor;

        }

        void Handle_ContextMenuMoreButton(object sender, System.EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var student = (Student)menuItem.CommandParameter;
            Navigation.PushAsync(new WebsiteMoreInfoPage(student));
        }
    }
}
