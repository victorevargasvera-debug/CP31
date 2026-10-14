using System;
using System.ComponentModel;

// Token: 0x02000005 RID: 5
[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
internal sealed class LocalizedCategoryAttribute : global::System.ComponentModel.CategoryAttribute
{
	// Token: 0x0600001B RID: 27 RVA: 0x000026F6 File Offset: 0x000008F6
	public LocalizedCategoryAttribute(string category) : base(category)
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000026FF File Offset: 0x000008FF
	protected override string GetLocalizedString(string value)
	{
		return global::SR.GetUncustomizedString(null, value);
	}
}
