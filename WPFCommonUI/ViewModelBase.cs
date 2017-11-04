using System.ComponentModel;

namespace WPFCommonUI
{
	public class ViewModelBase<ViewType> : INotifyPropertyChanged
		where ViewType : class, View
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public ViewType View { get; }

		public ViewModelBase(ViewType view)
		{
			View = view;
			View.DataContext = this;
		}

		public void RaisePropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}