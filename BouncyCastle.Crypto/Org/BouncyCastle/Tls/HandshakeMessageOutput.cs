using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000C9 RID: 201
	internal sealed class HandshakeMessageOutput : global::System.IO.MemoryStream
	{
		// Token: 0x06000770 RID: 1904 RVA: 0x0001FF8E File Offset: 0x0001E18E
		internal static int GetLength(int bodyLength)
		{
			return 4 + bodyLength;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0001FF93 File Offset: 0x0001E193
		internal static void Send(global::Org.BouncyCastle.Tls.TlsProtocol protocol, short handshakeType, byte[] body)
		{
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput handshakeMessageOutput = new global::Org.BouncyCastle.Tls.HandshakeMessageOutput(handshakeType, body.Length);
			handshakeMessageOutput.Write(body, 0, body.Length);
			handshakeMessageOutput.Send(protocol);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0001FFAF File Offset: 0x0001E1AF
		internal HandshakeMessageOutput(short handshakeType) : this(handshakeType, 60)
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0001FFBA File Offset: 0x0001E1BA
		internal HandshakeMessageOutput(short handshakeType, int bodyLength) : base(global::Org.BouncyCastle.Tls.HandshakeMessageOutput.GetLength(bodyLength))
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint8(handshakeType);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(handshakeType, this);
			this.Seek(3L, global::System.IO.SeekOrigin.Current);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0001FFE0 File Offset: 0x0001E1E0
		internal void Send(global::Org.BouncyCastle.Tls.TlsProtocol protocol)
		{
			int i = (int)this.Length - 4;
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint24(i);
			this.Seek(1L, global::System.IO.SeekOrigin.Begin);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(i, this);
			byte[] buf = this.GetBuffer();
			int count = (int)this.Length;
			protocol.WriteHandshakeMessage(buf, 0, count);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0002002C File Offset: 0x0001E22C
		internal void PrepareClientHello(global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash, int bindersSize)
		{
			int i = (int)this.Length - 4 + bindersSize;
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint24(i);
			this.Seek(1L, global::System.IO.SeekOrigin.Begin);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(i, this);
			byte[] buf = this.GetBuffer();
			int count = (int)this.Length;
			handshakeHash.Update(buf, 0, count);
			this.Seek(0L, global::System.IO.SeekOrigin.End);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0002007C File Offset: 0x0001E27C
		internal void SendClientHello(global::Org.BouncyCastle.Tls.TlsClientProtocol clientProtocol, global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash, int bindersSize)
		{
			byte[] buf = this.GetBuffer();
			int count = (int)this.Length;
			if (bindersSize > 0)
			{
				handshakeHash.Update(buf, count - bindersSize, bindersSize);
			}
			clientProtocol.WriteHandshakeMessage(buf, 0, count);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this);
		}
	}
}
