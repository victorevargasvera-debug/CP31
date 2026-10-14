using System;

namespace DevComponents.WpfDock
{
	// Token: 0x0200001D RID: 29
	public interface IDockSiteLayoutSerializer
	{
		// Token: 0x0600013B RID: 315
		string SaveLayout(global::DevComponents.WpfDock.DockSite ds);

		// Token: 0x0600013C RID: 316
		void LoadLayout(global::DevComponents.WpfDock.DockSite ds, string layout);
	}
}
