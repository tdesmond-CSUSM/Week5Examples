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
            };
            var student2 = new Student
            {
                Name = "Rick Morty",
                Age = 4,
                GradeLevel = "Senior"
            };

            studentCollection.Add(student1);
            studentCollection.Add(student2);

            ListViewWithCustomCells.ItemsSource = studentCollection;
        }

    }
}
