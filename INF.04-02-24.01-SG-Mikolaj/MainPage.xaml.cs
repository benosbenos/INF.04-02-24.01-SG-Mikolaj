namespace INF._04_02_24._01_SG_Mikolaj
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SliderValue(object sender, ValueChangedEventArgs e)
        {
            WartoscSlider.Text = ((int)theSlider.Value).ToString();
        }

        private void Gatunek_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem.ToString() == "pies") theSlider.Maximum = 18;
            if (e.SelectedItem.ToString() == "kot") theSlider.Maximum = 20;
            if (e.SelectedItem.ToString() == "swinka") theSlider.Maximum = 9;
        }

        private void OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Zapisana wizyta", $"{imie.Text}, {gatunek.SelectedItem}, {Convert.ToInt16(theSlider.Value)}, {cel.Text}, {czas.Time}", "OK");
        }
    }

}
