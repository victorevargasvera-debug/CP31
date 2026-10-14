using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000730 RID: 1840
	public class EncryptedValue : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004209 RID: 16905 RVA: 0x0012A388 File Offset: 0x00128588
		private EncryptedValue(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int index = 0;
			while (seq[index] is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tObj = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[index];
				switch (tObj.TagNo)
				{
				case 0:
					this.intendedAlg = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(tObj, false);
					break;
				case 1:
					this.symmAlg = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(tObj, false);
					break;
				case 2:
					this.encSymmKey = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(tObj, false);
					break;
				case 3:
					this.keyAlg = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(tObj, false);
					break;
				case 4:
					this.valueHint = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(tObj, false);
					break;
				}
				index++;
			}
			this.encValue = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[index]);
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x0012A43F File Offset: 0x0012863F
		public static global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x0012A460 File Offset: 0x00128660
		public EncryptedValue(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier intendedAlg, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier symmAlg, global::Org.BouncyCastle.Asn1.DerBitString encSymmKey, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyAlg, global::Org.BouncyCastle.Asn1.Asn1OctetString valueHint, global::Org.BouncyCastle.Asn1.DerBitString encValue)
		{
			if (encValue == null)
			{
				throw new global::System.ArgumentNullException("encValue");
			}
			this.intendedAlg = intendedAlg;
			this.symmAlg = symmAlg;
			this.encSymmKey = encSymmKey;
			this.keyAlg = keyAlg;
			this.valueHint = valueHint;
			this.encValue = encValue;
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x0600420C RID: 16908 RVA: 0x0012A4AF File Offset: 0x001286AF
		public virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier IntendedAlg
		{
			get
			{
				return this.intendedAlg;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x0600420D RID: 16909 RVA: 0x0012A4B7 File Offset: 0x001286B7
		public virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SymmAlg
		{
			get
			{
				return this.symmAlg;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x0600420E RID: 16910 RVA: 0x0012A4BF File Offset: 0x001286BF
		public virtual global::Org.BouncyCastle.Asn1.DerBitString EncSymmKey
		{
			get
			{
				return this.encSymmKey;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x0600420F RID: 16911 RVA: 0x0012A4C7 File Offset: 0x001286C7
		public virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyAlg
		{
			get
			{
				return this.keyAlg;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06004210 RID: 16912 RVA: 0x0012A4CF File Offset: 0x001286CF
		public virtual global::Org.BouncyCastle.Asn1.Asn1OctetString ValueHint
		{
			get
			{
				return this.valueHint;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06004211 RID: 16913 RVA: 0x0012A4D7 File Offset: 0x001286D7
		public virtual global::Org.BouncyCastle.Asn1.DerBitString EncValue
		{
			get
			{
				return this.encValue;
			}
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x0012A4E0 File Offset: 0x001286E0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(false, 0, this.intendedAlg);
			asn1EncodableVector.AddOptionalTagged(false, 1, this.symmAlg);
			asn1EncodableVector.AddOptionalTagged(false, 2, this.encSymmKey);
			asn1EncodableVector.AddOptionalTagged(false, 3, this.keyAlg);
			asn1EncodableVector.AddOptionalTagged(false, 4, this.valueHint);
			asn1EncodableVector.Add(this.encValue);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001FCA RID: 8138
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier intendedAlg;

		// Token: 0x04001FCB RID: 8139
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier symmAlg;

		// Token: 0x04001FCC RID: 8140
		private readonly global::Org.BouncyCastle.Asn1.DerBitString encSymmKey;

		// Token: 0x04001FCD RID: 8141
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyAlg;

		// Token: 0x04001FCE RID: 8142
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString valueHint;

		// Token: 0x04001FCF RID: 8143
		private readonly global::Org.BouncyCastle.Asn1.DerBitString encValue;
	}
}
