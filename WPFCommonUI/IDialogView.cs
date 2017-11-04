using System.Windows;

namespace WPFCommonUI
{
	public interface IDialogView : View
	{
		bool? ShowDialog();
		bool? DialogResult { get; set; }
		Window Owner { get; set; }
	}
}
