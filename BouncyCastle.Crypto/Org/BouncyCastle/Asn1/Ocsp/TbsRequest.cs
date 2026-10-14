using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006D5 RID: 1749
	public class TbsRequest : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003FD2 RID: 16338 RVA: 0x00121388 File Offset: 0x0011F588
		public static global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x00121398 File Offset: 0x0011F598
		public static global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest)
			{
				return (global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003FD4 RID: 16340 RVA: 0x001213E5 File Offset: 0x0011F5E5
		public TbsRequest(global::Org.BouncyCastle.Asn1.X509.GeneralName requestorName, global::Org.BouncyCastle.Asn1.Asn1Sequence requestList, global::Org.BouncyCastle.Asn1.X509.X509Extensions requestExtensions)
		{
			this.version = global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest.V1;
			this.requestorName = requestorName;
			this.requestList = requestList;
			this.requestExtensions = requestExtensions;
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x00121410 File Offset: 0x0011F610
		private TbsRequest(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int index = 0;
			global::Org.BouncyCastle.Asn1.Asn1Encodable enc = seq[0];
			if (enc is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)enc;
				if (o.TagNo == 0)
				{
					this.versionSet = true;
					this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(o, true);
					index++;
				}
				else
				{
					this.version = global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest.V1;
				}
			}
			else
			{
				this.version = global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest.V1;
			}
			if (seq[index] is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.requestorName = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[index++], true);
			}
			this.requestList = (global::Org.BouncyCastle.Asn1.Asn1Sequence)seq[index++];
			if (seq.Count == index + 1)
			{
				this.requestExtensions = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[index], true);
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06003FD6 RID: 16342 RVA: 0x001214D9 File Offset: 0x0011F6D9
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06003FD7 RID: 16343 RVA: 0x001214E1 File Offset: 0x0011F6E1
		public global::Org.BouncyCastle.Asn1.X509.GeneralName RequestorName
		{
			get
			{
				return this.requestorName;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06003FD8 RID: 16344 RVA: 0x001214E9 File Offset: 0x0011F6E9
		public global::Org.BouncyCastle.Asn1.Asn1Sequence RequestList
		{
			get
			{
				return this.requestList;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06003FD9 RID: 16345 RVA: 0x001214F1 File Offset: 0x0011F6F1
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions RequestExtensions
		{
			get
			{
				return this.requestExtensions;
			}
		}

		// Token: 0x06003FDA RID: 16346 RVA: 0x001214FC File Offset: 0x0011F6FC
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			if (!this.version.Equals(global::Org.BouncyCastle.Asn1.Ocsp.TbsRequest.V1) || this.versionSet)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, this.version));
			}
			v.AddOptionalTagged(true, 1, this.requestorName);
			v.Add(this.requestList);
			v.AddOptionalTagged(true, 2, this.requestExtensions);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001D8D RID: 7565
		private static readonly global::Org.BouncyCastle.Asn1.DerInteger V1 = new global::Org.BouncyCastle.Asn1.DerInteger(0);

		// Token: 0x04001D8E RID: 7566
		private readonly global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001D8F RID: 7567
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName requestorName;

		// Token: 0x04001D90 RID: 7568
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence requestList;

		// Token: 0x04001D91 RID: 7569
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Extensions requestExtensions;

		// Token: 0x04001D92 RID: 7570
		private bool versionSet;
	}
}
