using System;
using System.Globalization;
using Infragistics.Shared;

namespace Infragistics.Windows
{
	// Token: 0x020002AA RID: 682
	public sealed class Resources
	{
		// Token: 0x06001ADB RID: 6875 RVA: 0x00066383 File Offset: 0x00064583
		private Resources()
		{
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x0006638B File Offset: 0x0006458B
		public static global::Infragistics.Shared.ResourceCustomizer Customizer
		{
			get
			{
				return global::ResourceCustomizerLocator.Customizer;
			}
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00066392 File Offset: 0x00064592
		public static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x0006639B File Offset: 0x0006459B
		public static string GetString(string name)
		{
			return global::SR.GetString(name);
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x000663A3 File Offset: 0x000645A3
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name)
		{
			return global::SR.GetDynamicResourceString(name, null, null);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x000663AD File Offset: 0x000645AD
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args)
		{
			return global::SR.GetDynamicResourceString(name, args, null);
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x000663B7 File Offset: 0x000645B7
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args, global::System.Globalization.CultureInfo culture)
		{
			return global::SR.GetDynamicResourceString(name, args, culture);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x000663C1 File Offset: 0x000645C1
		public static object GetObject(string name)
		{
			return global::SR.GetObject(name);
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x000663C9 File Offset: 0x000645C9
		[global::System.Obsolete("This property is deprecated. Use ResourcesWindows.CloseButtonToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString CloseButtonToolTip
		{
			get
			{
				return global::Infragistics.Windows.Resources.GetDynamicResourceString("CloseButtonToolTip");
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x000663D5 File Offset: 0x000645D5
		[global::System.Obsolete("This property is deprecated. Use ResourcesWindows.MaximizeButtonToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString MaximizeButtonToolTip
		{
			get
			{
				return global::Infragistics.Windows.Resources.GetDynamicResourceString("MaximizeButtonToolTip");
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x000663E1 File Offset: 0x000645E1
		[global::System.Obsolete("This property is deprecated. Use ResourcesWindows.MinimizeButtonToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString MinimizeButtonToolTip
		{
			get
			{
				return global::Infragistics.Windows.Resources.GetDynamicResourceString("MinimizeButtonToolTip");
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x000663ED File Offset: 0x000645ED
		[global::System.Obsolete("This property is deprecated. Use ResourcesWindows.RestoreUpButtonToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString RestoreUpButtonToolTip
		{
			get
			{
				return global::Infragistics.Windows.Resources.GetDynamicResourceString("RestoreUpButtonToolTip");
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x000663F9 File Offset: 0x000645F9
		[global::System.Obsolete("This property is deprecated. Use ResourcesWindows.RestoreDownButtonToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString RestoreDownButtonToolTip
		{
			get
			{
				return global::Infragistics.Windows.Resources.GetDynamicResourceString("RestoreDownButtonToolTip");
			}
		}
	}
}
