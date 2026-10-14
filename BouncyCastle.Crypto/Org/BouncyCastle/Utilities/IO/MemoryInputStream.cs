using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x0200004F RID: 79
	public class MemoryInputStream : global::System.IO.MemoryStream
	{
		// Token: 0x060003AF RID: 943 RVA: 0x00013D6D File Offset: 0x00011F6D
		public MemoryInputStream(byte[] buffer) : base(buffer, false)
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00013D77 File Offset: 0x00011F77
		public sealed override bool CanWrite
		{
			get
			{
				return false;
			}
		}
	}
}
