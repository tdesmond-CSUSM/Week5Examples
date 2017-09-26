using Xamarin.Forms;

namespace Week5Examples
{
    public partial class Week5ExamplesPage : ContentPage
    {
        public Week5ExamplesPage()
        {
            InitializeComponent();
        }

        void Handle_NavigateToBackwardsBinding(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BackwardsBinding());
        }

        void Handle_NavigateToSimpleStackLayout(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SimpleStackLayoutWithBinding());
        }

        void Handle_NavigateToViewToViewBinding(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ViewToViewBinding());
        }

        void Handle_NavigateToCustomCellListView(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CustomCellListView());
        }
    }
}
