using System;
using System.Globalization;
using Infragistics.Shared;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000005 RID: 5
	public static class Resources
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002389 File Offset: 0x00000589
		public static global::Infragistics.Shared.ResourceCustomizer Customizer
		{
			get
			{
				return global::ResourceCustomizerLocator.Customizer;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002390 File Offset: 0x00000590
		public static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(null, name, args);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000239A File Offset: 0x0000059A
		public static string GetString(string name)
		{
			return global::SR.GetString(null, name);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000023A3 File Offset: 0x000005A3
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name)
		{
			return global::SR.GetDynamicResourceString(name, null, null);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000023AD File Offset: 0x000005AD
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args)
		{
			return global::SR.GetDynamicResourceString(name, args, null);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000023B7 File Offset: 0x000005B7
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args, global::System.Globalization.CultureInfo culture)
		{
			return global::SR.GetDynamicResourceString(name, args, culture);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000023C1 File Offset: 0x000005C1
		public static object GetObject(string name)
		{
			return global::SR.GetObject(null, name);
		}
	}
}
