using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006D0 RID: 1744
	public class ResponseData : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003FA2 RID: 16290 RVA: 0x00120C47 File Offset: 0x0011EE47
		public static global::Org.BouncyCastle.Asn1.Ocsp.ResponseData GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Ocsp.ResponseData.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x00120C58 File Offset: 0x0011EE58
		public static global::Org.BouncyCastle.Asn1.Ocsp.ResponseData GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Ocsp.ResponseData)
			{
				return (global::Org.BouncyCastle.Asn1.Ocsp.ResponseData)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.ResponseData((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x00120CA5 File Offset: 0x0011EEA5
		public ResponseData(global::Org.BouncyCastle.Asn1.DerInteger version, global::Org.BouncyCastle.Asn1.Ocsp.ResponderID responderID, global::Org.BouncyCastle.Asn1.DerGeneralizedTime producedAt, global::Org.BouncyCastle.Asn1.Asn1Sequence responses, global::Org.BouncyCastle.Asn1.X509.X509Extensions responseExtensions)
		{
			this.version = version;
			this.responderID = responderID;
			this.producedAt = producedAt;
			this.responses = responses;
			this.responseExtensions = responseExtensions;
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x00120CD2 File Offset: 0x0011EED2
		public ResponseData(global::Org.BouncyCastle.Asn1.Ocsp.ResponderID responderID, global::Org.BouncyCastle.Asn1.DerGeneralizedTime producedAt, global::Org.BouncyCastle.Asn1.Asn1Sequence responses, global::Org.BouncyCastle.Asn1.X509.X509Extensions responseExtensions) : this(global::Org.BouncyCastle.Asn1.Ocsp.ResponseData.V1, responderID, producedAt, responses, responseExtensions)
		{
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x00120CE4 File Offset: 0x0011EEE4
		private ResponseData(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int index = 0;
			global::Org.BouncyCastle.Asn1.Asn1Encodable enc = seq[0];
			if (enc is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)enc;
				if (o.TagNo == 0)
				{
					this.versionPresent = true;
					this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(o, true);
					index++;
				}
				else
				{
					this.version = global::Org.BouncyCastle.Asn1.Ocsp.ResponseData.V1;
				}
			}
			else
			{
				this.version = global::Org.BouncyCastle.Asn1.Ocsp.ResponseData.V1;
			}
			this.responderID = global::Org.BouncyCastle.Asn1.Ocsp.ResponderID.GetInstance(seq[index++]);
			this.producedAt = (global::Org.BouncyCastle.Asn1.DerGeneralizedTime)seq[index++];
			this.responses = (global::Org.BouncyCastle.Asn1.Asn1Sequence)seq[index++];
			if (seq.Count > index)
			{
				this.responseExtensions = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[index], true);
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06003FA7 RID: 16295 RVA: 0x00120DAD File Offset: 0x0011EFAD
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06003FA8 RID: 16296 RVA: 0x00120DB5 File Offset: 0x0011EFB5
		public global::Org.BouncyCastle.Asn1.Ocsp.ResponderID ResponderID
		{
			get
			{
				return this.responderID;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06003FA9 RID: 16297 RVA: 0x00120DBD File Offset: 0x0011EFBD
		public global::Org.BouncyCastle.Asn1.DerGeneralizedTime ProducedAt
		{
			get
			{
				return this.producedAt;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06003FAA RID: 16298 RVA: 0x00120DC5 File Offset: 0x0011EFC5
		public global::Org.BouncyCastle.Asn1.Asn1Sequence Responses
		{
			get
			{
				return this.responses;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06003FAB RID: 16299 RVA: 0x00120DCD File Offset: 0x0011EFCD
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions ResponseExtensions
		{
			get
			{
				return this.responseExtensions;
			}
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x00120DD8 File Offset: 0x0011EFD8
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			if (this.versionPresent || !this.version.Equals(global::Org.BouncyCastle.Asn1.Ocsp.ResponseData.V1))
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, this.version));
			}
			v.Add(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.responderID,
				this.producedAt,
				this.responses
			});
			v.AddOptionalTagged(true, 1, this.responseExtensions);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001D7A RID: 7546
		private static readonly global::Org.BouncyCastle.Asn1.DerInteger V1 = new global::Org.BouncyCastle.Asn1.DerInteger(0);

		// Token: 0x04001D7B RID: 7547
		private readonly bool versionPresent;

		// Token: 0x04001D7C RID: 7548
		private readonly global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001D7D RID: 7549
		private readonly global::Org.BouncyCastle.Asn1.Ocsp.ResponderID responderID;

		// Token: 0x04001D7E RID: 7550
		private readonly global::Org.BouncyCastle.Asn1.DerGeneralizedTime producedAt;

		// Token: 0x04001D7F RID: 7551
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence responses;

		// Token: 0x04001D80 RID: 7552
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Extensions responseExtensions;
	}
}
