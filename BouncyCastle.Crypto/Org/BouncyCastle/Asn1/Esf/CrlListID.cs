using System;
using System.Collections;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000709 RID: 1801
	public class CrlListID : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060040FF RID: 16639 RVA: 0x00126854 File Offset: 0x00124A54
		public static global::Org.BouncyCastle.Asn1.Esf.CrlListID GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.CrlListID)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.CrlListID)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.CrlListID((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'CrlListID' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x001268A4 File Offset: 0x00124AA4
		private CrlListID(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count != 1)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.crls = (global::Org.BouncyCastle.Asn1.Asn1Sequence)seq[0].ToAsn1Object();
			foreach (object obj in this.crls)
			{
				global::Org.BouncyCastle.Asn1.Esf.CrlValidatedID.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).ToAsn1Object());
			}
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x00126958 File Offset: 0x00124B58
		public CrlListID(params global::Org.BouncyCastle.Asn1.Esf.CrlValidatedID[] crls)
		{
			if (crls == null)
			{
				throw new global::System.ArgumentNullException("crls");
			}
			this.crls = new global::Org.BouncyCastle.Asn1.DerSequence(crls);
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x00126988 File Offset: 0x00124B88
		public CrlListID(global::System.Collections.IEnumerable crls)
		{
			if (crls == null)
			{
				throw new global::System.ArgumentNullException("crls");
			}
			if (!global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.CheckElementsAreOfType(crls, typeof(global::Org.BouncyCastle.Asn1.Esf.CrlValidatedID)))
			{
				throw new global::System.ArgumentException("Must contain only 'CrlValidatedID' objects", "crls");
			}
			this.crls = new global::Org.BouncyCastle.Asn1.DerSequence(global::Org.BouncyCastle.Asn1.Asn1EncodableVector.FromEnumerable(crls));
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x001269DC File Offset: 0x00124BDC
		public global::Org.BouncyCastle.Asn1.Esf.CrlValidatedID[] GetCrls()
		{
			global::Org.BouncyCastle.Asn1.Esf.CrlValidatedID[] result = new global::Org.BouncyCastle.Asn1.Esf.CrlValidatedID[this.crls.Count];
			for (int i = 0; i < this.crls.Count; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.Esf.CrlValidatedID.GetInstance(this.crls[i].ToAsn1Object());
			}
			return result;
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x00126A2A File Offset: 0x00124C2A
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(this.crls);
		}

		// Token: 0x04001F21 RID: 7969
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence crls;
	}
}
