using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000335 RID: 821
	public class HeartbeatMessage
	{
		// Token: 0x0600222E RID: 8750 RVA: 0x00097664 File Offset: 0x00095864
		public HeartbeatMessage(byte type, byte[] payload, int paddingLength)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.HeartbeatMessageType.IsValid(type))
			{
				throw new global::System.ArgumentException("not a valid HeartbeatMessageType value", "type");
			}
			if (payload == null || payload.Length >= 65536)
			{
				throw new global::System.ArgumentException("must have length < 2^16", "payload");
			}
			if (paddingLength < 16)
			{
				throw new global::System.ArgumentException("must be at least 16", "paddingLength");
			}
			this.mType = type;
			this.mPayload = payload;
			this.mPaddingLength = paddingLength;
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x000976D8 File Offset: 0x000958D8
		public virtual void Encode(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(this.mType, output);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(this.mPayload.Length);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(this.mPayload.Length, output);
			output.Write(this.mPayload, 0, this.mPayload.Length);
			byte[] padding = new byte[this.mPaddingLength];
			context.NonceRandomGenerator.NextBytes(padding);
			output.Write(padding, 0, padding.Length);
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x00097744 File Offset: 0x00095944
		public static global::Org.BouncyCastle.Crypto.Tls.HeartbeatMessage Parse(global::System.IO.Stream input)
		{
			byte type = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input);
			if (!global::Org.BouncyCastle.Crypto.Tls.HeartbeatMessageType.IsValid(type))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			int payload_length = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input);
			global::Org.BouncyCastle.Crypto.Tls.HeartbeatMessage.PayloadBuffer buf = new global::Org.BouncyCastle.Crypto.Tls.HeartbeatMessage.PayloadBuffer();
			global::Org.BouncyCastle.Utilities.IO.Streams.PipeAll(input, buf);
			byte[] payload = buf.ToTruncatedByteArray(payload_length);
			if (payload == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(buf.Length);
			int padding_length = (int)buf.Length - payload.Length;
			return new global::Org.BouncyCastle.Crypto.Tls.HeartbeatMessage(type, payload, padding_length);
		}

		// Token: 0x04000D79 RID: 3449
		protected readonly byte mType;

		// Token: 0x04000D7A RID: 3450
		protected readonly byte[] mPayload;

		// Token: 0x04000D7B RID: 3451
		protected readonly int mPaddingLength;

		// Token: 0x020007FB RID: 2043
		internal class PayloadBuffer : global::System.IO.MemoryStream
		{
			// Token: 0x06004639 RID: 17977 RVA: 0x00136304 File Offset: 0x00134504
			internal byte[] ToTruncatedByteArray(int payloadLength)
			{
				int minimumCount = payloadLength + 16;
				if (this.Length < (long)minimumCount)
				{
					return null;
				}
				return global::Org.BouncyCastle.Utilities.Arrays.CopyOf(this.GetBuffer(), payloadLength);
			}
		}
	}
}
