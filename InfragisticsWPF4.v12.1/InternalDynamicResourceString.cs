using System;
using System.Globalization;
using Infragistics.Shared;

// Token: 0x020000A1 RID: 161
internal sealed class InternalDynamicResourceString : global::Infragistics.Shared.DynamicResourceString
{
	// Token: 0x06000622 RID: 1570 RVA: 0x000168EE File Offset: 0x00014AEE
	internal InternalDynamicResourceString(global::Infragistics.Shared.ResourceCustomizer customizer, global::System.Globalization.CultureInfo cultureInfo, string resourceName, object[] args) : base(customizer, cultureInfo, resourceName, args)
	{
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x000168FB File Offset: 0x00014AFB
	protected override string GetStringFromResource(string resourceName, global::System.Globalization.CultureInfo culture)
	{
		return global::SR.GetString(culture, resourceName, null);
	}
}
