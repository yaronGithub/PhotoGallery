namespace PhotoGallery;

public partial class Practice2 : ContentPage
{
	BoxView boxView;
	Slider slider;
	public Practice2()
	{
		InitializeComponent();

		boxView = new BoxView()
		{
			Color = Colors.Blue,
            CornerRadius = 10,
            WidthRequest = 160,
            HeightRequest = 160,
        };
		slider = new Slider() 
		{ 
			Maximum = 255,
		};
        slider.ValueChanged += Slider_ValueChanged;
        slider.DragCompleted += Slider_DragCompleted;
		layout.Children.Add(slider);
		layout.Children.Add(boxView);
	}

    private void Slider_DragCompleted(object sender, EventArgs e)
    {
		if (sender is Slider slider)
		{
			double currentValue = slider.Value;
			double reversedValue = 1-currentValue;
			slider.Value = reversedValue;
		}
    }

    private async void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		double value = e.NewValue;
		boxView.Color = Color.FromRgb(1-value, Math.Abs(0.5-value)*2, value);
    }
}