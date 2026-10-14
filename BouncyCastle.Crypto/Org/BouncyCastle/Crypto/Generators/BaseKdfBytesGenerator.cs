using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000461 RID: 1121
	public class BaseKdfBytesGenerator : global::Org.BouncyCastle.Crypto.IDerivationFunction
	{
		// Token: 0x06002B84 RID: 11140 RVA: 0x000BA4EF File Offset: 0x000B86EF
		public BaseKdfBytesGenerator(int counterStart, global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.counterStart = counterStart;
			this.digest = digest;
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x000BA508 File Offset: 0x000B8708
		public virtual void Init(global::Org.BouncyCastle.Crypto.IDerivationParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.KdfParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.KdfParameters p = (global::Org.BouncyCastle.Crypto.Parameters.KdfParameters)parameters;
				this.shared = p.GetSharedSecret();
				this.iv = p.GetIV();
				return;
			}
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.Iso18033KdfParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.Iso18033KdfParameters p2 = (global::Org.BouncyCastle.Crypto.Parameters.Iso18033KdfParameters)parameters;
				this.shared = p2.GetSeed();
				this.iv = null;
				return;
			}
			throw new global::System.ArgumentException("KDF parameters required for KDF Generator");
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x000BA56A File Offset: 0x000B876A
		public virtual global::Org.BouncyCastle.Crypto.IDigest Digest
		{
			get
			{
				return this.digest;
			}
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x000BA574 File Offset: 0x000B8774
		public virtual int GenerateBytes(byte[] output, int outOff, int length)
		{
			if (output.Length - length < outOff)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too small");
			}
			long oBytes = (long)length;
			int outLen = this.digest.GetDigestSize();
			if (oBytes > 8589934591L)
			{
				throw new global::System.ArgumentException("Output length too large");
			}
			int cThreshold = (int)((oBytes + (long)outLen - 1L) / (long)outLen);
			byte[] dig = new byte[this.digest.GetDigestSize()];
			byte[] C = new byte[4];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE((uint)this.counterStart, C, 0);
			uint counterBase = (uint)(this.counterStart & -256);
			for (int i = 0; i < cThreshold; i++)
			{
				this.digest.BlockUpdate(this.shared, 0, this.shared.Length);
				this.digest.BlockUpdate(C, 0, 4);
				if (this.iv != null)
				{
					this.digest.BlockUpdate(this.iv, 0, this.iv.Length);
				}
				this.digest.DoFinal(dig, 0);
				if (length > outLen)
				{
					global::System.Array.Copy(dig, 0, output, outOff, outLen);
					outOff += outLen;
					length -= outLen;
				}
				else
				{
					global::System.Array.Copy(dig, 0, output, outOff, length);
				}
				byte[] array = C;
				int num = 3;
				byte b = array[num] + 1;
				array[num] = b;
				if (b == 0)
				{
					counterBase += 256U;
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(counterBase, C, 0);
				}
			}
			this.digest.Reset();
			return (int)oBytes;
		}

		// Token: 0x040011FF RID: 4607
		private int counterStart;

		// Token: 0x04001200 RID: 4608
		private global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04001201 RID: 4609
		private byte[] shared;

		// Token: 0x04001202 RID: 4610
		private byte[] iv;
	}
}
