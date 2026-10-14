using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000479 RID: 1145
	public class Mgf1BytesGenerator : global::Org.BouncyCastle.Crypto.IDerivationFunction
	{
		// Token: 0x06002BFC RID: 11260 RVA: 0x000BD7E4 File Offset: 0x000BB9E4
		public Mgf1BytesGenerator(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.digest = digest;
			this.hLen = digest.GetDigestSize();
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x000BD800 File Offset: 0x000BBA00
		public void Init(global::Org.BouncyCastle.Crypto.IDerivationParameters parameters)
		{
			if (!typeof(global::Org.BouncyCastle.Crypto.Parameters.MgfParameters).IsInstanceOfType(parameters))
			{
				throw new global::System.ArgumentException("MGF parameters required for MGF1Generator");
			}
			global::Org.BouncyCastle.Crypto.Parameters.MgfParameters p = (global::Org.BouncyCastle.Crypto.Parameters.MgfParameters)parameters;
			this.seed = p.GetSeed();
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06002BFE RID: 11262 RVA: 0x000BD83D File Offset: 0x000BBA3D
		public global::Org.BouncyCastle.Crypto.IDigest Digest
		{
			get
			{
				return this.digest;
			}
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x000BD845 File Offset: 0x000BBA45
		private void ItoOSP(int i, byte[] sp)
		{
			sp[0] = (byte)((uint)i >> 24);
			sp[1] = (byte)((uint)i >> 16);
			sp[2] = (byte)((uint)i >> 8);
			sp[3] = (byte)i;
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x000BD864 File Offset: 0x000BBA64
		public int GenerateBytes(byte[] output, int outOff, int length)
		{
			if (output.Length - length < outOff)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too small");
			}
			byte[] hashBuf = new byte[this.hLen];
			byte[] C = new byte[4];
			int counter = 0;
			this.digest.Reset();
			if (length > this.hLen)
			{
				do
				{
					this.ItoOSP(counter, C);
					this.digest.BlockUpdate(this.seed, 0, this.seed.Length);
					this.digest.BlockUpdate(C, 0, C.Length);
					this.digest.DoFinal(hashBuf, 0);
					global::System.Array.Copy(hashBuf, 0, output, outOff + counter * this.hLen, this.hLen);
				}
				while (++counter < length / this.hLen);
			}
			if (counter * this.hLen < length)
			{
				this.ItoOSP(counter, C);
				this.digest.BlockUpdate(this.seed, 0, this.seed.Length);
				this.digest.BlockUpdate(C, 0, C.Length);
				this.digest.DoFinal(hashBuf, 0);
				global::System.Array.Copy(hashBuf, 0, output, outOff + counter * this.hLen, length - counter * this.hLen);
			}
			return length;
		}

		// Token: 0x0400125B RID: 4699
		private global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x0400125C RID: 4700
		private byte[] seed;

		// Token: 0x0400125D RID: 4701
		private int hLen;
	}
}
