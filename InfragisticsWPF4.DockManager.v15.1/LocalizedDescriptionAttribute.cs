using System;
using System.ComponentModel;

// Token: 0x02000006 RID: 6
[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
internal sealed class LocalizedDescriptionAttribute : global::System.ComponentModel.DescriptionAttribute
{
	// Token: 0x0600001D RID: 29 RVA: 0x00002708 File Offset: 0x00000908
	public LocalizedDescriptionAttribute(string description) : base(description)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600001E RID: 30 RVA: 0x00002711 File Offset: 0x00000911
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

	// Token: 0x0400000A RID: 10
	private bool loaded;
}
