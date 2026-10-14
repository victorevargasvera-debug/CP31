using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000DA RID: 218
	public sealed class OcspStatusRequest
	{
		// Token: 0x060007CE RID: 1998 RVA: 0x00020E78 File Offset: 0x0001F078
		public OcspStatusRequest(global::System.Collections.IList responderIDList, global::Org.BouncyCastle.Asn1.X509.X509Extensions requestExtensions)
		{
			this.m_responderIDList = responderIDList;
			this.m_requestExtensions = requestExtensions;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00020E8E File Offset: 0x0001F08E
		public global::System.Collections.IList ResponderIDList
		{
			get
			{
				return this.m_responderIDList;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00020E96 File Offset: 0x0001F096
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions RequestExtensions
		{
			get
			{
				return this.m_requestExtensions;
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00020EA0 File Offset: 0x0001F0A0
		public void Encode(global::System.IO.Stream output)
		{
			if (this.m_responderIDList == null || this.m_responderIDList.Count < 1)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(0, output);
			}
			else
			{
				global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
				foreach (object obj in this.m_responderIDList)
				{
					global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(((global::Org.BouncyCastle.Asn1.Ocsp.ResponderID)obj).GetEncoded("DER"), buf);
				}
				global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(buf.Length);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16((int)buf.Length, output);
				global::Org.BouncyCastle.Utilities.IO.Streams.WriteBufTo(buf, output);
			}
			if (this.m_requestExtensions == null)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(0, output);
				return;
			}
			byte[] derEncoding = this.m_requestExtensions.GetEncoded("DER");
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(derEncoding.Length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(derEncoding.Length, output);
			output.Write(derEncoding, 0, derEncoding.Length);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00020F84 File Offset: 0x0001F184
		public static global::Org.BouncyCastle.Tls.OcspStatusRequest Parse(global::System.IO.Stream input)
		{
			global::System.Collections.IList responderIDList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			byte[] data = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input);
			if (data.Length != 0)
			{
				global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(data, false);
				do
				{
					global::Org.BouncyCastle.Asn1.Ocsp.ResponderID responderID = global::Org.BouncyCastle.Asn1.Ocsp.ResponderID.GetInstance(global::Org.BouncyCastle.Tls.TlsUtilities.ReadDerObject(global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(buf, 1)));
					responderIDList.Add(responderID);
				}
				while (buf.Position < buf.Length);
			}
			global::Org.BouncyCastle.Asn1.X509.X509Extensions requestExtensions = null;
			byte[] derEncoding = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input);
			if (derEncoding.Length != 0)
			{
				requestExtensions = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(global::Org.BouncyCastle.Tls.TlsUtilities.ReadDerObject(derEncoding));
			}
			return new global::Org.BouncyCastle.Tls.OcspStatusRequest(responderIDList, requestExtensions);
		}

		// Token: 0x040005F8 RID: 1528
		private readonly global::System.Collections.IList m_responderIDList;

		// Token: 0x040005F9 RID: 1529
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Extensions m_requestExtensions;
	}
}
