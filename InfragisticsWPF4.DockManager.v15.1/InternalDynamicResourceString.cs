using System;
using System.Globalization;
using Infragistics.Shared;

// Token: 0x02000007 RID: 7
internal sealed class InternalDynamicResourceString : global::Infragistics.Shared.DynamicResourceString
{
	// Token: 0x0600001F RID: 31 RVA: 0x0000273A File Offset: 0x0000093A
	internal InternalDynamicResourceString(global::Infragistics.Shared.ResourceCustomizer customizer, global::System.Globalization.CultureInfo cultureInfo, string resourceName, object[] args) : base(customizer, cultureInfo, resourceName, args)
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002747 File Offset: 0x00000947
	protected override string GetStringFromResource(string resourceName, global::System.Globalization.CultureInfo culture)
	{
		return global::SR.GetString(culture, resourceName, null);
	}
}
