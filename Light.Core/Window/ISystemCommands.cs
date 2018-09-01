namespace Light.Core.Window
{
	public interface ISystemCommands
	{
		void Close();
		bool MaximizeOrRestore();
		void Minimize();
		void ShowSystemMenu();
	}
}
