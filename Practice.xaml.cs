namespace PhotoGallery;

public partial class Practice : ContentPage
{
	public Practice()
	{
		InitializeComponent();
    }
    private void UpBtn_Clicked(object sender, EventArgs e)
    {
        if (upBtn.Text == "Read Only")
        {
            upBtn.Text = "Write";
            myEntry.IsEnabled = false;
        }else
        {
            upBtn.Text = "Read Only";
            myEntry.IsEnabled = true;
        }
    }
    private void Copy(object sender, EventArgs e)
    {
        myLabel.Text = myEntry.Text;
    }
}