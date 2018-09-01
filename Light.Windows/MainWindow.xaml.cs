//Source: https://github.com/angelsix/fasetto-word/blob/develop/Source/Fasetto.Word/Window/WindowResizer.cs

using Light.Core.ViewModels;
using Light.Core.Window;
using Light.Windows.Window;
using System;
using System.Windows;

namespace Light.Windows
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : System.Windows.Window, ISystemCommands
	{
		public MainWindow()
		{
			InitializeComponent();

			// To correct the size and position of the window when it is maximized
			var resizer = new WindowResizer( this );
		}

		#region Implementation of ISystemCommands

		/// <summary>
		/// Maximizes the window if it isn't maximized,
		/// Restores the window if it is maximized
		/// </summary>
		/// <returns>True if the window was maximized, otherwise False</returns>
		public bool MaximizeOrRestore()
		{
			WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
			return WindowState == WindowState.Maximized;
		}

		/// <summary>
		/// Minimizes the window
		/// </summary>
		public void Minimize() => WindowState = WindowState.Minimized;

		/// <summary>
		/// Displays the system menu
		/// </summary>
		public void ShowSystemMenu()
		{
			try
			{
				if ( DataContext is WindowViewModel viewModel )
					SystemCommands.ShowSystemMenu( this, new Point( Left, Top + viewModel.TitleHeight ) );
			}
			catch ( Exception e )
			{
				// TODO: Log the exception
				throw;
			}
		}

		#endregion
	}
}
