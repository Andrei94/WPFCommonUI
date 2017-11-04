using System;
using System.Windows.Input;

namespace WPFCommonUI
{
	public class RelayCommand : ICommand
	{
		public event EventHandler CanExecuteChanged
		{
			add => CommandManager.RequerySuggested += value;
			remove => CommandManager.RequerySuggested -= value;
		}
		private readonly Action<object> methodToExecute;
		private readonly Func<bool> canExecuteEvaluator;

		public RelayCommand(Action<object> methodToExecute, Func<bool> canExecuteEvaluator = null)
		{
			this.methodToExecute = methodToExecute;
			this.canExecuteEvaluator = canExecuteEvaluator;
		}

		public bool CanExecute(object parameter)
		{
			if(canExecuteEvaluator == null)
				return true;
			var result = canExecuteEvaluator.Invoke();
			return result;
		}

		public void Execute(object parameter)
		{
			methodToExecute(parameter);
		}
	}
}
