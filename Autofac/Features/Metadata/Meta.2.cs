using System;
using System.Collections.Generic;

namespace Autofac.Features.Metadata
{
	// Token: 0x0200003F RID: 63
	public class Meta<T>
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x00006F3F File Offset: 0x0000513F
		public Meta(T value, global::System.Collections.Generic.IDictionary<string, object> metadata)
		{
			this.Value = value;
			this.Metadata = metadata;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00006F55 File Offset: 0x00005155
		public T Value { get; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00006F5D File Offset: 0x0000515D
		public global::System.Collections.Generic.IDictionary<string, object> Metadata { get; }
	}
}
