using System;
using System.ComponentModel;

// Token: 0x02000004 RID: 4
[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
internal sealed class LocalizedDescriptionAttribute : global::System.ComponentModel.DescriptionAttribute
{
	// Token: 0x06000014 RID: 20 RVA: 0x000023F4 File Offset: 0x000005F4
	public LocalizedDescriptionAttribute(string description) : base(description)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000015 RID: 21 RVA: 0x000023FD File Offset: 0x000005FD
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

	// Token: 0x04000004 RID: 4
	private bool loaded;
}
