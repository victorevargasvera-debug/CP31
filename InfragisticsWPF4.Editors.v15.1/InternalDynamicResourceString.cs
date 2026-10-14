using System;
using System.Globalization;
using Infragistics.Shared;

// Token: 0x02000005 RID: 5
internal sealed class InternalDynamicResourceString : global::Infragistics.Shared.DynamicResourceString
{
	// Token: 0x06000016 RID: 22 RVA: 0x00002426 File Offset: 0x00000626
	internal InternalDynamicResourceString(global::Infragistics.Shared.ResourceCustomizer customizer, global::System.Globalization.CultureInfo cultureInfo, string resourceName, object[] args) : base(customizer, cultureInfo, resourceName, args)
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002433 File Offset: 0x00000633
	protected override string GetStringFromResource(string resourceName, global::System.Globalization.CultureInfo culture)
	{
		return global::SR.GetString(culture, resourceName, null);
	}
}
