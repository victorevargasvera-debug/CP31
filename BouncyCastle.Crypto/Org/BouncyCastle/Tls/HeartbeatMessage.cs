using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000CD RID: 205
	public sealed class HeartbeatMessage
	{
		// Token: 0x06000785 RID: 1925 RVA: 0x000203AB File Offset: 0x0001E5AB
		public static global::Org.BouncyCastle.Tls.HeartbeatMessage Create(global::Org.BouncyCastle.Tls.TlsContext context, short type, byte[] payload)
		{
			return global::Org.BouncyCastle.Tls.HeartbeatMessage.Create(context, type, payload, 16);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000203B8 File Offset: 0x0001E5B8
		public static global::Org.BouncyCastle.Tls.HeartbeatMessage Create(global::Org.BouncyCastle.Tls.TlsContext context, short type, byte[] payload, int paddingLength)
		{
			byte[] padding = context.NonceGenerator.GenerateNonce(paddingLength);
			return new global::Org.BouncyCastle.Tls.HeartbeatMessage(type, payload, padding);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x000203DC File Offset: 0x0001E5DC
		public HeartbeatMessage(short type, byte[] payload, byte[] padding)
		{
			if (!global::Org.BouncyCastle.Tls.HeartbeatMessageType.IsValid(type))
			{
				throw new global::System.ArgumentException("not a valid HeartbeatMessageType value", "type");
			}
			if (payload == null || payload.Length >= 65536)
			{
				throw new global::System.ArgumentException("must have length < 2^16", "payload");
			}
			if (padding == null || padding.Length < 16)
			{
				throw new global::System.ArgumentException("must have length >= 16", "padding");
			}
			this.m_type = type;
			this.m_payload = payload;
			this.m_padding = padding;
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00020453 File Offset: 0x0001E653
		public int PaddingLength
		{
			get
			{
				return this.m_padding.Length;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x0002045D File Offset: 0x0001E65D
		public byte[] Payload
		{
			get
			{
				return this.m_payload;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00020465 File Offset: 0x0001E665
		public short Type
		{
			get
			{
				return this.m_type;
			}
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00020470 File Offset: 0x0001E670
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(this.m_type, output);
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(this.m_payload.Length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(this.m_payload.Length, output);
			output.Write(this.m_payload, 0, this.m_payload.Length);
			output.Write(this.m_padding, 0, this.m_padding.Length);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x000204D0 File Offset: 0x0001E6D0
		public static global::Org.BouncyCastle.Tls.HeartbeatMessage Parse(global::System.IO.Stream input)
		{
			short type = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			if (!global::Org.BouncyCastle.Tls.HeartbeatMessageType.IsValid(type))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			int payload_length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(input);
			byte[] payloadBuffer = global::Org.BouncyCastle.Utilities.IO.Streams.ReadAll(input);
			byte[] payload = global::Org.BouncyCastle.Tls.HeartbeatMessage.GetPayload(payloadBuffer, payload_length);
			if (payload == null)
			{
				return null;
			}
			byte[] padding = global::Org.BouncyCastle.Tls.HeartbeatMessage.GetPadding(payloadBuffer, payload_length);
			return new global::Org.BouncyCastle.Tls.HeartbeatMessage(type, payload, padding);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00020524 File Offset: 0x0001E724
		private static byte[] GetPayload(byte[] payloadBuffer, int payloadLength)
		{
			int maxPayloadLength = payloadBuffer.Length - 16;
			if (payloadLength > maxPayloadLength)
			{
				return null;
			}
			return global::Org.BouncyCastle.Utilities.Arrays.CopyOf(payloadBuffer, payloadLength);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00020545 File Offset: 0x0001E745
		private static byte[] GetPadding(byte[] payloadBuffer, int payloadLength)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.CopyOfRangeExact(payloadBuffer, payloadLength, payloadBuffer.Length);
		}

		// Token: 0x0400058B RID: 1419
		private readonly short m_type;

		// Token: 0x0400058C RID: 1420
		private readonly byte[] m_payload;

		// Token: 0x0400058D RID: 1421
		private readonly byte[] m_padding;
	}
}
