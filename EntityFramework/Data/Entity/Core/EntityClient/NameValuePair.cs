using System;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.EntityClient
{
	// Token: 0x020005E3 RID: 1507
	internal sealed class NameValuePair
	{
		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x060049C0 RID: 18880 RVA: 0x001048E4 File Offset: 0x00102AE4
		// (set) Token: 0x060049C1 RID: 18881 RVA: 0x001048EC File Offset: 0x00102AEC
		internal global::System.Data.Entity.Core.EntityClient.NameValuePair Next
		{
			get
			{
				return this._next;
			}
			set
			{
				if (this._next != null || value == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_InternalProviderError(1014));
				}
				this._next = value;
			}
		}

		// Token: 0x04001A05 RID: 6661
		private global::System.Data.Entity.Core.EntityClient.NameValuePair _next;
	}
}
