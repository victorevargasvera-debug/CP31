using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001E1 RID: 481
	public class OcspResp
	{
		// Token: 0x060011D5 RID: 4565 RVA: 0x0004E992 File Offset: 0x0004CB92
		public OcspResp(global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse resp)
		{
			this.resp = resp;
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0004E9A1 File Offset: 0x0004CBA1
		public OcspResp(byte[] resp) : this(new global::Org.BouncyCastle.Asn1.Asn1InputStream(resp))
		{
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0004E9AF File Offset: 0x0004CBAF
		public OcspResp(global::System.IO.Stream inStr) : this(new global::Org.BouncyCastle.Asn1.Asn1InputStream(inStr))
		{
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0004E9C0 File Offset: 0x0004CBC0
		private OcspResp(global::Org.BouncyCastle.Asn1.Asn1InputStream aIn)
		{
			try
			{
				this.resp = global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse.GetInstance(aIn.ReadObject());
			}
			catch (global::System.Exception e)
			{
				throw new global::System.IO.IOException("malformed response: " + e.Message, e);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x0004EA10 File Offset: 0x0004CC10
		public int Status
		{
			get
			{
				return this.resp.ResponseStatus.IntValueExact;
			}
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0004EA24 File Offset: 0x0004CC24
		public object GetResponseObject()
		{
			global::Org.BouncyCastle.Asn1.Ocsp.ResponseBytes rb = this.resp.ResponseBytes;
			if (rb == null)
			{
				return null;
			}
			if (rb.ResponseType.Equals(global::Org.BouncyCastle.Asn1.Ocsp.OcspObjectIdentifiers.PkixOcspBasic))
			{
				try
				{
					return new global::Org.BouncyCastle.Ocsp.BasicOcspResp(global::Org.BouncyCastle.Asn1.Ocsp.BasicOcspResponse.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(rb.Response.GetOctets())));
				}
				catch (global::System.Exception e)
				{
					string str = "problem decoding object: ";
					global::System.Exception ex = e;
					throw new global::Org.BouncyCastle.Ocsp.OcspException(str + ((ex != null) ? ex.ToString() : null), e);
				}
			}
			return rb.Response;
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0004EAA8 File Offset: 0x0004CCA8
		public byte[] GetEncoded()
		{
			return this.resp.GetEncoded();
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0004EAB8 File Offset: 0x0004CCB8
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Ocsp.OcspResp other = obj as global::Org.BouncyCastle.Ocsp.OcspResp;
			return other != null && this.resp.Equals(other.resp);
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0004EAE8 File Offset: 0x0004CCE8
		public override int GetHashCode()
		{
			return this.resp.GetHashCode();
		}

		// Token: 0x040008EC RID: 2284
		private global::Org.BouncyCastle.Asn1.Ocsp.OcspResponse resp;
	}
}
