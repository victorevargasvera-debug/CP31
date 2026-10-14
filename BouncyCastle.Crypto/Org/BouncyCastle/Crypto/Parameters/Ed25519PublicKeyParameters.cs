using System;
using System.IO;
using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003DF RID: 991
	public sealed class Ed25519PublicKeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x060027B0 RID: 10160 RVA: 0x000AB708 File Offset: 0x000A9908
		public Ed25519PublicKeyParameters(byte[] buf) : this(global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters.Validate(buf), 0)
		{
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x000AB717 File Offset: 0x000A9917
		public Ed25519PublicKeyParameters(byte[] buf, int off)
		{
			this.data = new byte[global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters.KeySize];
			base..ctor(false);
			global::System.Array.Copy(buf, off, this.data, 0, global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters.KeySize);
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x000AB743 File Offset: 0x000A9943
		public Ed25519PublicKeyParameters(global::System.IO.Stream input)
		{
			this.data = new byte[global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters.KeySize];
			base..ctor(false);
			if (global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters.KeySize != global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, this.data))
			{
				throw new global::System.IO.EndOfStreamException("EOF encountered in middle of Ed25519 public key");
			}
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x000AB77A File Offset: 0x000A997A
		public void Encode(byte[] buf, int off)
		{
			global::System.Array.Copy(this.data, 0, buf, off, global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters.KeySize);
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x000AB78F File Offset: 0x000A998F
		public byte[] GetEncoded()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.data);
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x000AB79C File Offset: 0x000A999C
		private static byte[] Validate(byte[] buf)
		{
			if (buf.Length != global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters.KeySize)
			{
				throw new global::System.ArgumentException("must have length " + global::Org.BouncyCastle.Crypto.Parameters.Ed25519PublicKeyParameters.KeySize.ToString(), "buf");
			}
			return buf;
		}

		// Token: 0x04001013 RID: 4115
		public static readonly int KeySize = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.PublicKeySize;

		// Token: 0x04001014 RID: 4116
		private readonly byte[] data;
	}
}
