using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Icao
{
	// Token: 0x020006F1 RID: 1777
	public class CscaMasterList : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600406B RID: 16491 RVA: 0x00124448 File Offset: 0x00122648
		public static global::Org.BouncyCastle.Asn1.Icao.CscaMasterList GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Icao.CscaMasterList)
			{
				return (global::Org.BouncyCastle.Asn1.Icao.CscaMasterList)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Icao.CscaMasterList(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x0600406C RID: 16492 RVA: 0x0012446C File Offset: 0x0012266C
		private CscaMasterList(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null || seq.Count == 0)
			{
				throw new global::System.ArgumentException("null or empty sequence passed.");
			}
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Incorrect sequence size: " + seq.Count.ToString());
			}
			this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			global::Org.BouncyCastle.Asn1.Asn1Set certSet = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(seq[1]);
			this.certList = new global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[certSet.Count];
			for (int i = 0; i < this.certList.Length; i++)
			{
				this.certList[i] = global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(certSet[i]);
			}
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x0012451F File Offset: 0x0012271F
		public CscaMasterList(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] certStructs)
		{
			this.certList = global::Org.BouncyCastle.Asn1.Icao.CscaMasterList.CopyCertList(certStructs);
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x0600406E RID: 16494 RVA: 0x0012453F File Offset: 0x0012273F
		public virtual int Version
		{
			get
			{
				return this.version.IntValueExact;
			}
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x0012454C File Offset: 0x0012274C
		public global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] GetCertStructs()
		{
			return global::Org.BouncyCastle.Asn1.Icao.CscaMasterList.CopyCertList(this.certList);
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x00124559 File Offset: 0x00122759
		private static global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] CopyCertList(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] orig)
		{
			return (global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[])orig.Clone();
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x00124568 File Offset: 0x00122768
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable[] array = new global::Org.BouncyCastle.Asn1.Asn1Encodable[2];
			array[0] = this.version;
			int num = 1;
			global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements = this.certList;
			array[num] = new global::Org.BouncyCastle.Asn1.DerSet(elements);
			return new global::Org.BouncyCastle.Asn1.DerSequence(array);
		}

		// Token: 0x04001E89 RID: 7817
		private global::Org.BouncyCastle.Asn1.DerInteger version = new global::Org.BouncyCastle.Asn1.DerInteger(0);

		// Token: 0x04001E8A RID: 7818
		private global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] certList;
	}
}
