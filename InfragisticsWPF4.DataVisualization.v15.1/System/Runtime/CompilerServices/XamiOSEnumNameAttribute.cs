using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000081 RID: 129
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Enum | global::System.AttributeTargets.Property)]
	public class XamiOSEnumNameAttribute : global::System.Attribute
	{
		// Token: 0x0600065D RID: 1629 RVA: 0x0001BFA3 File Offset: 0x0001A1A3
		public XamiOSEnumNameAttribute(string value)
		{
			this.Value = value;
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0001BFB2 File Offset: 0x0001A1B2
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x0001BFBA File Offset: 0x0001A1BA
		public string Value { get; set; }
	}
}
