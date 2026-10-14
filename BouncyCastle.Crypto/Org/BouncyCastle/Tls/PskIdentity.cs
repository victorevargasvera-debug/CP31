using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000DF RID: 223
	public sealed class PskIdentity
	{
		// Token: 0x0600080C RID: 2060 RVA: 0x00021D68 File Offset: 0x0001FF68
		public PskIdentity(byte[] identity, long obfuscatedTicketAge)
		{
			if (identity == null)
			{
				throw new global::System.ArgumentNullException("identity");
			}
			if (identity.Length < 1 || !global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint16(identity.Length))
			{
				throw new global::System.ArgumentException("should have length from 1 to 65535", "identity");
			}
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint32(obfuscatedTicketAge))
			{
				throw new global::System.ArgumentException("should be a uint32", "obfuscatedTicketAge");
			}
			this.m_identity = identity;
			this.m_obfuscatedTicketAge = obfuscatedTicketAge;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00021DCF File Offset: 0x0001FFCF
		public int GetEncodedLength()
		{
			return 6 + this.m_identity.Length;
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00021DDB File Offset: 0x0001FFDB
		public byte[] Identity
		{
			get
			{
				return this.m_identity;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00021DE3 File Offset: 0x0001FFE3
		public long ObfuscatedTicketAge
		{
			get
			{
				return this.m_obfuscatedTicketAge;
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00021DEB File Offset: 0x0001FFEB
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(this.Identity, output);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint32(this.ObfuscatedTicketAge, output);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00021E08 File Offset: 0x00020008
		public static global::Org.BouncyCastle.Tls.PskIdentity Parse(global::System.IO.Stream input)
		{
			byte[] identity = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input, 1);
			long obfuscatedTicketAge = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint32(input);
			return new global::Org.BouncyCastle.Tls.PskIdentity(identity, obfuscatedTicketAge);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00021E2C File Offset: 0x0002002C
		public override bool Equals(object obj)
		{
			global::Org.BouncyCastle.Tls.PskIdentity that = obj as global::Org.BouncyCastle.Tls.PskIdentity;
			return that != null && this.m_obfuscatedTicketAge == that.m_obfuscatedTicketAge && global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(this.m_identity, that.m_identity);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00021E68 File Offset: 0x00020068
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.m_identity) ^ this.m_obfuscatedTicketAge.GetHashCode();
		}

		// Token: 0x04000627 RID: 1575
		private readonly byte[] m_identity;

		// Token: 0x04000628 RID: 1576
		private readonly long m_obfuscatedTicketAge;
	}
}
