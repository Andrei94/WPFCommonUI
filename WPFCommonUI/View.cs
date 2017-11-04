namespace WPFCommonUI
{
	public interface View
	{
		object DataContext { get; set; }
		void Close();
	}
}
