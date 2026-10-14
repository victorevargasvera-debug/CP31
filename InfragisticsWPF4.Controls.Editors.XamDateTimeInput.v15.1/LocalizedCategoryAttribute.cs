using System;
using System.ComponentModel;

// Token: 0x02000008 RID: 8
[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
internal sealed class LocalizedCategoryAttribute : global::System.ComponentModel.CategoryAttribute
{
	// Token: 0x06000071 RID: 113 RVA: 0x00003ABA File Offset: 0x00001CBA
	public LocalizedCategoryAttribute(string category) : base(category)
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00003AC3 File Offset: 0x00001CC3
	protected override string GetLocalizedString(string value)
	{
		return global::SR.GetUncustomizedString(null, value);
	}
}
