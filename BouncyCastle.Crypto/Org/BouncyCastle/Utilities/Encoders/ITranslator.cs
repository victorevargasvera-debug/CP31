using System;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x02000066 RID: 102
	public interface ITranslator
	{
		// Token: 0x0600042E RID: 1070
		int GetEncodedBlockSize();

		// Token: 0x0600042F RID: 1071
		int Encode(byte[] input, int inOff, int length, byte[] outBytes, int outOff);

		// Token: 0x06000430 RID: 1072
		int GetDecodedBlockSize();

		// Token: 0x06000431 RID: 1073
		int Decode(byte[] input, int inOff, int length, byte[] outBytes, int outOff);
	}
}
