using System;
using System.ComponentModel;

// Token: 0x02000009 RID: 9
[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
internal sealed class LocalizedCategoryAttribute : global::System.ComponentModel.CategoryAttribute
{
	// Token: 0x0600004F RID: 79 RVA: 0x0000358A File Offset: 0x0000178A
	public LocalizedCategoryAttribute(string category) : base(category)
	{
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00003593 File Offset: 0x00001793
	protected override string GetLocalizedString(string value)
	{
		return global::SR.GetUncustomizedString(null, value);
	}
}
