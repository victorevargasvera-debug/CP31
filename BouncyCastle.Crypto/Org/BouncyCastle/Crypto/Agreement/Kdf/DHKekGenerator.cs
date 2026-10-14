using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Agreement.Kdf
{
	// Token: 0x020004FE RID: 1278
	public class DHKekGenerator : global::Org.BouncyCastle.Crypto.IDerivationFunction
	{
		// Token: 0x06003218 RID: 12824 RVA: 0x000F09CE File Offset: 0x000EEBCE
		public DHKekGenerator(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.digest = digest;
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x000F09E0 File Offset: 0x000EEBE0
		public virtual void Init(global::Org.BouncyCastle.Crypto.IDerivationParameters param)
		{
			global::Org.BouncyCastle.Crypto.Agreement.Kdf.DHKdfParameters parameters = (global::Org.BouncyCastle.Crypto.Agreement.Kdf.DHKdfParameters)param;
			this.algorithm = parameters.Algorithm;
			this.keySize = parameters.KeySize;
			this.z = parameters.GetZ();
			this.partyAInfo = parameters.GetExtraInfo();
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x0600321A RID: 12826 RVA: 0x000F0A24 File Offset: 0x000EEC24
		public virtual global::Org.BouncyCastle.Crypto.IDigest Digest
		{
			get
			{
				return this.digest;
			}
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x000F0A2C File Offset: 0x000EEC2C
		public virtual int GenerateBytes(byte[] outBytes, int outOff, int len)
		{
			if (outBytes.Length - len < outOff)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too small");
			}
			long oBytes = (long)len;
			int outLen = this.digest.GetDigestSize();
			if (oBytes > 8589934591L)
			{
				throw new global::System.ArgumentException("Output length too large");
			}
			int cThreshold = (int)((oBytes + (long)outLen - 1L) / (long)outLen);
			byte[] dig = new byte[this.digest.GetDigestSize()];
			uint counter = 1U;
			for (int i = 0; i < cThreshold; i++)
			{
				this.digest.BlockUpdate(this.z, 0, this.z.Length);
				global::Org.BouncyCastle.Asn1.DerSequence keyInfo = new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
				{
					this.algorithm,
					new global::Org.BouncyCastle.Asn1.DerOctetString(global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(counter))
				});
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
				{
					keyInfo
				});
				if (this.partyAInfo != null)
				{
					v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, new global::Org.BouncyCastle.Asn1.DerOctetString(this.partyAInfo)));
				}
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 2, new global::Org.BouncyCastle.Asn1.DerOctetString(global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE((uint)this.keySize))));
				byte[] other = new global::Org.BouncyCastle.Asn1.DerSequence(v).GetDerEncoded();
				this.digest.BlockUpdate(other, 0, other.Length);
				this.digest.DoFinal(dig, 0);
				if (len > outLen)
				{
					global::System.Array.Copy(dig, 0, outBytes, outOff, outLen);
					outOff += outLen;
					len -= outLen;
				}
				else
				{
					global::System.Array.Copy(dig, 0, outBytes, outOff, len);
				}
				counter += 1U;
			}
			this.digest.Reset();
			return (int)oBytes;
		}

		// Token: 0x0400162E RID: 5678
		private readonly global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x0400162F RID: 5679
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm;

		// Token: 0x04001630 RID: 5680
		private int keySize;

		// Token: 0x04001631 RID: 5681
		private byte[] z;

		// Token: 0x04001632 RID: 5682
		private byte[] partyAInfo;
	}
}
