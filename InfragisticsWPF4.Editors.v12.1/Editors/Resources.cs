using System;
using System.Globalization;
using Infragistics.Shared;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000BB RID: 187
	public sealed class Resources
	{
		// Token: 0x06000A01 RID: 2561 RVA: 0x0002D727 File Offset: 0x0002B927
		private Resources()
		{
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x0002D72F File Offset: 0x0002B92F
		public static global::Infragistics.Shared.ResourceCustomizer Customizer
		{
			get
			{
				return global::ResourceCustomizerLocator.Customizer;
			}
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0002D736 File Offset: 0x0002B936
		public static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0002D73F File Offset: 0x0002B93F
		public static string GetString(string name)
		{
			return global::SR.GetString(name);
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0002D747 File Offset: 0x0002B947
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name)
		{
			return global::SR.GetDynamicResourceString(name, null, null);
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0002D751 File Offset: 0x0002B951
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args)
		{
			return global::SR.GetDynamicResourceString(name, args, null);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0002D75B File Offset: 0x0002B95B
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args, global::System.Globalization.CultureInfo culture)
		{
			return global::SR.GetDynamicResourceString(name, args, null);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0002D765 File Offset: 0x0002B965
		public static object GetObject(string name)
		{
			return global::SR.GetObject(name);
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0002D76D File Offset: 0x0002B96D
		public static global::Infragistics.Shared.DynamicResourceString TodayButtonCaption
		{
			get
			{
				return global::Infragistics.Windows.Editors.Resources.GetDynamicResourceString("TodayButtonCaption");
			}
		}
	}
}
