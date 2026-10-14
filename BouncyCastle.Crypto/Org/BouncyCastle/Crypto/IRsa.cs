using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002DC RID: 732
	public interface IRsa
	{
		// Token: 0x06001FBB RID: 8123
		void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters);

		// Token: 0x06001FBC RID: 8124
		int GetInputBlockSize();

		// Token: 0x06001FBD RID: 8125
		int GetOutputBlockSize();

		// Token: 0x06001FBE RID: 8126
		global::Org.BouncyCastle.Math.BigInteger ConvertInput(byte[] buf, int off, int len);

		// Token: 0x06001FBF RID: 8127
		global::Org.BouncyCastle.Math.BigInteger ProcessBlock(global::Org.BouncyCastle.Math.BigInteger input);

		// Token: 0x06001FC0 RID: 8128
		byte[] ConvertOutput(global::Org.BouncyCastle.Math.BigInteger result);
	}
}
