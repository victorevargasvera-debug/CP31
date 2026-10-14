using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000453 RID: 1107
	public class HMac : global::Org.BouncyCastle.Crypto.IMac
	{
		// Token: 0x06002AE3 RID: 10979 RVA: 0x000B7BAC File Offset: 0x000B5DAC
		public HMac(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.digest = digest;
			this.digestSize = digest.GetDigestSize();
			this.blockLength = digest.GetByteLength();
			this.inputPad = new byte[this.blockLength];
			this.outputBuf = new byte[this.blockLength + this.digestSize];
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x000B7C07 File Offset: 0x000B5E07
		public virtual string AlgorithmName
		{
			get
			{
				return this.digest.AlgorithmName + "/HMAC";
			}
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x000B7C1E File Offset: 0x000B5E1E
		public virtual global::Org.BouncyCastle.Crypto.IDigest GetUnderlyingDigest()
		{
			return this.digest;
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x000B7C28 File Offset: 0x000B5E28
		public virtual void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.digest.Reset();
			byte[] key = ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey();
			int keyLength = key.Length;
			if (keyLength > this.blockLength)
			{
				this.digest.BlockUpdate(key, 0, keyLength);
				this.digest.DoFinal(this.inputPad, 0);
				keyLength = this.digestSize;
			}
			else
			{
				global::System.Array.Copy(key, 0, this.inputPad, 0, keyLength);
			}
			global::System.Array.Clear(this.inputPad, keyLength, this.blockLength - keyLength);
			global::System.Array.Copy(this.inputPad, 0, this.outputBuf, 0, this.blockLength);
			global::Org.BouncyCastle.Crypto.Macs.HMac.XorPad(this.inputPad, this.blockLength, 54);
			global::Org.BouncyCastle.Crypto.Macs.HMac.XorPad(this.outputBuf, this.blockLength, 92);
			if (this.digest is global::Org.BouncyCastle.Utilities.IMemoable)
			{
				this.opadState = ((global::Org.BouncyCastle.Utilities.IMemoable)this.digest).Copy();
				((global::Org.BouncyCastle.Crypto.IDigest)this.opadState).BlockUpdate(this.outputBuf, 0, this.blockLength);
			}
			this.digest.BlockUpdate(this.inputPad, 0, this.inputPad.Length);
			if (this.digest is global::Org.BouncyCastle.Utilities.IMemoable)
			{
				this.ipadState = ((global::Org.BouncyCastle.Utilities.IMemoable)this.digest).Copy();
			}
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x000B7D62 File Offset: 0x000B5F62
		public virtual int GetMacSize()
		{
			return this.digestSize;
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x000B7D6A File Offset: 0x000B5F6A
		public virtual void Update(byte input)
		{
			this.digest.Update(input);
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000B7D78 File Offset: 0x000B5F78
		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
			this.digest.BlockUpdate(input, inOff, len);
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x000B7D88 File Offset: 0x000B5F88
		public virtual int DoFinal(byte[] output, int outOff)
		{
			this.digest.DoFinal(this.outputBuf, this.blockLength);
			if (this.opadState != null)
			{
				((global::Org.BouncyCastle.Utilities.IMemoable)this.digest).Reset(this.opadState);
				this.digest.BlockUpdate(this.outputBuf, this.blockLength, this.digest.GetDigestSize());
			}
			else
			{
				this.digest.BlockUpdate(this.outputBuf, 0, this.outputBuf.Length);
			}
			int result = this.digest.DoFinal(output, outOff);
			global::System.Array.Clear(this.outputBuf, this.blockLength, this.digestSize);
			if (this.ipadState != null)
			{
				((global::Org.BouncyCastle.Utilities.IMemoable)this.digest).Reset(this.ipadState);
				return result;
			}
			this.digest.BlockUpdate(this.inputPad, 0, this.inputPad.Length);
			return result;
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x000B7E66 File Offset: 0x000B6066
		public virtual void Reset()
		{
			this.digest.Reset();
			this.digest.BlockUpdate(this.inputPad, 0, this.inputPad.Length);
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x000B7E90 File Offset: 0x000B6090
		private static void XorPad(byte[] pad, int len, byte n)
		{
			for (int i = 0; i < len; i++)
			{
				int num = i;
				pad[num] ^= n;
			}
		}

		// Token: 0x040011A4 RID: 4516
		private const byte IPAD = 54;

		// Token: 0x040011A5 RID: 4517
		private const byte OPAD = 92;

		// Token: 0x040011A6 RID: 4518
		private readonly global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x040011A7 RID: 4519
		private readonly int digestSize;

		// Token: 0x040011A8 RID: 4520
		private readonly int blockLength;

		// Token: 0x040011A9 RID: 4521
		private global::Org.BouncyCastle.Utilities.IMemoable ipadState;

		// Token: 0x040011AA RID: 4522
		private global::Org.BouncyCastle.Utilities.IMemoable opadState;

		// Token: 0x040011AB RID: 4523
		private readonly byte[] inputPad;

		// Token: 0x040011AC RID: 4524
		private readonly byte[] outputBuf;
	}
}
