using Light.Core.ViewModels.Base;
using Light.Core.Window;

namespace Light.Core.ViewModels
{
	public class WindowViewModel : BaseViewModel
	{
		#region Public Properties

		/// <summary>
		/// The padding around the content of the window
		/// </summary>
		public double InnerContentPadding { get; set; } = 6;

		/// <summary>
		/// The size of the resize border around the window
		/// </summary>
		public double ResizeBorder { get; set; } = 6;

		/// <summary>
		/// The height of the title / caption bar of the window
		/// </summary>
		public double TitleHeight { get; set; } = 32;

		/// <summary>
		/// The height of the title / caption bar of the window for use by WindowChrome
		/// It takes into account the resize border
		/// </summary>
		public double WindowChromeTitleHeight => TitleHeight - ResizeBorder;

		/// <summary>
		/// The smallest width the window can resize to
		/// </summary>
		public double WindowMinimumWidth { get; set; } = 400;

		/// <summary>
		/// The smallest height the window can resize to
		/// </summary>
		public double WindowMinimumHeight { get; set; } = 400;

		#endregion


		#region Commands

		/// <summary>
		/// The command to minimize the window
		/// </summary>
		public RelayParameterizedCommand MinimizeCommand { get; set; }

		/// <summary>
		/// The command to maximize the window
		/// </summary>
		public RelayParameterizedCommand MaximizeOrRestoreCommand { get; set; }

		/// <summary>
		/// The command to close the window
		/// </summary>
		public RelayParameterizedCommand CloseCommand { get; set; }

		/// <summary>
		/// The command to show the system menu the window
		/// </summary>
		public RelayParameterizedCommand ShowSystemMenuCommand { get; set; }


		#endregion


		#region Constructor

		public WindowViewModel()
		{
			CloseCommand = new RelayParameterizedCommand( ( window ) => { ( (ISystemCommands) window ).Close(); } );
			MinimizeCommand = new RelayParameterizedCommand( ( window ) => { ( (ISystemCommands) window ).Minimize(); } );
			MaximizeOrRestoreCommand = new RelayParameterizedCommand( ( window ) => { ( (ISystemCommands) window ).MaximizeOrRestore(); } );
			ShowSystemMenuCommand = new RelayParameterizedCommand( ( window ) => { ( (ISystemCommands) window ).ShowSystemMenu(); } );
		}

		#endregion
	}
}
