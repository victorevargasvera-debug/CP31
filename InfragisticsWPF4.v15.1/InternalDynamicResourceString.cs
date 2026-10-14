using System;
using System.Globalization;
using Infragistics.Shared;

// Token: 0x020000BB RID: 187
internal sealed class InternalDynamicResourceString : global::Infragistics.Shared.DynamicResourceString
{
	// Token: 0x06000706 RID: 1798 RVA: 0x0001A00E File Offset: 0x0001820E
	internal InternalDynamicResourceString(global::Infragistics.Shared.ResourceCustomizer customizer, global::System.Globalization.CultureInfo cultureInfo, string resourceName, object[] args) : base(customizer, cultureInfo, resourceName, args)
	{
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x0001A01B File Offset: 0x0001821B
	protected override string GetStringFromResource(string resourceName, global::System.Globalization.CultureInfo culture)
	{
		return global::SR.GetString(culture, resourceName, null);
	}
}
