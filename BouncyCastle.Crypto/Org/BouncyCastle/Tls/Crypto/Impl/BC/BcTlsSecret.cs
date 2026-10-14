using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000185 RID: 389
	public class BcTlsSecret : global::Org.BouncyCastle.Tls.Crypto.Impl.AbstractTlsSecret
	{
		// Token: 0x06000EBC RID: 3772 RVA: 0x000364CC File Offset: 0x000346CC
		public static global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSecret Convert(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret)
		{
			if (secret is global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSecret)
			{
				return (global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSecret)secret;
			}
			if (secret is global::Org.BouncyCastle.Tls.Crypto.Impl.AbstractTlsSecret)
			{
				global::Org.BouncyCastle.Tls.Crypto.Impl.AbstractTlsSecret abstractTlsSecret = (global::Org.BouncyCastle.Tls.Crypto.Impl.AbstractTlsSecret)secret;
				return crypto.AdoptLocalSecret(global::Org.BouncyCastle.Tls.Crypto.Impl.AbstractTlsSecret.CopyData(abstractTlsSecret));
			}
			throw new global::System.ArgumentException("unrecognized TlsSecret - cannot copy data: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(secret));
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0003651C File Offset: 0x0003471C
		private static byte[] GenerateSsl3Constants()
		{
			int i = 15;
			byte[] result = new byte[i * (i + 1) / 2];
			int pos = 0;
			for (int j = 0; j < i; j++)
			{
				byte b = (byte)(65 + j);
				for (int k = 0; k <= j; k++)
				{
					result[pos++] = b;
				}
			}
			return result;
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00036568 File Offset: 0x00034768
		public BcTlsSecret(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, byte[] data) : base(data)
		{
			this.m_crypto = crypto;
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00036578 File Offset: 0x00034778
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret DeriveUsingPrf(int prfAlgorithm, string label, byte[] seed, int length)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret result;
			lock (this)
			{
				this.CheckAlive();
				switch (prfAlgorithm)
				{
				case 4:
					return global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.HkdfExpandLabel(this, 4, label, seed, length);
				case 5:
					return global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.HkdfExpandLabel(this, 5, label, seed, length);
				case 7:
					return global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.HkdfExpandLabel(this, 7, label, seed, length);
				}
				result = this.m_crypto.AdoptLocalSecret(this.Prf(prfAlgorithm, label, seed, length));
			}
			return result;
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00036610 File Offset: 0x00034810
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret HkdfExpand(int cryptoHashAlgorithm, byte[] info, int length)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret result;
			lock (this)
			{
				if (length < 1)
				{
					result = this.m_crypto.AdoptLocalSecret(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes);
				}
				else
				{
					int hashLen = global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashOutputSize(cryptoHashAlgorithm);
					if (length > 255 * hashLen)
					{
						throw new global::System.ArgumentException("must be <= 255 * (output size of 'hashAlgorithm')", "length");
					}
					this.CheckAlive();
					byte[] prk = this.m_data;
					global::Org.BouncyCastle.Crypto.Macs.HMac hmac = new global::Org.BouncyCastle.Crypto.Macs.HMac(this.m_crypto.CreateDigest(cryptoHashAlgorithm));
					hmac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(prk));
					byte[] okm = new byte[length];
					byte[] t = new byte[hashLen];
					byte counter = 0;
					int pos = 0;
					int remaining;
					for (;;)
					{
						hmac.BlockUpdate(info, 0, info.Length);
						hmac.Update(counter += 1);
						hmac.DoFinal(t, 0);
						remaining = length - pos;
						if (remaining <= hashLen)
						{
							break;
						}
						global::System.Array.Copy(t, 0, okm, pos, hashLen);
						pos += hashLen;
						hmac.BlockUpdate(t, 0, t.Length);
					}
					global::System.Array.Copy(t, 0, okm, pos, remaining);
					result = this.m_crypto.AdoptLocalSecret(okm);
				}
			}
			return result;
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x0003673C File Offset: 0x0003493C
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret HkdfExtract(int cryptoHashAlgorithm, global::Org.BouncyCastle.Tls.Crypto.TlsSecret ikm)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret result;
			lock (this)
			{
				this.CheckAlive();
				byte[] salt = this.m_data;
				this.m_data = null;
				global::Org.BouncyCastle.Crypto.Macs.HMac hmac = new global::Org.BouncyCastle.Crypto.Macs.HMac(this.m_crypto.CreateDigest(cryptoHashAlgorithm));
				hmac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(salt));
				global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSecret.Convert(this.m_crypto, ikm).UpdateMac(hmac);
				byte[] prk = new byte[hmac.GetMacSize()];
				hmac.DoFinal(prk, 0);
				result = this.m_crypto.AdoptLocalSecret(prk);
			}
			return result;
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x000367E0 File Offset: 0x000349E0
		protected override global::Org.BouncyCastle.Tls.Crypto.Impl.AbstractTlsCrypto Crypto
		{
			get
			{
				return this.m_crypto;
			}
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x000367E8 File Offset: 0x000349E8
		protected virtual void HmacHash(global::Org.BouncyCastle.Crypto.IDigest digest, byte[] secret, int secretOff, int secretLen, byte[] seed, byte[] output)
		{
			global::Org.BouncyCastle.Crypto.Macs.HMac mac = new global::Org.BouncyCastle.Crypto.Macs.HMac(digest);
			mac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(secret, secretOff, secretLen));
			byte[] a = seed;
			int macSize = mac.GetMacSize();
			byte[] b = new byte[macSize];
			byte[] b2 = new byte[macSize];
			for (int pos = 0; pos < output.Length; pos += macSize)
			{
				mac.BlockUpdate(a, 0, a.Length);
				mac.DoFinal(b, 0);
				a = b;
				mac.BlockUpdate(a, 0, a.Length);
				mac.BlockUpdate(seed, 0, seed.Length);
				mac.DoFinal(b2, 0);
				global::System.Array.Copy(b2, 0, output, pos, global::System.Math.Min(macSize, output.Length - pos));
			}
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00036888 File Offset: 0x00034A88
		protected virtual byte[] Prf(int prfAlgorithm, string label, byte[] seed, int length)
		{
			if (prfAlgorithm == 0)
			{
				return this.Prf_Ssl(seed, length);
			}
			byte[] labelSeed = global::Org.BouncyCastle.Utilities.Arrays.Concatenate(global::Org.BouncyCastle.Utilities.Strings.ToByteArray(label), seed);
			if (1 == prfAlgorithm)
			{
				return this.Prf_1_0(labelSeed, length);
			}
			return this.Prf_1_2(prfAlgorithm, labelSeed, length);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x000368C8 File Offset: 0x00034AC8
		protected virtual byte[] Prf_Ssl(byte[] seed, int length)
		{
			global::Org.BouncyCastle.Crypto.IDigest md5 = this.m_crypto.CreateDigest(1);
			global::Org.BouncyCastle.Crypto.IDigest sha = this.m_crypto.CreateDigest(2);
			int md5Size = md5.GetDigestSize();
			int sha1Size = sha.GetDigestSize();
			byte[] tmp = new byte[global::System.Math.Max(md5Size, sha1Size)];
			byte[] result = new byte[length];
			int constLen = 1;
			int constPos = 0;
			int resultPos = 0;
			while (resultPos < length)
			{
				sha.BlockUpdate(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSecret.Ssl3Const, constPos, constLen);
				constPos += constLen++;
				sha.BlockUpdate(this.m_data, 0, this.m_data.Length);
				sha.BlockUpdate(seed, 0, seed.Length);
				sha.DoFinal(tmp, 0);
				md5.BlockUpdate(this.m_data, 0, this.m_data.Length);
				md5.BlockUpdate(tmp, 0, sha1Size);
				int remaining = length - resultPos;
				if (remaining < md5Size)
				{
					md5.DoFinal(tmp, 0);
					global::System.Array.Copy(tmp, 0, result, resultPos, remaining);
					resultPos += remaining;
				}
				else
				{
					md5.DoFinal(result, resultPos);
					resultPos += md5Size;
				}
			}
			return result;
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000369CC File Offset: 0x00034BCC
		protected virtual byte[] Prf_1_0(byte[] labelSeed, int length)
		{
			int s_half = (this.m_data.Length + 1) / 2;
			global::Org.BouncyCastle.Crypto.IDigest md5 = this.m_crypto.CreateDigest(1);
			byte[] b = new byte[length];
			this.HmacHash(md5, this.m_data, 0, s_half, labelSeed, b);
			global::Org.BouncyCastle.Crypto.IDigest sha = this.m_crypto.CreateDigest(2);
			byte[] b2 = new byte[length];
			this.HmacHash(sha, this.m_data, this.m_data.Length - s_half, s_half, labelSeed, b2);
			for (int i = 0; i < length; i++)
			{
				byte[] array = b;
				int num = i;
				array[num] ^= b2[i];
			}
			return b;
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00036A60 File Offset: 0x00034C60
		protected virtual byte[] Prf_1_2(int prfAlgorithm, byte[] labelSeed, int length)
		{
			global::Org.BouncyCastle.Crypto.IDigest digest = this.m_crypto.CreateDigest(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashForPrf(prfAlgorithm));
			byte[] result = new byte[length];
			this.HmacHash(digest, this.m_data, 0, this.m_data.Length, labelSeed, result);
			return result;
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00036AA0 File Offset: 0x00034CA0
		protected virtual void UpdateMac(global::Org.BouncyCastle.Crypto.IMac mac)
		{
			lock (this)
			{
				this.CheckAlive();
				mac.BlockUpdate(this.m_data, 0, this.m_data.Length);
			}
		}

		// Token: 0x04000835 RID: 2101
		private static readonly byte[] Ssl3Const = global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSecret.GenerateSsl3Constants();

		// Token: 0x04000836 RID: 2102
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto m_crypto;
	}
}
