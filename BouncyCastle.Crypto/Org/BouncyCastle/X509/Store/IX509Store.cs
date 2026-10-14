using System;
using System.Collections;

namespace Org.BouncyCastle.X509.Store
{
	// Token: 0x02000024 RID: 36
	public interface IX509Store
	{
		// Token: 0x060001A2 RID: 418
		global::System.Collections.ICollection GetMatches(global::Org.BouncyCastle.X509.Store.IX509Selector selector);
	}
}
