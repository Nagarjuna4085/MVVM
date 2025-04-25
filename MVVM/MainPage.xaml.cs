namespace MVVM
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
       
        void ConcatAndUpdateName()
        {
            LabelFullName.Text = $"{FirstEntry.Text} {LastEntry.Text}";
        }

        private void FirstEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            ConcatAndUpdateName();
        }

        private void LastEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            ConcatAndUpdateName();

        }

   

        private void ClickButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Wishes","GoodMorning","Cancel");
            //ClickButton.IsEnabled = false;
            Console.WriteLine("from button clicked evemrr"); 
            //ClickButton.IsEnabled = true;

        }
    }

}
