using System;
using System.Globalization;
using Infragistics.Shared;

// Token: 0x0200000B RID: 11
internal sealed class InternalDynamicResourceString : global::Infragistics.Shared.DynamicResourceString
{
	// Token: 0x06000053 RID: 83 RVA: 0x000035CE File Offset: 0x000017CE
	internal InternalDynamicResourceString(global::Infragistics.Shared.ResourceCustomizer customizer, global::System.Globalization.CultureInfo cultureInfo, string resourceName, object[] args) : base(customizer, cultureInfo, resourceName, args)
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x000035DB File Offset: 0x000017DB
	protected override string GetStringFromResource(string resourceName, global::System.Globalization.CultureInfo culture)
	{
		return global::SR.GetString(culture, resourceName, null);
	}
}
