using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509.Qualified
{
	// Token: 0x0200068D RID: 1677
	public class SemanticsInformation : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003DCA RID: 15818 RVA: 0x00119D9C File Offset: 0x00117F9C
		public static global::Org.BouncyCastle.Asn1.X509.Qualified.SemanticsInformation GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.Qualified.SemanticsInformation)
			{
				return (global::Org.BouncyCastle.Asn1.X509.Qualified.SemanticsInformation)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.Qualified.SemanticsInformation(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			throw new global::System.ArgumentException("unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x00119DEC File Offset: 0x00117FEC
		public SemanticsInformation(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 1)
			{
				throw new global::System.ArgumentException("no objects in SemanticsInformation");
			}
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			e.MoveNext();
			object obj = e.Current;
			if (obj is global::Org.BouncyCastle.Asn1.DerObjectIdentifier)
			{
				this.semanticsIdentifier = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(obj);
				if (e.MoveNext())
				{
					obj = e.Current;
				}
				else
				{
					obj = null;
				}
			}
			if (obj != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence generalNameSeq = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj);
				this.nameRegistrationAuthorities = new global::Org.BouncyCastle.Asn1.X509.GeneralName[generalNameSeq.Count];
				for (int i = 0; i < generalNameSeq.Count; i++)
				{
					this.nameRegistrationAuthorities[i] = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(generalNameSeq[i]);
				}
			}
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x00119E8F File Offset: 0x0011808F
		public SemanticsInformation(global::Org.BouncyCastle.Asn1.DerObjectIdentifier semanticsIdentifier, global::Org.BouncyCastle.Asn1.X509.GeneralName[] generalNames)
		{
			this.semanticsIdentifier = semanticsIdentifier;
			this.nameRegistrationAuthorities = generalNames;
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x00119EA5 File Offset: 0x001180A5
		public SemanticsInformation(global::Org.BouncyCastle.Asn1.DerObjectIdentifier semanticsIdentifier)
		{
			this.semanticsIdentifier = semanticsIdentifier;
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x00119EB4 File Offset: 0x001180B4
		public SemanticsInformation(global::Org.BouncyCastle.Asn1.X509.GeneralName[] generalNames)
		{
			this.nameRegistrationAuthorities = generalNames;
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06003DCF RID: 15823 RVA: 0x00119EC3 File Offset: 0x001180C3
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier SemanticsIdentifier
		{
			get
			{
				return this.semanticsIdentifier;
			}
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x00119ECB File Offset: 0x001180CB
		public global::Org.BouncyCastle.Asn1.X509.GeneralName[] GetNameRegistrationAuthorities()
		{
			return this.nameRegistrationAuthorities;
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x00119ED4 File Offset: 0x001180D4
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.semanticsIdentifier
			});
			if (this.nameRegistrationAuthorities != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = v;
				global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements = this.nameRegistrationAuthorities;
				asn1EncodableVector.Add(new global::Org.BouncyCastle.Asn1.DerSequence(elements));
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001BA2 RID: 7074
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier semanticsIdentifier;

		// Token: 0x04001BA3 RID: 7075
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName[] nameRegistrationAuthorities;
	}
}
