using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BossaAPI_Core.DemoConsole.Modules
{
	interface IDemoModule
	{
		char MenuKey { get; }
		string Description { get; }
		void Execute();
	}
}
