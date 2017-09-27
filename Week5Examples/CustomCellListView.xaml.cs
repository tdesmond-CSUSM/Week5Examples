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

        private void PopulateListView()
        {
            var studentCollection = new ObservableCollection<Student>();

            var student1 = new Student
            {
                Name = "John Smith",
                Age = 45,
                GradeLevel = "Freshman",
                Gpa = 3.09,
            };
            var student2 = new Student
            {
                Name = "Rick Morty",
                Age = 4,
                GradeLevel = "Senior",
                Gpa = 3.54,
            };

            studentCollection.Add(student1);
            studentCollection.Add(student2);

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
    }
}
