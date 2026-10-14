using System;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200002C RID: 44
	public abstract class SettingsBaseOverride : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00008D24 File Offset: 0x00006F24
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00008D2C File Offset: 0x00006F2C
		protected internal global::Infragistics.Controls.Menus.NodeLayout NodeLayout { get; set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001BD RID: 445
		protected abstract global::Infragistics.Controls.Menus.SettingsBase SettingsObject { get; }

		// Token: 0x060001BE RID: 446 RVA: 0x00008D35 File Offset: 0x00006F35
		protected internal virtual void InvalidateResolvedProperties(string propertyName)
		{
			if (string.IsNullOrEmpty(propertyName))
			{
				this.OnPropertyChanged(propertyName);
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00008D46 File Offset: 0x00006F46
		protected internal virtual void InvalidateResolvedProperties()
		{
			this.InvalidateResolvedProperties(null);
		}
	}
}
