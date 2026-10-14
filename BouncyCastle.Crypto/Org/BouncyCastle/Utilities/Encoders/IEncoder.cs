using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x02000065 RID: 101
	public interface IEncoder
	{
		// Token: 0x0600042B RID: 1067
		int Encode(byte[] data, int off, int length, global::System.IO.Stream outStream);

		// Token: 0x0600042C RID: 1068
		int Decode(byte[] data, int off, int length, global::System.IO.Stream outStream);

		// Token: 0x0600042D RID: 1069
		int DecodeString(string data, global::System.IO.Stream outStream);
	}
}
