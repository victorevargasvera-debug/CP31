using System;
using System.ComponentModel;

// Token: 0x020000B9 RID: 185
[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
internal sealed class LocalizedCategoryAttribute : global::System.ComponentModel.CategoryAttribute
{
	// Token: 0x06000702 RID: 1794 RVA: 0x00019FCA File Offset: 0x000181CA
	public LocalizedCategoryAttribute(string category) : base(category)
	{
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00019FD3 File Offset: 0x000181D3
	protected override string GetLocalizedString(string value)
	{
		return global::SR.GetUncustomizedString(null, value);
	}
}
