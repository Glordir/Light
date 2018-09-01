using System;
using System.Windows.Input;

namespace Light.Core.ViewModels.Base
{
	/// <inheritdoc />
	/// <summary>
	/// A basic command that runs a parameterized Action
	/// </summary>
	public class RelayParameterizedCommand : ICommand
	{
		#region Private Members

		/// <summary>
		/// The action to run
		/// </summary>
		private readonly Action<object> _action;

		#endregion


		#region Public Events

		/// <inheritdoc />
		/// <summary>
		/// The event thats fired when the <see cref="CanExecute(object)" /> value has changed
		/// </summary>
		public event EventHandler CanExecuteChanged;

		#endregion


		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public RelayParameterizedCommand( Action<object> action )
		{
			_action = action;
		}

		#endregion


		#region Command Methods

		/// <inheritdoc />
		/// <summary>
		/// A relay command can always execute
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns></returns>
		public bool CanExecute( object parameter ) => true;

		/// <inheritdoc />
		/// <summary>
		/// Executes the commands Action
		/// </summary>
		/// <param name="parameter"></param>
		public void Execute( object parameter ) => _action( parameter );

		#endregion
	}
}

