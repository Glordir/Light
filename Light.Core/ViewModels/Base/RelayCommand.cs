using System;
using System.Windows.Input;

namespace Light.Core.ViewModels.Base
{
	public class RelayCommand : ICommand
	{
		#region Private Properties

		/// <summary>
		/// The action to run
		/// </summary>
		private Action _action;

		#endregion


		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="action"></param>
		public RelayCommand( Action action )
		{
			_action = action;
		}

		#endregion


		#region Command Methods

		/// <summary>
		/// A relay command can always execute
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns></returns>
		public bool CanExecute( object parameter ) => true;

		public void Execute( object parameter ) => _action();

		#endregion


		#region Public Events

		/// <summary>
		/// The event that is fired when the <see cref="CanExecute(object)"/> value has changed
		/// </summary>
		public event EventHandler CanExecuteChanged = ( sender, e ) => { };

		#endregion
	}
}
