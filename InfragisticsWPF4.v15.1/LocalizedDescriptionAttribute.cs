using System;
using System.ComponentModel;

// Token: 0x020000BA RID: 186
[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
internal sealed class LocalizedDescriptionAttribute : global::System.ComponentModel.DescriptionAttribute
{
	// Token: 0x06000704 RID: 1796 RVA: 0x00019FDC File Offset: 0x000181DC
	public LocalizedDescriptionAttribute(string description) : base(description)
	{
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06000705 RID: 1797 RVA: 0x00019FE5 File Offset: 0x000181E5
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

	// Token: 0x04000390 RID: 912
	private bool loaded;
}
