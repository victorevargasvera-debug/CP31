using System;
using System.IO;

namespace AcpCryptoLib
{
	// Token: 0x0200000D RID: 13
	public interface IAcpCryptoStream
	{
		// Token: 0x06000020 RID: 32
		global::System.IO.Stream GetWriter(global::System.IO.Stream stream);

		// Token: 0x06000021 RID: 33
		global::System.IO.Stream GetReader(global::System.IO.Stream stream);
	}
}
