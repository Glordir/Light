using PropertyChanged;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Light.Core.ViewModels.Base
{
	[AddINotifyPropertyChangedInterface]
	public class BaseViewModel : INotifyPropertyChanged
	{
		/// <summary>
		/// The event that is fired when the child property changes its value
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Call this to fire a <see cref="PropertyChanged"/> event
		/// </summary>
		/// <param name="propertyName"></param>
		protected virtual void OnPropertyChanged( [CallerMemberName] string propertyName = null ) => PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
	}
}
