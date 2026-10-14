using System;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200077D RID: 1917
	public class PkiBody : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x0600443D RID: 17469 RVA: 0x0013055F File Offset: 0x0012E75F
		public static global::Org.BouncyCastle.Asn1.Cmp.PkiBody GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.PkiBody)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.PkiBody)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.PkiBody((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x0013059E File Offset: 0x0012E79E
		private PkiBody(global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged)
		{
			this.tagNo = tagged.TagNo;
			this.body = global::Org.BouncyCastle.Asn1.Cmp.PkiBody.GetBodyForType(this.tagNo, tagged.GetObject());
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x001305C9 File Offset: 0x0012E7C9
		public PkiBody(int type, global::Org.BouncyCastle.Asn1.Asn1Encodable content)
		{
			this.tagNo = type;
			this.body = global::Org.BouncyCastle.Asn1.Cmp.PkiBody.GetBodyForType(type, content);
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x001305E8 File Offset: 0x0012E7E8
		private static global::Org.BouncyCastle.Asn1.Asn1Encodable GetBodyForType(int type, global::Org.BouncyCastle.Asn1.Asn1Encodable o)
		{
			switch (type)
			{
			case 0:
				return global::Org.BouncyCastle.Asn1.Crmf.CertReqMessages.GetInstance(o);
			case 1:
				return global::Org.BouncyCastle.Asn1.Cmp.CertRepMessage.GetInstance(o);
			case 2:
				return global::Org.BouncyCastle.Asn1.Crmf.CertReqMessages.GetInstance(o);
			case 3:
				return global::Org.BouncyCastle.Asn1.Cmp.CertRepMessage.GetInstance(o);
			case 4:
				return global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequest.GetInstance(o);
			case 5:
				return global::Org.BouncyCastle.Asn1.Cmp.PopoDecKeyChallContent.GetInstance(o);
			case 6:
				return global::Org.BouncyCastle.Asn1.Cmp.PopoDecKeyRespContent.GetInstance(o);
			case 7:
				return global::Org.BouncyCastle.Asn1.Crmf.CertReqMessages.GetInstance(o);
			case 8:
				return global::Org.BouncyCastle.Asn1.Cmp.CertRepMessage.GetInstance(o);
			case 9:
				return global::Org.BouncyCastle.Asn1.Crmf.CertReqMessages.GetInstance(o);
			case 10:
				return global::Org.BouncyCastle.Asn1.Cmp.KeyRecRepContent.GetInstance(o);
			case 11:
				return global::Org.BouncyCastle.Asn1.Cmp.RevReqContent.GetInstance(o);
			case 12:
				return global::Org.BouncyCastle.Asn1.Cmp.RevRepContent.GetInstance(o);
			case 13:
				return global::Org.BouncyCastle.Asn1.Crmf.CertReqMessages.GetInstance(o);
			case 14:
				return global::Org.BouncyCastle.Asn1.Cmp.CertRepMessage.GetInstance(o);
			case 15:
				return global::Org.BouncyCastle.Asn1.Cmp.CAKeyUpdAnnContent.GetInstance(o);
			case 16:
				return global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate.GetInstance(o);
			case 17:
				return global::Org.BouncyCastle.Asn1.Cmp.RevAnnContent.GetInstance(o);
			case 18:
				return global::Org.BouncyCastle.Asn1.Cmp.CrlAnnContent.GetInstance(o);
			case 19:
				return global::Org.BouncyCastle.Asn1.Cmp.PkiConfirmContent.GetInstance(o);
			case 20:
				return global::Org.BouncyCastle.Asn1.Cmp.PkiMessages.GetInstance(o);
			case 21:
				return global::Org.BouncyCastle.Asn1.Cmp.GenMsgContent.GetInstance(o);
			case 22:
				return global::Org.BouncyCastle.Asn1.Cmp.GenRepContent.GetInstance(o);
			case 23:
				return global::Org.BouncyCastle.Asn1.Cmp.ErrorMsgContent.GetInstance(o);
			case 24:
				return global::Org.BouncyCastle.Asn1.Cmp.CertConfirmContent.GetInstance(o);
			case 25:
				return global::Org.BouncyCastle.Asn1.Cmp.PollReqContent.GetInstance(o);
			case 26:
				return global::Org.BouncyCastle.Asn1.Cmp.PollRepContent.GetInstance(o);
			default:
				throw new global::System.ArgumentException("unknown tag number: " + type.ToString(), "type");
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06004441 RID: 17473 RVA: 0x00130744 File Offset: 0x0012E944
		public virtual int Type
		{
			get
			{
				return this.tagNo;
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06004442 RID: 17474 RVA: 0x0013074C File Offset: 0x0012E94C
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable Content
		{
			get
			{
				return this.body;
			}
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x00130754 File Offset: 0x0012E954
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, this.tagNo, this.body);
		}

		// Token: 0x040020DC RID: 8412
		public const int TYPE_INIT_REQ = 0;

		// Token: 0x040020DD RID: 8413
		public const int TYPE_INIT_REP = 1;

		// Token: 0x040020DE RID: 8414
		public const int TYPE_CERT_REQ = 2;

		// Token: 0x040020DF RID: 8415
		public const int TYPE_CERT_REP = 3;

		// Token: 0x040020E0 RID: 8416
		public const int TYPE_P10_CERT_REQ = 4;

		// Token: 0x040020E1 RID: 8417
		public const int TYPE_POPO_CHALL = 5;

		// Token: 0x040020E2 RID: 8418
		public const int TYPE_POPO_REP = 6;

		// Token: 0x040020E3 RID: 8419
		public const int TYPE_KEY_UPDATE_REQ = 7;

		// Token: 0x040020E4 RID: 8420
		public const int TYPE_KEY_UPDATE_REP = 8;

		// Token: 0x040020E5 RID: 8421
		public const int TYPE_KEY_RECOVERY_REQ = 9;

		// Token: 0x040020E6 RID: 8422
		public const int TYPE_KEY_RECOVERY_REP = 10;

		// Token: 0x040020E7 RID: 8423
		public const int TYPE_REVOCATION_REQ = 11;

		// Token: 0x040020E8 RID: 8424
		public const int TYPE_REVOCATION_REP = 12;

		// Token: 0x040020E9 RID: 8425
		public const int TYPE_CROSS_CERT_REQ = 13;

		// Token: 0x040020EA RID: 8426
		public const int TYPE_CROSS_CERT_REP = 14;

		// Token: 0x040020EB RID: 8427
		public const int TYPE_CA_KEY_UPDATE_ANN = 15;

		// Token: 0x040020EC RID: 8428
		public const int TYPE_CERT_ANN = 16;

		// Token: 0x040020ED RID: 8429
		public const int TYPE_REVOCATION_ANN = 17;

		// Token: 0x040020EE RID: 8430
		public const int TYPE_CRL_ANN = 18;

		// Token: 0x040020EF RID: 8431
		public const int TYPE_CONFIRM = 19;

		// Token: 0x040020F0 RID: 8432
		public const int TYPE_NESTED = 20;

		// Token: 0x040020F1 RID: 8433
		public const int TYPE_GEN_MSG = 21;

		// Token: 0x040020F2 RID: 8434
		public const int TYPE_GEN_REP = 22;

		// Token: 0x040020F3 RID: 8435
		public const int TYPE_ERROR = 23;

		// Token: 0x040020F4 RID: 8436
		public const int TYPE_CERT_CONFIRM = 24;

		// Token: 0x040020F5 RID: 8437
		public const int TYPE_POLL_REQ = 25;

		// Token: 0x040020F6 RID: 8438
		public const int TYPE_POLL_REP = 26;

		// Token: 0x040020F7 RID: 8439
		private int tagNo;

		// Token: 0x040020F8 RID: 8440
		private global::Org.BouncyCastle.Asn1.Asn1Encodable body;
	}
}
