using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000775 RID: 1909
	public class CrlAnnContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600440B RID: 17419 RVA: 0x0012FD17 File Offset: 0x0012DF17
		private CrlAnnContent(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.content = seq;
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x0012FD26 File Offset: 0x0012DF26
		public static global::Org.BouncyCastle.Asn1.Cmp.CrlAnnContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.CrlAnnContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.CrlAnnContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.CrlAnnContent((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x0012FD68 File Offset: 0x0012DF68
		public virtual global::Org.BouncyCastle.Asn1.X509.CertificateList[] ToCertificateListArray()
		{
			global::Org.BouncyCastle.Asn1.X509.CertificateList[] result = new global::Org.BouncyCastle.Asn1.X509.CertificateList[this.content.Count];
			for (int i = 0; i != result.Length; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance(this.content[i]);
			}
			return result;
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x0012FDA9 File Offset: 0x0012DFA9
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.content;
		}

		// Token: 0x040020C9 RID: 8393
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence content;
	}
}
