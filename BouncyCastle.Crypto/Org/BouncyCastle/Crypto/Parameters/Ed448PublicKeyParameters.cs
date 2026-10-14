using System;
using System.IO;
using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003E2 RID: 994
	public sealed class Ed448PublicKeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x060027C3 RID: 10179 RVA: 0x000AB9FC File Offset: 0x000A9BFC
		public Ed448PublicKeyParameters(byte[] buf) : this(global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters.Validate(buf), 0)
		{
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x000ABA0B File Offset: 0x000A9C0B
		public Ed448PublicKeyParameters(byte[] buf, int off)
		{
			this.data = new byte[global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters.KeySize];
			base..ctor(false);
			global::System.Array.Copy(buf, off, this.data, 0, global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters.KeySize);
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x000ABA37 File Offset: 0x000A9C37
		public Ed448PublicKeyParameters(global::System.IO.Stream input)
		{
			this.data = new byte[global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters.KeySize];
			base..ctor(false);
			if (global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters.KeySize != global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, this.data))
			{
				throw new global::System.IO.EndOfStreamException("EOF encountered in middle of Ed448 public key");
			}
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x000ABA6E File Offset: 0x000A9C6E
		public void Encode(byte[] buf, int off)
		{
			global::System.Array.Copy(this.data, 0, buf, off, global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters.KeySize);
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x000ABA83 File Offset: 0x000A9C83
		public byte[] GetEncoded()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.data);
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x000ABA90 File Offset: 0x000A9C90
		private static byte[] Validate(byte[] buf)
		{
			if (buf.Length != global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters.KeySize)
			{
				throw new global::System.ArgumentException("must have length " + global::Org.BouncyCastle.Crypto.Parameters.Ed448PublicKeyParameters.KeySize.ToString(), "buf");
			}
			return buf;
		}

		// Token: 0x04001019 RID: 4121
		public static readonly int KeySize = global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.PublicKeySize;

		// Token: 0x0400101A RID: 4122
		private readonly byte[] data;
	}
}
