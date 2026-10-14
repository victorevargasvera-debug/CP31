using System;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000473 RID: 1139
	public class HkdfBytesGenerator : global::Org.BouncyCastle.Crypto.IDerivationFunction
	{
		// Token: 0x06002BDF RID: 11231 RVA: 0x000BCB51 File Offset: 0x000BAD51
		public HkdfBytesGenerator(global::Org.BouncyCastle.Crypto.IDigest hash)
		{
			this.hMacHash = new global::Org.BouncyCastle.Crypto.Macs.HMac(hash);
			this.hashLen = hash.GetDigestSize();
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x000BCB74 File Offset: 0x000BAD74
		public virtual void Init(global::Org.BouncyCastle.Crypto.IDerivationParameters parameters)
		{
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.HkdfParameters))
			{
				throw new global::System.ArgumentException("HKDF parameters required for HkdfBytesGenerator", "parameters");
			}
			global::Org.BouncyCastle.Crypto.Parameters.HkdfParameters hkdfParameters = (global::Org.BouncyCastle.Crypto.Parameters.HkdfParameters)parameters;
			if (hkdfParameters.SkipExtract)
			{
				this.hMacHash.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(hkdfParameters.GetIkm()));
			}
			else
			{
				this.hMacHash.Init(this.Extract(hkdfParameters.GetSalt(), hkdfParameters.GetIkm()));
			}
			this.info = hkdfParameters.GetInfo();
			this.generatedBytes = 0;
			this.currentT = new byte[this.hashLen];
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x000BCC04 File Offset: 0x000BAE04
		private global::Org.BouncyCastle.Crypto.Parameters.KeyParameter Extract(byte[] salt, byte[] ikm)
		{
			if (salt == null)
			{
				this.hMacHash.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(new byte[this.hashLen]));
			}
			else
			{
				this.hMacHash.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(salt));
			}
			this.hMacHash.BlockUpdate(ikm, 0, ikm.Length);
			byte[] prk = new byte[this.hashLen];
			this.hMacHash.DoFinal(prk, 0);
			return new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(prk);
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000BCC74 File Offset: 0x000BAE74
		private void ExpandNext()
		{
			int i = this.generatedBytes / this.hashLen + 1;
			if (i >= 256)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("HKDF cannot generate more than 255 blocks of HashLen size");
			}
			if (this.generatedBytes != 0)
			{
				this.hMacHash.BlockUpdate(this.currentT, 0, this.hashLen);
			}
			this.hMacHash.BlockUpdate(this.info, 0, this.info.Length);
			this.hMacHash.Update((byte)i);
			this.hMacHash.DoFinal(this.currentT, 0);
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06002BE3 RID: 11235 RVA: 0x000BCCFE File Offset: 0x000BAEFE
		public virtual global::Org.BouncyCastle.Crypto.IDigest Digest
		{
			get
			{
				return this.hMacHash.GetUnderlyingDigest();
			}
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x000BCD0C File Offset: 0x000BAF0C
		public virtual int GenerateBytes(byte[] output, int outOff, int len)
		{
			if (this.generatedBytes + len > 255 * this.hashLen)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("HKDF may only be used for 255 * HashLen bytes of output");
			}
			if (this.generatedBytes % this.hashLen == 0)
			{
				this.ExpandNext();
			}
			int posInT = this.generatedBytes % this.hashLen;
			int toCopy = global::System.Math.Min(this.hashLen - this.generatedBytes % this.hashLen, len);
			global::System.Array.Copy(this.currentT, posInT, output, outOff, toCopy);
			this.generatedBytes += toCopy;
			int toGenerate = len - toCopy;
			outOff += toCopy;
			while (toGenerate > 0)
			{
				this.ExpandNext();
				toCopy = global::System.Math.Min(this.hashLen, toGenerate);
				global::System.Array.Copy(this.currentT, 0, output, outOff, toCopy);
				this.generatedBytes += toCopy;
				toGenerate -= toCopy;
				outOff += toCopy;
			}
			return len;
		}

		// Token: 0x04001236 RID: 4662
		private global::Org.BouncyCastle.Crypto.Macs.HMac hMacHash;

		// Token: 0x04001237 RID: 4663
		private int hashLen;

		// Token: 0x04001238 RID: 4664
		private byte[] info;

		// Token: 0x04001239 RID: 4665
		private byte[] currentT;

		// Token: 0x0400123A RID: 4666
		private int generatedBytes;
	}
}
