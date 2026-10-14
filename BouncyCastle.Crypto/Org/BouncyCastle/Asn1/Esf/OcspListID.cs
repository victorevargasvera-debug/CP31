using System;
using System.Collections;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x0200070E RID: 1806
	public class OcspListID : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600411B RID: 16667 RVA: 0x00126F28 File Offset: 0x00125128
		public static global::Org.BouncyCastle.Asn1.Esf.OcspListID GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.OcspListID)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.OcspListID)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.OcspListID((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'OcspListID' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x00126F78 File Offset: 0x00125178
		private OcspListID(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count != 1)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.ocspResponses = (global::Org.BouncyCastle.Asn1.Asn1Sequence)seq[0].ToAsn1Object();
			foreach (object obj in this.ocspResponses)
			{
				global::Org.BouncyCastle.Asn1.Esf.OcspResponsesID.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).ToAsn1Object());
			}
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x0012702C File Offset: 0x0012522C
		public OcspListID(params global::Org.BouncyCastle.Asn1.Esf.OcspResponsesID[] ocspResponses)
		{
			if (ocspResponses == null)
			{
				throw new global::System.ArgumentNullException("ocspResponses");
			}
			this.ocspResponses = new global::Org.BouncyCastle.Asn1.DerSequence(ocspResponses);
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x0012705C File Offset: 0x0012525C
		public OcspListID(global::System.Collections.IEnumerable ocspResponses)
		{
			if (ocspResponses == null)
			{
				throw new global::System.ArgumentNullException("ocspResponses");
			}
			if (!global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.CheckElementsAreOfType(ocspResponses, typeof(global::Org.BouncyCastle.Asn1.Esf.OcspResponsesID)))
			{
				throw new global::System.ArgumentException("Must contain only 'OcspResponsesID' objects", "ocspResponses");
			}
			this.ocspResponses = new global::Org.BouncyCastle.Asn1.DerSequence(global::Org.BouncyCastle.Asn1.Asn1EncodableVector.FromEnumerable(ocspResponses));
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x001270B0 File Offset: 0x001252B0
		public global::Org.BouncyCastle.Asn1.Esf.OcspResponsesID[] GetOcspResponses()
		{
			global::Org.BouncyCastle.Asn1.Esf.OcspResponsesID[] result = new global::Org.BouncyCastle.Asn1.Esf.OcspResponsesID[this.ocspResponses.Count];
			for (int i = 0; i < this.ocspResponses.Count; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.Esf.OcspResponsesID.GetInstance(this.ocspResponses[i].ToAsn1Object());
			}
			return result;
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x001270FE File Offset: 0x001252FE
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(this.ocspResponses);
		}

		// Token: 0x04001F37 RID: 7991
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence ocspResponses;
	}
}
