namespace PhotoGallery
{
    public partial class MainPage : ContentPage
    {
        int current = 1;
        List<string> imgs = new List<string>(3) { "piano1.jpg", "pianoo2.png", "piano3.png" };
        public MainPage()
        {
            InitializeComponent();
        }

        private void UpPic(object sender, EventArgs e)
        {
            current++;
            if (current >= imgs.Count-1)
            {
                UPbtn.IsEnabled = false;
            }
            if (current < imgs.Count)
            {
                pImg.Source = imgs[current];
                DOWNbtn.IsEnabled = true;
            }
        }
        private void DownPic(object sender, EventArgs e)
        {
            current--;
            if (current <= 0)
            {
                DOWNbtn.IsEnabled = false;
            }
            if (current >= 0)
            {
                pImg.Source = imgs[current];
                UPbtn.IsEnabled = true;
            }
        }
    }
}
