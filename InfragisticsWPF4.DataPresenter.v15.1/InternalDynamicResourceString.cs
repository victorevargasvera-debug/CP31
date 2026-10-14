using System;
using System.Globalization;
using Infragistics.Shared;

// Token: 0x0200000B RID: 11
internal sealed class InternalDynamicResourceString : global::Infragistics.Shared.DynamicResourceString
{
	// Token: 0x06000054 RID: 84 RVA: 0x0000310A File Offset: 0x0000130A
	internal InternalDynamicResourceString(global::Infragistics.Shared.ResourceCustomizer customizer, global::System.Globalization.CultureInfo cultureInfo, string resourceName, object[] args) : base(customizer, cultureInfo, resourceName, args)
	{
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00003117 File Offset: 0x00001317
	protected override string GetStringFromResource(string resourceName, global::System.Globalization.CultureInfo culture)
	{
		return global::SR.GetString(culture, resourceName, null);
	}
}
