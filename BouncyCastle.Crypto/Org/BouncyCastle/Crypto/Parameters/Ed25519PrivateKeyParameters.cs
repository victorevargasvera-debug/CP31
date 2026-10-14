using System;
using System.IO;
using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003DE RID: 990
	public sealed class Ed25519PrivateKeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x060027A5 RID: 10149 RVA: 0x000AB4CA File Offset: 0x000A96CA
		public Ed25519PrivateKeyParameters(global::Org.BouncyCastle.Security.SecureRandom random) : base(true)
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.GeneratePrivateKey(random, this.data);
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x000AB4EF File Offset: 0x000A96EF
		public Ed25519PrivateKeyParameters(byte[] buf) : this(global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters.Validate(buf), 0)
		{
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x000AB4FE File Offset: 0x000A96FE
		public Ed25519PrivateKeyParameters(byte[] buf, int off) : base(true)
		{
			global::System.Array.Copy(buf, off, this.data, 0, global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters.KeySize);
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x000AB52A File Offset: 0x000A972A
		public Ed25519PrivateKeyParameters(global::System.IO.Stream input) : base(true)
		{
			if (global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters.KeySize != global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, this.data))
			{
				throw new global::System.IO.EndOfStreamException("EOF encountered in middle of Ed25519 private key");
			}
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000AB561 File Offset: 0x000A9761
		public void Encode(byte[] buf, int off)
		{
			global::System.Array.Copy(this.data, 0, buf, off, global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters.KeySize);
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x000AB576 File Offset: 0x000A9776
		public byte[] GetEncoded()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.data);
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x000AB584 File Offset: 0x000A9784
		public global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters GeneratePublicKey()
		{
			byte[] obj = this.data;
			global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters result;
			lock (obj)
			{
				if (this.cachedPublicKey == null)
				{
					byte[] publicKey = new byte[global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PublicKeySize];
					global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.GeneratePublicKey(this.data, 0, publicKey, 0);
					this.cachedPublicKey = new global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters(publicKey, 0);
				}
				result = this.cachedPublicKey;
			}
			return result;
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x000AB5F4 File Offset: 0x000A97F4
		[global::System.Obsolete("Use overload that doesn't take a public key")]
		public void Sign(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Algorithm algorithm, global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters publicKey, byte[] ctx, byte[] msg, int msgOff, int msgLen, byte[] sig, int sigOff)
		{
			this.Sign(algorithm, ctx, msg, msgOff, msgLen, sig, sigOff);
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x000AB608 File Offset: 0x000A9808
		public void Sign(global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Algorithm algorithm, byte[] ctx, byte[] msg, int msgOff, int msgLen, byte[] sig, int sigOff)
		{
			global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters ed25519PublicKeyParameters = this.GeneratePublicKey();
			byte[] pk = new byte[global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PublicKeySize];
			ed25519PublicKeyParameters.Encode(pk, 0);
			switch (algorithm)
			{
			case global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Algorithm.Ed25519:
				if (ctx != null)
				{
					throw new global::System.ArgumentException("ctx");
				}
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Sign(this.data, 0, pk, 0, msg, msgOff, msgLen, sig, sigOff);
				return;
			case global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Algorithm.Ed25519ctx:
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Sign(this.data, 0, pk, 0, ctx, msg, msgOff, msgLen, sig, sigOff);
				return;
			case global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Algorithm.Ed25519ph:
				if (global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PrehashSize != msgLen)
				{
					throw new global::System.ArgumentException("msgLen");
				}
				global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.SignPrehash(this.data, 0, pk, 0, ctx, msg, msgOff, sig, sigOff);
				return;
			default:
				throw new global::System.ArgumentException("algorithm");
			}
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x000AB6B8 File Offset: 0x000A98B8
		private static byte[] Validate(byte[] buf)
		{
			if (buf.Length != global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters.KeySize)
			{
				throw new global::System.ArgumentException("must have length " + global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters.KeySize.ToString(), "buf");
			}
			return buf;
		}

		// Token: 0x0400100F RID: 4111
		public static readonly int KeySize = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.SecretKeySize;

		// Token: 0x04001010 RID: 4112
		public static readonly int SignatureSize = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.SignatureSize;

		// Token: 0x04001011 RID: 4113
		private readonly byte[] data = new byte[global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters.KeySize];

		// Token: 0x04001012 RID: 4114
		private global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters cachedPublicKey;
	}
}
