using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x0200000D RID: 13
	public interface IContentHelper<T>
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004B RID: 75
		global::System.Collections.Generic.IEqualityComparer<T> DeleteComparer { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004C RID: 76
		global::System.Collections.Generic.IEqualityComparer<T> WriteComparer { get; }

		// Token: 0x0600004D RID: 77
		global::System.Collections.Generic.IList<T> ListCurrent();

		// Token: 0x0600004E RID: 78
		void PreSync();

		// Token: 0x0600004F RID: 79
		void Delete(T content);

		// Token: 0x06000050 RID: 80
		void Write(T content, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);
	}
}
