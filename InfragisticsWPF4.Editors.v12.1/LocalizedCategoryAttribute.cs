using System;
using System.ComponentModel;

// Token: 0x02000003 RID: 3
[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
internal sealed class LocalizedCategoryAttribute : global::System.ComponentModel.CategoryAttribute
{
	// Token: 0x06000012 RID: 18 RVA: 0x000023E2 File Offset: 0x000005E2
	public LocalizedCategoryAttribute(string category) : base(category)
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000023EB File Offset: 0x000005EB
	protected override string GetLocalizedString(string value)
	{
		return global::SR.GetUncustomizedString(null, value);
	}
}
