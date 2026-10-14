using System;
using System.ComponentModel;

// Token: 0x02000009 RID: 9
[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
internal sealed class LocalizedDescriptionAttribute : global::System.ComponentModel.DescriptionAttribute
{
	// Token: 0x06000073 RID: 115 RVA: 0x00003ACC File Offset: 0x00001CCC
	public LocalizedDescriptionAttribute(string description) : base(description)
	{
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000074 RID: 116 RVA: 0x00003AD5 File Offset: 0x00001CD5
	public override string Description
	{
		get
		{
			if (!this.loaded)
			{
				this.loaded = true;
				base.DescriptionValue = global::SR.GetUncustomizedString(null, base.Description);
			}
			return base.Description;
		}
	}

	// Token: 0x0400002C RID: 44
	private bool loaded;
}
