using System;
using System.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000D2 RID: 210
	public sealed class KeyShareEntry
	{
		// Token: 0x0600079B RID: 1947 RVA: 0x0002065A File Offset: 0x0001E85A
		private static bool CheckKeyExchangeLength(int length)
		{
			return 0 < length && length < 65536;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0002066C File Offset: 0x0001E86C
		public KeyShareEntry(int namedGroup, byte[] keyExchange)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint16(namedGroup))
			{
				throw new global::System.ArgumentException("should be a uint16", "namedGroup");
			}
			if (keyExchange == null)
			{
				throw new global::System.ArgumentNullException("keyExchange");
			}
			if (!global::Org.BouncyCastle.Tls.KeyShareEntry.CheckKeyExchangeLength(keyExchange.Length))
			{
				throw new global::System.ArgumentException("must have length from 1 to (2^16 - 1)", "keyExchange");
			}
			this.m_namedGroup = namedGroup;
			this.m_keyExchange = keyExchange;
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x000206CD File Offset: 0x0001E8CD
		public int NamedGroup
		{
			get
			{
				return this.m_namedGroup;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x000206D5 File Offset: 0x0001E8D5
		public byte[] KeyExchange
		{
			get
			{
				return this.m_keyExchange;
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000206DD File Offset: 0x0001E8DD
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(this.NamedGroup, output);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(this.KeyExchange, output);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000206F8 File Offset: 0x0001E8F8
		public static global::Org.BouncyCastle.Tls.KeyShareEntry Parse(global::System.IO.Stream input)
		{
			int namedGroup = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(input);
			byte[] keyExchange = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input, 1);
			return new global::Org.BouncyCastle.Tls.KeyShareEntry(namedGroup, keyExchange);
		}

		// Token: 0x040005B0 RID: 1456
		private readonly int m_namedGroup;

		// Token: 0x040005B1 RID: 1457
		private readonly byte[] m_keyExchange;
	}
}
