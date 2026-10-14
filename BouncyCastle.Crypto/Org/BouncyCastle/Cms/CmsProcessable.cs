using System;
using System.IO;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000530 RID: 1328
	public interface CmsProcessable
	{
		// Token: 0x06003348 RID: 13128
		void Write(global::System.IO.Stream outStream);

		// Token: 0x06003349 RID: 13129
		[global::System.Obsolete]
		object GetContent();
	}
}
