using System;
using System.Globalization;
using Infragistics.Shared;

namespace Infragistics.Windows
{
	// Token: 0x0200026F RID: 623
	public sealed class Resources
	{
		// Token: 0x060018BF RID: 6335 RVA: 0x0005F627 File Offset: 0x0005D827
		private Resources()
		{
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x0005F62F File Offset: 0x0005D82F
		public static global::Infragistics.Shared.ResourceCustomizer Customizer
		{
			get
			{
				return global::ResourceCustomizerLocator.Customizer;
			}
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0005F636 File Offset: 0x0005D836
		public static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0005F63F File Offset: 0x0005D83F
		public static string GetString(string name)
		{
			return global::SR.GetString(name);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x0005F647 File Offset: 0x0005D847
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name)
		{
			return global::SR.GetDynamicResourceString(name, null, null);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x0005F651 File Offset: 0x0005D851
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args)
		{
			return global::SR.GetDynamicResourceString(name, args, null);
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x0005F65B File Offset: 0x0005D85B
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args, global::System.Globalization.CultureInfo culture)
		{
			return global::SR.GetDynamicResourceString(name, args, null);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0005F665 File Offset: 0x0005D865
		public static object GetObject(string name)
		{
			return global::SR.GetObject(name);
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x0005F66D File Offset: 0x0005D86D
		public static global::Infragistics.Shared.DynamicResourceString CloseButtonToolTip
		{
			get
			{
				return global::Infragistics.Windows.Resources.GetDynamicResourceString("CloseButtonToolTip");
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x0005F679 File Offset: 0x0005D879
		public static global::Infragistics.Shared.DynamicResourceString MaximizeButtonToolTip
		{
			get
			{
				return global::Infragistics.Windows.Resources.GetDynamicResourceString("MaximizeButtonToolTip");
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0005F685 File Offset: 0x0005D885
		public static global::Infragistics.Shared.DynamicResourceString MinimizeButtonToolTip
		{
			get
			{
				return global::Infragistics.Windows.Resources.GetDynamicResourceString("MinimizeButtonToolTip");
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x0005F691 File Offset: 0x0005D891
		public static global::Infragistics.Shared.DynamicResourceString RestoreUpButtonToolTip
		{
			get
			{
				return global::Infragistics.Windows.Resources.GetDynamicResourceString("RestoreUpButtonToolTip");
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x0005F69D File Offset: 0x0005D89D
		public static global::Infragistics.Shared.DynamicResourceString RestoreDownButtonToolTip
		{
			get
			{
				return global::Infragistics.Windows.Resources.GetDynamicResourceString("RestoreDownButtonToolTip");
			}
		}
	}
}
