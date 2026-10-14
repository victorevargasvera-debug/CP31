using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000782 RID: 1922
	public class PkiHeaderBuilder
	{
		// Token: 0x06004465 RID: 17509 RVA: 0x00130C40 File Offset: 0x0012EE40
		public PkiHeaderBuilder(int pvno, global::Org.BouncyCastle.Asn1.X509.GeneralName sender, global::Org.BouncyCastle.Asn1.X509.GeneralName recipient) : this(new global::Org.BouncyCastle.Asn1.DerInteger(pvno), sender, recipient)
		{
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x00130C50 File Offset: 0x0012EE50
		private PkiHeaderBuilder(global::Org.BouncyCastle.Asn1.DerInteger pvno, global::Org.BouncyCastle.Asn1.X509.GeneralName sender, global::Org.BouncyCastle.Asn1.X509.GeneralName recipient)
		{
			this.pvno = pvno;
			this.sender = sender;
			this.recipient = recipient;
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x00130C6D File Offset: 0x0012EE6D
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetMessageTime(global::Org.BouncyCastle.Asn1.DerGeneralizedTime time)
		{
			this.messageTime = time;
			return this;
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x00130C77 File Offset: 0x0012EE77
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetProtectionAlg(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier aid)
		{
			this.protectionAlg = aid;
			return this;
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x00130C81 File Offset: 0x0012EE81
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetSenderKID(byte[] kid)
		{
			return this.SetSenderKID((kid == null) ? null : new global::Org.BouncyCastle.Asn1.DerOctetString(kid));
		}

		// Token: 0x0600446A RID: 17514 RVA: 0x00130C95 File Offset: 0x0012EE95
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetSenderKID(global::Org.BouncyCastle.Asn1.Asn1OctetString kid)
		{
			this.senderKID = kid;
			return this;
		}

		// Token: 0x0600446B RID: 17515 RVA: 0x00130C9F File Offset: 0x0012EE9F
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetRecipKID(byte[] kid)
		{
			return this.SetRecipKID((kid == null) ? null : new global::Org.BouncyCastle.Asn1.DerOctetString(kid));
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x00130CB3 File Offset: 0x0012EEB3
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetRecipKID(global::Org.BouncyCastle.Asn1.Asn1OctetString kid)
		{
			this.recipKID = kid;
			return this;
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x00130CBD File Offset: 0x0012EEBD
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetTransactionID(byte[] tid)
		{
			return this.SetTransactionID((tid == null) ? null : new global::Org.BouncyCastle.Asn1.DerOctetString(tid));
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x00130CD1 File Offset: 0x0012EED1
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetTransactionID(global::Org.BouncyCastle.Asn1.Asn1OctetString tid)
		{
			this.transactionID = tid;
			return this;
		}

		// Token: 0x0600446F RID: 17519 RVA: 0x00130CDB File Offset: 0x0012EEDB
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetSenderNonce(byte[] nonce)
		{
			return this.SetSenderNonce((nonce == null) ? null : new global::Org.BouncyCastle.Asn1.DerOctetString(nonce));
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x00130CEF File Offset: 0x0012EEEF
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetSenderNonce(global::Org.BouncyCastle.Asn1.Asn1OctetString nonce)
		{
			this.senderNonce = nonce;
			return this;
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x00130CF9 File Offset: 0x0012EEF9
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetRecipNonce(byte[] nonce)
		{
			return this.SetRecipNonce((nonce == null) ? null : new global::Org.BouncyCastle.Asn1.DerOctetString(nonce));
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x00130D0D File Offset: 0x0012EF0D
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetRecipNonce(global::Org.BouncyCastle.Asn1.Asn1OctetString nonce)
		{
			this.recipNonce = nonce;
			return this;
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x00130D17 File Offset: 0x0012EF17
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetFreeText(global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText text)
		{
			this.freeText = text;
			return this;
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x00130D21 File Offset: 0x0012EF21
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetGeneralInfo(global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue genInfo)
		{
			return this.SetGeneralInfo(global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder.MakeGeneralInfoSeq(genInfo));
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x00130D2F File Offset: 0x0012EF2F
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetGeneralInfo(global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[] genInfos)
		{
			return this.SetGeneralInfo(global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder.MakeGeneralInfoSeq(genInfos));
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x00130D3D File Offset: 0x0012EF3D
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeaderBuilder SetGeneralInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seqOfInfoTypeAndValue)
		{
			this.generalInfo = seqOfInfoTypeAndValue;
			return this;
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x00130D47 File Offset: 0x0012EF47
		private static global::Org.BouncyCastle.Asn1.Asn1Sequence MakeGeneralInfoSeq(global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue generalInfo)
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(generalInfo);
		}

		// Token: 0x06004478 RID: 17528 RVA: 0x00130D50 File Offset: 0x0012EF50
		private static global::Org.BouncyCastle.Asn1.Asn1Sequence MakeGeneralInfoSeq(global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue[] generalInfos)
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence genInfoSeq = null;
			if (generalInfos != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
				for (int i = 0; i < generalInfos.Length; i++)
				{
					v.Add(generalInfos[i]);
				}
				genInfoSeq = new global::Org.BouncyCastle.Asn1.DerSequence(v);
			}
			return genInfoSeq;
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x00130D88 File Offset: 0x0012EF88
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeader Build()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.pvno,
				this.sender,
				this.recipient
			});
			this.AddOptional(v, 0, this.messageTime);
			this.AddOptional(v, 1, this.protectionAlg);
			this.AddOptional(v, 2, this.senderKID);
			this.AddOptional(v, 3, this.recipKID);
			this.AddOptional(v, 4, this.transactionID);
			this.AddOptional(v, 5, this.senderNonce);
			this.AddOptional(v, 6, this.recipNonce);
			this.AddOptional(v, 7, this.freeText);
			this.AddOptional(v, 8, this.generalInfo);
			this.messageTime = null;
			this.protectionAlg = null;
			this.senderKID = null;
			this.recipKID = null;
			this.transactionID = null;
			this.senderNonce = null;
			this.recipNonce = null;
			this.freeText = null;
			this.generalInfo = null;
			return global::Org.BouncyCastle.Asn1.Cmp.PkiHeader.GetInstance(new global::Org.BouncyCastle.Asn1.DerSequence(v));
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x00130E84 File Offset: 0x0012F084
		private void AddOptional(global::Org.BouncyCastle.Asn1.Asn1EncodableVector v, int tagNo, global::Org.BouncyCastle.Asn1.Asn1Encodable obj)
		{
			if (obj != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, tagNo, obj));
			}
		}

		// Token: 0x04002124 RID: 8484
		private global::Org.BouncyCastle.Asn1.DerInteger pvno;

		// Token: 0x04002125 RID: 8485
		private global::Org.BouncyCastle.Asn1.X509.GeneralName sender;

		// Token: 0x04002126 RID: 8486
		private global::Org.BouncyCastle.Asn1.X509.GeneralName recipient;

		// Token: 0x04002127 RID: 8487
		private global::Org.BouncyCastle.Asn1.DerGeneralizedTime messageTime;

		// Token: 0x04002128 RID: 8488
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier protectionAlg;

		// Token: 0x04002129 RID: 8489
		private global::Org.BouncyCastle.Asn1.Asn1OctetString senderKID;

		// Token: 0x0400212A RID: 8490
		private global::Org.BouncyCastle.Asn1.Asn1OctetString recipKID;

		// Token: 0x0400212B RID: 8491
		private global::Org.BouncyCastle.Asn1.Asn1OctetString transactionID;

		// Token: 0x0400212C RID: 8492
		private global::Org.BouncyCastle.Asn1.Asn1OctetString senderNonce;

		// Token: 0x0400212D RID: 8493
		private global::Org.BouncyCastle.Asn1.Asn1OctetString recipNonce;

		// Token: 0x0400212E RID: 8494
		private global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText freeText;

		// Token: 0x0400212F RID: 8495
		private global::Org.BouncyCastle.Asn1.Asn1Sequence generalInfo;
	}
}
