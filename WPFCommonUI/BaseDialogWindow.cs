using System.Windows;

namespace WPFCommonUI
{
	public class BaseDialogWindow : Window
	{
		protected BaseDialogWindow()
		{
			if(Application.Current.MainWindow.IsVisible)
			    Owner = Application.Current.MainWindow;
		    ShowInTaskbar = false;
			ResizeMode = ResizeMode.NoResize;
			WindowStartupLocation = WindowStartupLocation.CenterOwner;
		}
	}
}
