using System;
using System.Collections.Generic;
using Week5Examples.Models;
using Xamarin.Forms;

namespace Week5Examples
{
    public partial class SimpleStackLayoutWithBinding : ContentPage
    {
        public SimpleStackLayoutWithBinding()
        {
            InitializeComponent();

            var person = new Person()
            {
                FirstName = "Jeff",
                DateOfBirth = new DateTime(1991, 6, 25),
            };

            BindingContext = person;
        }
    }
}
