using System.ComponentModel;

namespace SOCMapGenerator.ViewModels
{
	public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
	{
		string _submitText = "Submit";
		public new event PropertyChangedEventHandler PropertyChanged;

		public string SubmitButton
		{
			get
			{
				return _submitText;
			}
			set
			{
				_submitText = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SubmitButton)));
			}
		}

		public void SubmitClicked() => SubmitButton = "Test Run";
	}
}