namespace PhotoGallery;

public partial class Practice1 : ContentPage
{
	Button up;
	Button down;
	Entry entry;
	Label label;
	public Practice1()
	{
		InitializeComponent();
		up = new Button() 
		{
			Text = "Read Only",
		};
		down = new Button()
		{
			Text="Copy",
		};
		entry = new Entry()
		{
			Placeholder = "Enter a number",
            Keyboard = Keyboard.Numeric,
        };

		label = new Label()
		{
			Text=""
		};

        up.Clicked += Up_Clicked;
        down.Clicked += Copy;

		layout.Children.Add(up);
		layout.Children.Add(down);
		layout.Children.Add(entry);
		layout.Children.Add(label);
	}
    private void Up_Clicked(object sender, EventArgs e)
    {
        if (up.Text == "Read Only")
        {
            up.Text = "Write";
            entry.IsEnabled = false;
        }
        else
        {
            up.Text = "Read Only";
            entry.IsEnabled = true;
        }
    }
    private void Copy(object sender, EventArgs e)
    {
        label.Text = entry.Text;
    }
}