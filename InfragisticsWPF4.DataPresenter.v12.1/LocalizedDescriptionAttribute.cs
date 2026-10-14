using System;
using System.ComponentModel;

// Token: 0x0200000A RID: 10
[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
internal sealed class LocalizedDescriptionAttribute : global::System.ComponentModel.DescriptionAttribute
{
	// Token: 0x06000051 RID: 81 RVA: 0x0000359C File Offset: 0x0000179C
	public LocalizedDescriptionAttribute(string description) : base(description)
	{
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000052 RID: 82 RVA: 0x000035A5 File Offset: 0x000017A5
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

	// Token: 0x04000024 RID: 36
	private bool loaded;
}
