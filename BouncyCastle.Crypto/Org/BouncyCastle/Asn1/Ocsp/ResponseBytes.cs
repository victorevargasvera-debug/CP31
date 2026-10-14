using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006CF RID: 1743
	public class ResponseBytes : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F9B RID: 16283 RVA: 0x00120B3A File Offset: 0x0011ED3A
		public static global::Org.BouncyCastle.Asn1.Ocsp.ResponseBytes GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Ocsp.ResponseBytes.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x00120B48 File Offset: 0x0011ED48
		public static global::Org.BouncyCastle.Asn1.Ocsp.ResponseBytes GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Ocsp.ResponseBytes)
			{
				return (global::Org.BouncyCastle.Asn1.Ocsp.ResponseBytes)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.ResponseBytes((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x00120B95 File Offset: 0x0011ED95
		public ResponseBytes(global::Org.BouncyCastle.Asn1.DerObjectIdentifier responseType, global::Org.BouncyCastle.Asn1.Asn1OctetString response)
		{
			if (responseType == null)
			{
				throw new global::System.ArgumentNullException("responseType");
			}
			if (response == null)
			{
				throw new global::System.ArgumentNullException("response");
			}
			this.responseType = responseType;
			this.response = response;
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x00120BC8 File Offset: 0x0011EDC8
		private ResponseBytes(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.responseType = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
			this.response = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[1]);
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06003F9F RID: 16287 RVA: 0x00120C18 File Offset: 0x0011EE18
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier ResponseType
		{
			get
			{
				return this.responseType;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06003FA0 RID: 16288 RVA: 0x00120C20 File Offset: 0x0011EE20
		public global::Org.BouncyCastle.Asn1.Asn1OctetString Response
		{
			get
			{
				return this.response;
			}
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x00120C28 File Offset: 0x0011EE28
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.responseType,
				this.response
			});
		}

		// Token: 0x04001D78 RID: 7544
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier responseType;

		// Token: 0x04001D79 RID: 7545
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString response;
	}
}
