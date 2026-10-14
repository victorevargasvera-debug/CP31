using System;
using System.IO;
using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003E1 RID: 993
	public sealed class Ed448PrivateKeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x060027B8 RID: 10168 RVA: 0x000AB7F0 File Offset: 0x000A99F0
		public Ed448PrivateKeyParameters(global::Org.BouncyCastle.Security.SecureRandom random) : base(true)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.GeneratePrivateKey(random, this.data);
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x000AB815 File Offset: 0x000A9A15
		public Ed448PrivateKeyParameters(byte[] buf) : this(global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters.Validate(buf), 0)
		{
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x000AB824 File Offset: 0x000A9A24
		public Ed448PrivateKeyParameters(byte[] buf, int off) : base(true)
		{
			global::System.Array.Copy(buf, off, this.data, 0, global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters.KeySize);
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x000AB850 File Offset: 0x000A9A50
		public Ed448PrivateKeyParameters(global::System.IO.Stream input) : base(true)
		{
			if (global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters.KeySize != global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, this.data))
			{
				throw new global::System.IO.EndOfStreamException("EOF encountered in middle of Ed448 private key");
			}
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x000AB887 File Offset: 0x000A9A87
		public void Encode(byte[] buf, int off)
		{
			global::System.Array.Copy(this.data, 0, buf, off, global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters.KeySize);
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x000AB89C File Offset: 0x000A9A9C
		public byte[] GetEncoded()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.data);
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x000AB8AC File Offset: 0x000A9AAC
		public global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters GeneratePublicKey()
		{
			byte[] obj = this.data;
			global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters result;
			lock (obj)
			{
				if (this.cachedPublicKey == null)
				{
					byte[] publicKey = new byte[global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PublicKeySize];
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.GeneratePublicKey(this.data, 0, publicKey, 0);
					this.cachedPublicKey = new global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters(publicKey, 0);
				}
				result = this.cachedPublicKey;
			}
			return result;
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x000AB91C File Offset: 0x000A9B1C
		[global::System.Obsolete("Use overload that doesn't take a public key")]
		public void Sign(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Algorithm algorithm, global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters publicKey, byte[] ctx, byte[] msg, int msgOff, int msgLen, byte[] sig, int sigOff)
		{
			this.Sign(algorithm, ctx, msg, msgOff, msgLen, sig, sigOff);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x000AB930 File Offset: 0x000A9B30
		public void Sign(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Algorithm algorithm, byte[] ctx, byte[] msg, int msgOff, int msgLen, byte[] sig, int sigOff)
		{
			global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters ed448PublicKeyParameters = this.GeneratePublicKey();
			byte[] pk = new byte[global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PublicKeySize];
			ed448PublicKeyParameters.Encode(pk, 0);
			if (algorithm == global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Algorithm.Ed448)
			{
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Sign(this.data, 0, pk, 0, ctx, msg, msgOff, msgLen, sig, sigOff);
				return;
			}
			if (algorithm != global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Algorithm.Ed448ph)
			{
				throw new global::System.ArgumentException("algorithm");
			}
			if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PrehashSize != msgLen)
			{
				throw new global::System.ArgumentException("msgLen");
			}
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.SignPrehash(this.data, 0, pk, 0, ctx, msg, msgOff, sig, sigOff);
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x000AB9AC File Offset: 0x000A9BAC
		private static byte[] Validate(byte[] buf)
		{
			if (buf.Length != global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters.KeySize)
			{
				throw new global::System.ArgumentException("must have length " + global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters.KeySize.ToString(), "buf");
			}
			return buf;
		}

		// Token: 0x04001015 RID: 4117
		public static readonly int KeySize = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.SecretKeySize;

		// Token: 0x04001016 RID: 4118
		public static readonly int SignatureSize = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.SignatureSize;

		// Token: 0x04001017 RID: 4119
		private readonly byte[] data = new byte[global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters.KeySize];

		// Token: 0x04001018 RID: 4120
		private global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters cachedPublicKey;
	}
}
