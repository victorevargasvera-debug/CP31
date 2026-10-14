using System;
using System.ComponentModel;

namespace DevComponents.WpfDock
{
	// Token: 0x0200001B RID: 27
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.ComponentModel.ToolboxItem(false)]
	public class DockSiteDesignExtension
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00024510 File Offset: 0x00022710
		public DockSiteDesignExtension(global::DevComponents.WpfDock.DockSite dockSite)
		{
			this.a = dockSite;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0002452C File Offset: 0x0002272C
		public void StartWindowDrag(global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup, bool dragSelectedTabOnly, global::DevComponents.WpfDock.eEventActionSource actionSource, global::DevComponents.WpfDock.IDockOperations dockOperations)
		{
			short num = (short)47905548;
			short num2 = num;
			num = (short)1002502924;
			switch (num2 == num)
			{
			}
			num = (short)1216020480;
			if (num != 0)
			{
			}
			num = (short)1098055681;
			if (num != 0)
			{
			}
			num = (short)1800208384;
			short num3 = num;
			this.a.DockOperations = dockOperations;
			this.a.a(dockWindowGroup, dragSelectedTabOnly, actionSource);
			this.a.AfterDocked += this.a;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00024608 File Offset: 0x00022808
		private void a(object A_0, global::DevComponents.WpfDock.DockRoutedEventArgs A_1)
		{
			short num = (short)1860559041;
			short num2 = num;
			num = (short)1659297985;
			switch (num2 == num)
			{
			}
			num = (short)1886846977;
			if (num != 0)
			{
			}
			num = (short)1846607872;
			if (num != 0)
			{
			}
			num = (short)1243348992;
			short num3 = num;
			this.a.DockOperations = null;
			this.a.AfterDocked -= this.a;
			this.a = null;
		}

		// Token: 0x040000BD RID: 189
		private global::DevComponents.WpfDock.DockSite a;
	}
}
