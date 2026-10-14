using System;
using System.ComponentModel;

// Token: 0x02000009 RID: 9
[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
internal sealed class LocalizedCategoryAttribute : global::System.ComponentModel.CategoryAttribute
{
	// Token: 0x06000050 RID: 80 RVA: 0x000030C6 File Offset: 0x000012C6
	public LocalizedCategoryAttribute(string category) : base(category)
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x000030CF File Offset: 0x000012CF
	protected override string GetLocalizedString(string value)
	{
		return global::SR.GetUncustomizedString(null, value);
	}
}
