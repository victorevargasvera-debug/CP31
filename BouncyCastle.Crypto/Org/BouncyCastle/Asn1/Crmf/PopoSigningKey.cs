using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000736 RID: 1846
	public class PopoSigningKey : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004234 RID: 16948 RVA: 0x0012AA38 File Offset: 0x00128C38
		private PopoSigningKey(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int index = 0;
			if (seq[index] is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagObj = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[index++];
				if (tagObj.TagNo != 0)
				{
					throw new global::System.ArgumentException("Unknown PopoSigningKeyInput tag: " + tagObj.TagNo.ToString(), "seq");
				}
				this.poposkInput = global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKeyInput.GetInstance(tagObj.GetObject());
			}
			this.algorithmIdentifier = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[index++]);
			this.signature = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[index]);
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x0012AAD0 File Offset: 0x00128CD0
		public static global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKey GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKey)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKey)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKey((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x0012AB0F File Offset: 0x00128D0F
		public static global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKey GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKey.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x0012AB1D File Offset: 0x00128D1D
		public PopoSigningKey(global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKeyInput poposkIn, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier aid, global::Org.BouncyCastle.Asn1.DerBitString signature)
		{
			this.poposkInput = poposkIn;
			this.algorithmIdentifier = aid;
			this.signature = signature;
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06004238 RID: 16952 RVA: 0x0012AB3A File Offset: 0x00128D3A
		public virtual global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKeyInput PoposkInput
		{
			get
			{
				return this.poposkInput;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06004239 RID: 16953 RVA: 0x0012AB42 File Offset: 0x00128D42
		public virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgorithmIdentifier
		{
			get
			{
				return this.algorithmIdentifier;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x0600423A RID: 16954 RVA: 0x0012AB4A File Offset: 0x00128D4A
		public virtual global::Org.BouncyCastle.Asn1.DerBitString Signature
		{
			get
			{
				return this.signature;
			}
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x0012AB52 File Offset: 0x00128D52
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(false, 0, this.poposkInput);
			asn1EncodableVector.Add(this.algorithmIdentifier);
			asn1EncodableVector.Add(this.signature);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001FE1 RID: 8161
		private readonly global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKeyInput poposkInput;

		// Token: 0x04001FE2 RID: 8162
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithmIdentifier;

		// Token: 0x04001FE3 RID: 8163
		private readonly global::Org.BouncyCastle.Asn1.DerBitString signature;
	}
}
