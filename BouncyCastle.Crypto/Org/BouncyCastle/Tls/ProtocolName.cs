using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000DD RID: 221
	public sealed class ProtocolName
	{
		// Token: 0x060007E0 RID: 2016 RVA: 0x0002145A File Offset: 0x0001F65A
		public static global::Org.BouncyCastle.Tls.ProtocolName AsRawBytes(byte[] bytes)
		{
			return new global::Org.BouncyCastle.Tls.ProtocolName(global::Org.BouncyCastle.Utilities.Arrays.Clone(bytes));
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00021467 File Offset: 0x0001F667
		public static global::Org.BouncyCastle.Tls.ProtocolName AsUtf8Encoding(string name)
		{
			return new global::Org.BouncyCastle.Tls.ProtocolName(global::Org.BouncyCastle.Utilities.Strings.ToUtf8ByteArray(name));
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00021474 File Offset: 0x0001F674
		private ProtocolName(byte[] bytes)
		{
			if (bytes == null)
			{
				throw new global::System.ArgumentNullException("bytes");
			}
			if (bytes.Length < 1 || bytes.Length > 255)
			{
				throw new global::System.ArgumentException("must have length from 1 to 255", "bytes");
			}
			this.m_bytes = bytes;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x000214B1 File Offset: 0x0001F6B1
		public byte[] GetBytes()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.m_bytes);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x000214BE File Offset: 0x0001F6BE
		public string GetUtf8Decoding()
		{
			return global::Org.BouncyCastle.Utilities.Strings.FromUtf8ByteArray(this.m_bytes);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x000214CB File Offset: 0x0001F6CB
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(this.m_bytes, output);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000214D9 File Offset: 0x0001F6D9
		public static global::Org.BouncyCastle.Tls.ProtocolName Parse(global::System.IO.Stream input)
		{
			return new global::Org.BouncyCastle.Tls.ProtocolName(global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(input, 1));
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000214E7 File Offset: 0x0001F6E7
		public override bool Equals(object obj)
		{
			return obj is global::Org.BouncyCastle.Tls.ProtocolName && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.m_bytes, ((global::Org.BouncyCastle.Tls.ProtocolName)obj).m_bytes);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00021509 File Offset: 0x0001F709
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.m_bytes);
		}

		// Token: 0x04000604 RID: 1540
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName Http_1_1 = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("http/1.1");

		// Token: 0x04000605 RID: 1541
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName Spdy_1 = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("spdy/1");

		// Token: 0x04000606 RID: 1542
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName Spdy_2 = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("spdy/2");

		// Token: 0x04000607 RID: 1543
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName Spdy_3 = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("spdy/3");

		// Token: 0x04000608 RID: 1544
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName Stun_Turn = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("stun.turn");

		// Token: 0x04000609 RID: 1545
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName Stun_Nat_Discovery = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("stun.nat-discovery");

		// Token: 0x0400060A RID: 1546
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName Http_2_Tls = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("h2");

		// Token: 0x0400060B RID: 1547
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName Http_2_Tcp = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("h2c");

		// Token: 0x0400060C RID: 1548
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName WebRtc = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("webrtc");

		// Token: 0x0400060D RID: 1549
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName WebRtc_Confidential = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("c-webrtc");

		// Token: 0x0400060E RID: 1550
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName Ftp = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("ftp");

		// Token: 0x0400060F RID: 1551
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName Imap = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("imap");

		// Token: 0x04000610 RID: 1552
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName Pop3 = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("pop3");

		// Token: 0x04000611 RID: 1553
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName ManageSieve = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("managesieve");

		// Token: 0x04000612 RID: 1554
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName Coap = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("coap");

		// Token: 0x04000613 RID: 1555
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName Xmpp_Client = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("xmpp-client");

		// Token: 0x04000614 RID: 1556
		public static readonly global::Org.BouncyCastle.Tls.ProtocolName Xmpp_Server = global::Org.BouncyCastle.Tls.ProtocolName.AsUtf8Encoding("xmpp-server");

		// Token: 0x04000615 RID: 1557
		private readonly byte[] m_bytes;
	}
}
