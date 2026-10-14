using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000C2 RID: 194
	public class DtlsVerifier
	{
		// Token: 0x06000761 RID: 1889 RVA: 0x0001FADC File Offset: 0x0001DCDC
		private static global::Org.BouncyCastle.Tls.Crypto.TlsMac CreateCookieMac(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsHmac tlsHmac = crypto.CreateHmac(3);
			byte[] secret = new byte[tlsHmac.MacLength];
			crypto.SecureRandom.NextBytes(secret);
			tlsHmac.SetKey(secret, 0, secret.Length);
			return tlsHmac;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0001FB13 File Offset: 0x0001DD13
		public DtlsVerifier(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto)
		{
			this.m_cookieMac = global::Org.BouncyCastle.Tls.DtlsVerifier.CreateCookieMac(crypto);
			this.m_cookieMacSink = new global::Org.BouncyCastle.Tls.Crypto.TlsMacSink(this.m_cookieMac);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0001FB38 File Offset: 0x0001DD38
		public virtual global::Org.BouncyCastle.Tls.DtlsRequest VerifyRequest(byte[] clientID, byte[] data, int dataOff, int dataLen, global::Org.BouncyCastle.Tls.DatagramSender sender)
		{
			global::Org.BouncyCastle.Tls.DtlsRequest result;
			lock (this)
			{
				bool resetCookieMac = true;
				try
				{
					this.m_cookieMac.Update(clientID, 0, clientID.Length);
					global::Org.BouncyCastle.Tls.DtlsRequest request = global::Org.BouncyCastle.Tls.DtlsReliableHandshake.ReadClientRequest(data, dataOff, dataLen, this.m_cookieMacSink);
					if (request != null)
					{
						byte[] expectedCookie = this.m_cookieMac.CalculateMac();
						resetCookieMac = false;
						if (global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(expectedCookie, request.ClientHello.Cookie))
						{
							return request;
						}
						global::Org.BouncyCastle.Tls.DtlsReliableHandshake.SendHelloVerifyRequest(sender, request.RecordSeq, expectedCookie);
					}
				}
				catch (global::System.IO.IOException)
				{
				}
				finally
				{
					if (resetCookieMac)
					{
						this.m_cookieMac.Reset();
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x04000517 RID: 1303
		private readonly global::Org.BouncyCastle.Tls.Crypto.TlsMac m_cookieMac;

		// Token: 0x04000518 RID: 1304
		private readonly global::Org.BouncyCastle.Tls.Crypto.TlsMacSink m_cookieMacSink;
	}
}
