using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000781 RID: 1921
	public class PkiHeader : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004453 RID: 17491 RVA: 0x00130904 File Offset: 0x0012EB04
		private PkiHeader(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.pvno = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			this.sender = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(seq[1]);
			this.recipient = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(seq[2]);
			for (int pos = 3; pos < seq.Count; pos++)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tObj = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[pos];
				switch (tObj.TagNo)
				{
				case 0:
					this.messageTime = global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(tObj, true);
					break;
				case 1:
					this.protectionAlg = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(tObj, true);
					break;
				case 2:
					this.senderKID = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(tObj, true);
					break;
				case 3:
					this.recipKID = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(tObj, true);
					break;
				case 4:
					this.transactionID = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(tObj, true);
					break;
				case 5:
					this.senderNonce = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(tObj, true);
					break;
				case 6:
					this.recipNonce = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(tObj, true);
					break;
				case 7:
					this.freeText = global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText.GetInstance(tObj, true);
					break;
				case 8:
					this.generalInfo = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(tObj, true);
					break;
				default:
					throw new global::System.ArgumentException("unknown tag number: " + tObj.TagNo.ToString(), "seq");
				}
			}
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x00130A57 File Offset: 0x0012EC57
		public static global::Org.BouncyCastle.Asn1.Cmp.PkiHeader GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.PkiHeader)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.PkiHeader)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.PkiHeader((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x00130A96 File Offset: 0x0012EC96
		public PkiHeader(int pvno, global::Org.BouncyCastle.Asn1.X509.GeneralName sender, global::Org.BouncyCastle.Asn1.X509.GeneralName recipient) : this(new global::Org.BouncyCastle.Asn1.DerInteger(pvno), sender, recipient)
		{
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x00130AA6 File Offset: 0x0012ECA6
		private PkiHeader(global::Org.BouncyCastle.Asn1.DerInteger pvno, global::Org.BouncyCastle.Asn1.X509.GeneralName sender, global::Org.BouncyCastle.Asn1.X509.GeneralName recipient)
		{
			this.pvno = pvno;
			this.sender = sender;
			this.recipient = recipient;
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06004457 RID: 17495 RVA: 0x00130AC3 File Offset: 0x0012ECC3
		public virtual global::Org.BouncyCastle.Asn1.DerInteger Pvno
		{
			get
			{
				return this.pvno;
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06004458 RID: 17496 RVA: 0x00130ACB File Offset: 0x0012ECCB
		public virtual global::Org.BouncyCastle.Asn1.X509.GeneralName Sender
		{
			get
			{
				return this.sender;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06004459 RID: 17497 RVA: 0x00130AD3 File Offset: 0x0012ECD3
		public virtual global::Org.BouncyCastle.Asn1.X509.GeneralName Recipient
		{
			get
			{
				return this.recipient;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x0600445A RID: 17498 RVA: 0x00130ADB File Offset: 0x0012ECDB
		public virtual global::Org.BouncyCastle.Asn1.DerGeneralizedTime MessageTime
		{
			get
			{
				return this.messageTime;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x0600445B RID: 17499 RVA: 0x00130AE3 File Offset: 0x0012ECE3
		public virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier ProtectionAlg
		{
			get
			{
				return this.protectionAlg;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x0600445C RID: 17500 RVA: 0x00130AEB File Offset: 0x0012ECEB
		public virtual global::Org.BouncyCastle.Asn1.Asn1OctetString SenderKID
		{
			get
			{
				return this.senderKID;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x0600445D RID: 17501 RVA: 0x00130AF3 File Offset: 0x0012ECF3
		public virtual global::Org.BouncyCastle.Asn1.Asn1OctetString RecipKID
		{
			get
			{
				return this.recipKID;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x0600445E RID: 17502 RVA: 0x00130AFB File Offset: 0x0012ECFB
		public virtual global::Org.BouncyCastle.Asn1.Asn1OctetString TransactionID
		{
			get
			{
				return this.transactionID;
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x00130B03 File Offset: 0x0012ED03
		public virtual global::Org.BouncyCastle.Asn1.Asn1OctetString SenderNonce
		{
			get
			{
				return this.senderNonce;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06004460 RID: 17504 RVA: 0x00130B0B File Offset: 0x0012ED0B
		public virtual global::Org.BouncyCastle.Asn1.Asn1OctetString RecipNonce
		{
			get
			{
				return this.recipNonce;
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06004461 RID: 17505 RVA: 0x00130B13 File Offset: 0x0012ED13
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText FreeText
		{
			get
			{
				return this.freeText;
			}
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x00130B1C File Offset: 0x0012ED1C
		public virtual global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[] GetGeneralInfo()
		{
			if (this.generalInfo == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[] results = new global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[this.generalInfo.Count];
			for (int i = 0; i < results.Length; i++)
			{
				results[i] = global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue.GetInstance(this.generalInfo[i]);
			}
			return results;
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x00130B68 File Offset: 0x0012ED68
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.pvno,
				this.sender,
				this.recipient
			});
			asn1EncodableVector.AddOptionalTagged(true, 0, this.messageTime);
			asn1EncodableVector.AddOptionalTagged(true, 1, this.protectionAlg);
			asn1EncodableVector.AddOptionalTagged(true, 2, this.senderKID);
			asn1EncodableVector.AddOptionalTagged(true, 3, this.recipKID);
			asn1EncodableVector.AddOptionalTagged(true, 4, this.transactionID);
			asn1EncodableVector.AddOptionalTagged(true, 5, this.senderNonce);
			asn1EncodableVector.AddOptionalTagged(true, 6, this.recipNonce);
			asn1EncodableVector.AddOptionalTagged(true, 7, this.freeText);
			asn1EncodableVector.AddOptionalTagged(true, 8, this.generalInfo);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04002115 RID: 8469
		public static readonly global::Org.BouncyCastle.Asn1.X509.GeneralName NULL_NAME = new global::Org.BouncyCastle.Asn1.X509.GeneralName(global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(new global::Org.BouncyCastle.Asn1.DerSequence()));

		// Token: 0x04002116 RID: 8470
		public static readonly int CMP_1999 = 1;

		// Token: 0x04002117 RID: 8471
		public static readonly int CMP_2000 = 2;

		// Token: 0x04002118 RID: 8472
		private readonly global::Org.BouncyCastle.Asn1.DerInteger pvno;

		// Token: 0x04002119 RID: 8473
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName sender;

		// Token: 0x0400211A RID: 8474
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName recipient;

		// Token: 0x0400211B RID: 8475
		private readonly global::Org.BouncyCastle.Asn1.DerGeneralizedTime messageTime;

		// Token: 0x0400211C RID: 8476
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier protectionAlg;

		// Token: 0x0400211D RID: 8477
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString senderKID;

		// Token: 0x0400211E RID: 8478
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString recipKID;

		// Token: 0x0400211F RID: 8479
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString transactionID;

		// Token: 0x04002120 RID: 8480
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString senderNonce;

		// Token: 0x04002121 RID: 8481
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString recipNonce;

		// Token: 0x04002122 RID: 8482
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText freeText;

		// Token: 0x04002123 RID: 8483
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence generalInfo;
	}
}
