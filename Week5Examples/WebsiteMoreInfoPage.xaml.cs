using System;
using System.Collections.Generic;
using Week5Examples.Models;
using Xamarin.Forms;

namespace Week5Examples
{
    public partial class WebsiteMoreInfoPage : ContentPage
    {
        public WebsiteMoreInfoPage()
        {
            InitializeComponent();
        }

		public WebsiteMoreInfoPage(Student student)
		{
			InitializeComponent();
            BindingContext = student;
		}
    }
}
