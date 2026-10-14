using System;
using System.Drawing;

namespace Loupe.Extensibility.Client
{
	// Token: 0x020000A1 RID: 161
	internal interface IUserInterfaceContext
	{
		// Token: 0x060006D3 RID: 1747
		void RegisterCommand(string name, bool isUserInteractive, string label, string toolTip);

		// Token: 0x060006D4 RID: 1748
		void RegisterCommand(string name, bool isUserInteractive, string label, string toolTip, string group, global::System.Drawing.Icon icon);

		// Token: 0x060006D5 RID: 1749
		void UpdateCommand(string name, bool isEnabled);

		// Token: 0x060006D6 RID: 1750
		void UpdateCommand(string name, string label, string toolTip, bool isEnabled);
	}
}
