using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200033E RID: 830
	public class OcspStatusRequest
	{
		// Token: 0x06002243 RID: 8771 RVA: 0x000978A8 File Offset: 0x00095AA8
		public OcspStatusRequest(global::System.Collections.IList responderIDList, global::Org.BouncyCastle.Asn1.X509.X509Extensions requestExtensions)
		{
			this.mResponderIDList = responderIDList;
			this.mRequestExtensions = requestExtensions;
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x000978BE File Offset: 0x00095ABE
		public virtual global::System.Collections.IList ResponderIDList
		{
			get
			{
				return this.mResponderIDList;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x000978C6 File Offset: 0x00095AC6
		public virtual global::Org.BouncyCastle.Asn1.X509.X509Extensions RequestExtensions
		{
			get
			{
				return this.mRequestExtensions;
			}
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x000978D0 File Offset: 0x00095AD0
		public virtual void Encode(global::System.IO.Stream output)
		{
			if (this.mResponderIDList == null || this.mResponderIDList.Count < 1)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(0, output);
			}
			else
			{
				global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
				for (int i = 0; i < this.mResponderIDList.Count; i++)
				{
					global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(((global::Org.BouncyCastle.Asn1.Ocsp.ResponderID)this.mResponderIDList[i]).GetEncoded("DER"), buf);
				}
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(buf.Length);
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16((int)buf.Length, output);
				global::Org.BouncyCastle.Utilities.IO.Streams.WriteBufTo(buf, output);
			}
			if (this.mRequestExtensions == null)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(0, output);
				return;
			}
			byte[] derEncoding = this.mRequestExtensions.GetEncoded("DER");
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(derEncoding.Length);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(derEncoding.Length, output);
			output.Write(derEncoding, 0, derEncoding.Length);
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x00097998 File Offset: 0x00095B98
		public static global::Org.BouncyCastle.Crypto.Tls.OcspStatusRequest Parse(global::System.IO.Stream input)
		{
			global::System.Collections.IList responderIDList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			int length = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input);
			if (length > 0)
			{
				global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(length, input), false);
				do
				{
					global::Org.BouncyCastle.Asn1.Ocsp.ResponderID responderID = global::Org.BouncyCastle.Asn1.Ocsp.ResponderID.GetInstance(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadDerObject(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(buf)));
					responderIDList.Add(responderID);
				}
				while (buf.Position < buf.Length);
			}
			global::Org.BouncyCastle.Asn1.X509.X509Extensions requestExtensions = null;
			int length2 = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input);
			if (length2 > 0)
			{
				requestExtensions = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadDerObject(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(length2, input)));
			}
			return new global::Org.BouncyCastle.Crypto.Tls.OcspStatusRequest(responderIDList, requestExtensions);
		}

		// Token: 0x04000DC6 RID: 3526
		protected readonly global::System.Collections.IList mResponderIDList;

		// Token: 0x04000DC7 RID: 3527
		protected readonly global::Org.BouncyCastle.Asn1.X509.X509Extensions mRequestExtensions;
	}
}
