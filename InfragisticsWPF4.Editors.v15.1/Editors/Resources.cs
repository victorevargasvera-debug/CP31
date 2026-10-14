using System;
using System.Globalization;
using Infragistics.Shared;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000C2 RID: 194
	public sealed class Resources
	{
		// Token: 0x06000A73 RID: 2675 RVA: 0x0002F789 File Offset: 0x0002D989
		private Resources()
		{
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0002F791 File Offset: 0x0002D991
		public static global::Infragistics.Shared.ResourceCustomizer Customizer
		{
			get
			{
				return global::ResourceCustomizerLocator.Customizer;
			}
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0002F798 File Offset: 0x0002D998
		public static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0002F7A1 File Offset: 0x0002D9A1
		public static string GetString(string name)
		{
			return global::SR.GetString(name);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0002F7A9 File Offset: 0x0002D9A9
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name)
		{
			return global::SR.GetDynamicResourceString(name, null, null);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0002F7B3 File Offset: 0x0002D9B3
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args)
		{
			return global::SR.GetDynamicResourceString(name, args, null);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0002F7BD File Offset: 0x0002D9BD
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args, global::System.Globalization.CultureInfo culture)
		{
			return global::SR.GetDynamicResourceString(name, args, culture);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0002F7C7 File Offset: 0x0002D9C7
		public static object GetObject(string name)
		{
			return global::SR.GetObject(name);
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0002F7CF File Offset: 0x0002D9CF
		[global::System.Obsolete("This property is deprecated. Use ResourcesEditors.TodayButtonCaption instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString TodayButtonCaption
		{
			get
			{
				return global::Infragistics.Windows.Editors.Resources.GetDynamicResourceString("TodayButtonCaption");
			}
		}
	}
}
