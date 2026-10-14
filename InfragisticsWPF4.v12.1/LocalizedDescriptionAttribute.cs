using System;
using System.ComponentModel;

// Token: 0x020000A0 RID: 160
[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
internal sealed class LocalizedDescriptionAttribute : global::System.ComponentModel.DescriptionAttribute
{
	// Token: 0x06000620 RID: 1568 RVA: 0x000168BC File Offset: 0x00014ABC
	public LocalizedDescriptionAttribute(string description) : base(description)
	{
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06000621 RID: 1569 RVA: 0x000168C5 File Offset: 0x00014AC5
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

	// Token: 0x040002EE RID: 750
	private bool loaded;
}
