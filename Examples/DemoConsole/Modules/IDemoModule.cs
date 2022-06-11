namespace pjank.BossaAPI.DemoConsole.Modules
{
    interface IDemoModule
	{
		char MenuKey { get; }
		string Description { get; }
		void Execute();
	}
}
