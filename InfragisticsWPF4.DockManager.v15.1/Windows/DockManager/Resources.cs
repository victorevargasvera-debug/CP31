using System;
using System.Globalization;
using Infragistics.Shared;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000093 RID: 147
	public sealed class Resources
	{
		// Token: 0x06000578 RID: 1400 RVA: 0x0001D6AD File Offset: 0x0001B8AD
		private Resources()
		{
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0001D6B5 File Offset: 0x0001B8B5
		public static global::Infragistics.Shared.ResourceCustomizer Customizer
		{
			get
			{
				return global::ResourceCustomizerLocator.Customizer;
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0001D6BC File Offset: 0x0001B8BC
		public static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0001D6C5 File Offset: 0x0001B8C5
		public static string GetString(string name)
		{
			return global::SR.GetString(name);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0001D6CD File Offset: 0x0001B8CD
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name)
		{
			return global::SR.GetDynamicResourceString(name, null, null);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0001D6D7 File Offset: 0x0001B8D7
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args)
		{
			return global::SR.GetDynamicResourceString(name, args, null);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0001D6E1 File Offset: 0x0001B8E1
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args, global::System.Globalization.CultureInfo culture)
		{
			return global::SR.GetDynamicResourceString(name, args, culture);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0001D6EB File Offset: 0x0001B8EB
		public static object GetObject(string name)
		{
			return global::SR.GetObject(name);
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x0001D6F3 File Offset: 0x0001B8F3
		public static string PaneHeaderContentValidationError
		{
			get
			{
				return global::Infragistics.Windows.DockManager.Resources.GetString("PaneHeaderContentValidationError");
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0001D6FF File Offset: 0x0001B8FF
		[global::System.Obsolete("This property is deprecated. Use ResourcesDockManager.CloseButtonToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString CloseButtonToolTip
		{
			get
			{
				return global::Infragistics.Windows.DockManager.Resources.GetDynamicResourceString("CloseButtonToolTip");
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x0001D70B File Offset: 0x0001B90B
		[global::System.Obsolete("This property is deprecated. Use ResourcesDockManager.DocumentFilesMenuToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString DocumentFilesMenuToolTip
		{
			get
			{
				return global::Infragistics.Windows.DockManager.Resources.GetDynamicResourceString("DocumentFilesMenuToolTip");
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0001D717 File Offset: 0x0001B917
		[global::System.Obsolete("This property is deprecated. Use ResourcesDockManager.DocumentShowNavigatorToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString DocumentShowNavigatorToolTip
		{
			get
			{
				return global::Infragistics.Windows.DockManager.Resources.GetDynamicResourceString("DocumentShowNavigatorToolTip");
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0001D723 File Offset: 0x0001B923
		[global::System.Obsolete("This property is deprecated. Use ResourcesDockManager.PositionMenuToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString PositionMenuToolTip
		{
			get
			{
				return global::Infragistics.Windows.DockManager.Resources.GetDynamicResourceString("PositionMenuToolTip");
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0001D72F File Offset: 0x0001B92F
		[global::System.Obsolete("This property is deprecated. Use ResourcesDockManager.PinButtonToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString PinButtonToolTip
		{
			get
			{
				return global::Infragistics.Windows.DockManager.Resources.GetDynamicResourceString("PinButtonToolTip");
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0001D73B File Offset: 0x0001B93B
		[global::System.Obsolete("This property is deprecated. Use ResourcesDockManager.PaneNavigatorActiveToolWindowsLabel instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString PaneNavigatorActiveToolWindowsLabel
		{
			get
			{
				return global::Infragistics.Windows.DockManager.Resources.GetDynamicResourceString("PaneNavigatorActiveToolWindowsLabel");
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0001D747 File Offset: 0x0001B947
		[global::System.Obsolete("This property is deprecated. Use ResourcesDockManager.PaneNavigatorActiveFilesLabel instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString PaneNavigatorActiveFilesLabel
		{
			get
			{
				return global::Infragistics.Windows.DockManager.Resources.GetDynamicResourceString("PaneNavigatorActiveFilesLabel");
			}
		}
	}
}
