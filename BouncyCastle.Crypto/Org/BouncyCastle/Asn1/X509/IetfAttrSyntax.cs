using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000659 RID: 1625
	public class IetfAttrSyntax : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C25 RID: 15397 RVA: 0x00113B4C File Offset: 0x00111D4C
		public IetfAttrSyntax(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int i = 0;
			if (seq[0] is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.policyAuthority = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[0], false);
				i++;
			}
			else if (seq.Count == 2)
			{
				this.policyAuthority = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(seq[0]);
				i++;
			}
			if (!(seq[i] is global::Org.BouncyCastle.Asn1.Asn1Sequence))
			{
				throw new global::System.ArgumentException("Non-IetfAttrSyntax encoding");
			}
			seq = (global::Org.BouncyCastle.Asn1.Asn1Sequence)seq[i];
			foreach (object obj2 in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1Object obj = (global::Org.BouncyCastle.Asn1.Asn1Object)obj2;
				int type;
				if (obj is global::Org.BouncyCastle.Asn1.DerObjectIdentifier)
				{
					type = 2;
				}
				else if (obj is global::Org.BouncyCastle.Asn1.DerUtf8String)
				{
					type = 3;
				}
				else
				{
					if (!(obj is global::Org.BouncyCastle.Asn1.DerOctetString))
					{
						throw new global::System.ArgumentException("Bad value type encoding IetfAttrSyntax");
					}
					type = 1;
				}
				if (this.valueChoice < 0)
				{
					this.valueChoice = type;
				}
				if (type != this.valueChoice)
				{
					throw new global::System.ArgumentException("Mix of value types in IetfAttrSyntax");
				}
				this.values.Add(obj);
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06003C26 RID: 15398 RVA: 0x00113C88 File Offset: 0x00111E88
		public global::Org.BouncyCastle.Asn1.X509.GeneralNames PolicyAuthority
		{
			get
			{
				return this.policyAuthority;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06003C27 RID: 15399 RVA: 0x00113C90 File Offset: 0x00111E90
		public int ValueType
		{
			get
			{
				return this.valueChoice;
			}
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x00113C98 File Offset: 0x00111E98
		public object[] GetValues()
		{
			if (this.ValueType == 1)
			{
				global::Org.BouncyCastle.Asn1.Asn1OctetString[] tmp = new global::Org.BouncyCastle.Asn1.Asn1OctetString[this.values.Count];
				for (int i = 0; i != tmp.Length; i++)
				{
					tmp[i] = (global::Org.BouncyCastle.Asn1.Asn1OctetString)this.values[i];
				}
				return tmp;
			}
			if (this.ValueType == 2)
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier[] tmp2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier[this.values.Count];
				for (int j = 0; j != tmp2.Length; j++)
				{
					tmp2[j] = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)this.values[j];
				}
				return tmp2;
			}
			global::Org.BouncyCastle.Asn1.DerUtf8String[] tmp3 = new global::Org.BouncyCastle.Asn1.DerUtf8String[this.values.Count];
			for (int k = 0; k != tmp3.Length; k++)
			{
				tmp3[k] = (global::Org.BouncyCastle.Asn1.DerUtf8String)this.values[k];
			}
			return tmp3;
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x00113D6B File Offset: 0x00111F6B
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(true, 0, this.policyAuthority);
			asn1EncodableVector.Add(new global::Org.BouncyCastle.Asn1.DerSequence(this.values));
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001A77 RID: 6775
		public const int ValueOctets = 1;

		// Token: 0x04001A78 RID: 6776
		public const int ValueOid = 2;

		// Token: 0x04001A79 RID: 6777
		public const int ValueUtf8 = 3;

		// Token: 0x04001A7A RID: 6778
		internal readonly global::Org.BouncyCastle.Asn1.X509.GeneralNames policyAuthority;

		// Token: 0x04001A7B RID: 6779
		internal readonly global::Org.BouncyCastle.Asn1.Asn1EncodableVector values = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();

		// Token: 0x04001A7C RID: 6780
		internal int valueChoice = -1;
	}
}
