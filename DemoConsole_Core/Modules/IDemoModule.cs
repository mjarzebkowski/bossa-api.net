namespace BossaAPI_Core.DemoConsole.Modules
{
    interface IDemoModule
	{
		char MenuKey { get; }
		string Description { get; }
		void Execute();
	}
}
