using System;
using System.ComponentModel;

// Token: 0x0200009F RID: 159
[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
internal sealed class LocalizedCategoryAttribute : global::System.ComponentModel.CategoryAttribute
{
	// Token: 0x0600061E RID: 1566 RVA: 0x000168AA File Offset: 0x00014AAA
	public LocalizedCategoryAttribute(string category) : base(category)
	{
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x000168B3 File Offset: 0x00014AB3
	protected override string GetLocalizedString(string value)
	{
		return global::SR.GetUncustomizedString(null, value);
	}
}
