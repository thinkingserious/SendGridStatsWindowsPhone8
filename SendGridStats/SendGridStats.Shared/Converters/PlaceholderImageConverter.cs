using System;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace SendGridStats.Converters
{
	public class PlaceholderImageConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			var image = new BitmapImage();
			switch (App.Random.Next(0, 3))
			{
				case 0:
					image.UriSource = new Uri("ms-appx:///Assets/DarkGray.png", UriKind.Absolute);
					break;
				case 1:
					image.UriSource = new Uri("ms-appx:///Assets/MediumGray.png", UriKind.Absolute);
					break;
				case 2:
					image.UriSource = new Uri("ms-appx:///Assets/LightGray.png", UriKind.Absolute);
					break;
			}

			return image;
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}
