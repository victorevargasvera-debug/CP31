using System;
using System.Globalization;
using Infragistics.Shared;

// Token: 0x0200000A RID: 10
internal sealed class InternalDynamicResourceString : global::Infragistics.Shared.DynamicResourceString
{
	// Token: 0x06000075 RID: 117 RVA: 0x00003AFE File Offset: 0x00001CFE
	internal InternalDynamicResourceString(global::Infragistics.Shared.ResourceCustomizer customizer, global::System.Globalization.CultureInfo cultureInfo, string resourceName, object[] args) : base(customizer, cultureInfo, resourceName, args)
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00003B0B File Offset: 0x00001D0B
	protected override string GetStringFromResource(string resourceName, global::System.Globalization.CultureInfo culture)
	{
		return global::SR.GetString(culture, resourceName, null);
	}
}
