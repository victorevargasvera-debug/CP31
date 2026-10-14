using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x02000050 RID: 80
	public class MemoryOutputStream : global::System.IO.MemoryStream
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00013D7A File Offset: 0x00011F7A
		public sealed override bool CanRead
		{
			get
			{
				return false;
			}
		}
	}
}
