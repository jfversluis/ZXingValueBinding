using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace ZXingValueBinding
{
	public partial class MainPage : ContentPage, INotifyPropertyChanged
	{
		private Random _random = new Random();
		private string _barcodeValue = "-1";

		public string BarcodeValue
		{
			get { return _barcodeValue; }
			set
			{

				_barcodeValue = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BarcodeValue)));
			}
		}

		public new event PropertyChangedEventHandler PropertyChanged;

		public MainPage()
		{
			InitializeComponent();

			BindingContext = this;
		}

		public void Handle_Clicked(object sender, EventArgs e)
		{
			BarcodeValue = _random.Next(0, 42).ToString();
		}
	}
}