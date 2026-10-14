using System;

namespace System.Data.Entity.Infrastructure.Design
{
	// Token: 0x020002A1 RID: 673
	public interface IResultHandler2 : global::System.Data.Entity.Infrastructure.Design.IResultHandler
	{
		// Token: 0x06002171 RID: 8561
		void SetError(string type, string message, string stackTrace);
	}
}
