using System;
using System.Collections;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000672 RID: 1650
	public class TbsCertificateList : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003CD4 RID: 15572 RVA: 0x00115C4B File Offset: 0x00113E4B
		public static global::Org.BouncyCastle.Asn1.X509.TbsCertificateList GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.TbsCertificateList.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x00115C5C File Offset: 0x00113E5C
		public static global::Org.BouncyCastle.Asn1.X509.TbsCertificateList GetInstance(object obj)
		{
			global::Org.BouncyCastle.Asn1.X509.TbsCertificateList list = obj as global::Org.BouncyCastle.Asn1.X509.TbsCertificateList;
			if (obj == null || list != null)
			{
				return list;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.TbsCertificateList((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x00115CA8 File Offset: 0x00113EA8
		internal TbsCertificateList(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 3 || seq.Count > 7)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			int seqPos = 0;
			this.seq = seq;
			if (seq[seqPos] is global::Org.BouncyCastle.Asn1.DerInteger)
			{
				this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[seqPos++]);
			}
			else
			{
				this.version = new global::Org.BouncyCastle.Asn1.DerInteger(0);
			}
			this.signature = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[seqPos++]);
			this.issuer = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(seq[seqPos++]);
			this.thisUpdate = global::Org.BouncyCastle.Asn1.X509.Time.GetInstance(seq[seqPos++]);
			if (seqPos < seq.Count && (seq[seqPos] is global::Org.BouncyCastle.Asn1.DerUtcTime || seq[seqPos] is global::Org.BouncyCastle.Asn1.DerGeneralizedTime || seq[seqPos] is global::Org.BouncyCastle.Asn1.X509.Time))
			{
				this.nextUpdate = global::Org.BouncyCastle.Asn1.X509.Time.GetInstance(seq[seqPos++]);
			}
			if (seqPos < seq.Count && !(seq[seqPos] is global::Org.BouncyCastle.Asn1.Asn1TaggedObject))
			{
				this.revokedCertificates = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[seqPos++]);
			}
			if (seqPos < seq.Count && seq[seqPos] is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.crlExtensions = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(seq[seqPos]);
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06003CD7 RID: 15575 RVA: 0x00115E07 File Offset: 0x00114007
		public int Version
		{
			get
			{
				return this.version.IntValueExact + 1;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06003CD8 RID: 15576 RVA: 0x00115E16 File Offset: 0x00114016
		public global::Org.BouncyCastle.Asn1.DerInteger VersionNumber
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06003CD9 RID: 15577 RVA: 0x00115E1E File Offset: 0x0011401E
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Signature
		{
			get
			{
				return this.signature;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06003CDA RID: 15578 RVA: 0x00115E26 File Offset: 0x00114026
		public global::Org.BouncyCastle.Asn1.X509.X509Name Issuer
		{
			get
			{
				return this.issuer;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06003CDB RID: 15579 RVA: 0x00115E2E File Offset: 0x0011402E
		public global::Org.BouncyCastle.Asn1.X509.Time ThisUpdate
		{
			get
			{
				return this.thisUpdate;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06003CDC RID: 15580 RVA: 0x00115E36 File Offset: 0x00114036
		public global::Org.BouncyCastle.Asn1.X509.Time NextUpdate
		{
			get
			{
				return this.nextUpdate;
			}
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x00115E40 File Offset: 0x00114040
		public global::Org.BouncyCastle.Asn1.X509.CrlEntry[] GetRevokedCertificates()
		{
			if (this.revokedCertificates == null)
			{
				return new global::Org.BouncyCastle.Asn1.X509.CrlEntry[0];
			}
			global::Org.BouncyCastle.Asn1.X509.CrlEntry[] entries = new global::Org.BouncyCastle.Asn1.X509.CrlEntry[this.revokedCertificates.Count];
			for (int i = 0; i < entries.Length; i++)
			{
				entries[i] = new global::Org.BouncyCastle.Asn1.X509.CrlEntry(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(this.revokedCertificates[i]));
			}
			return entries;
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x00115E95 File Offset: 0x00114095
		public global::System.Collections.IEnumerable GetRevokedCertificateEnumeration()
		{
			if (this.revokedCertificates == null)
			{
				return global::Org.BouncyCastle.Utilities.Collections.EmptyEnumerable.Instance;
			}
			return new global::Org.BouncyCastle.Asn1.X509.TbsCertificateList.RevokedCertificatesEnumeration(this.revokedCertificates);
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06003CDF RID: 15583 RVA: 0x00115EB0 File Offset: 0x001140B0
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions Extensions
		{
			get
			{
				return this.crlExtensions;
			}
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x00115EB8 File Offset: 0x001140B8
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.seq;
		}

		// Token: 0x04001AD9 RID: 6873
		internal global::Org.BouncyCastle.Asn1.Asn1Sequence seq;

		// Token: 0x04001ADA RID: 6874
		internal global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001ADB RID: 6875
		internal global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature;

		// Token: 0x04001ADC RID: 6876
		internal global::Org.BouncyCastle.Asn1.X509.X509Name issuer;

		// Token: 0x04001ADD RID: 6877
		internal global::Org.BouncyCastle.Asn1.X509.Time thisUpdate;

		// Token: 0x04001ADE RID: 6878
		internal global::Org.BouncyCastle.Asn1.X509.Time nextUpdate;

		// Token: 0x04001ADF RID: 6879
		internal global::Org.BouncyCastle.Asn1.Asn1Sequence revokedCertificates;

		// Token: 0x04001AE0 RID: 6880
		internal global::Org.BouncyCastle.Asn1.X509.X509Extensions crlExtensions;

		// Token: 0x02000869 RID: 2153
		private class RevokedCertificatesEnumeration : global::System.Collections.IEnumerable
		{
			// Token: 0x060047A0 RID: 18336 RVA: 0x0013C35B File Offset: 0x0013A55B
			internal RevokedCertificatesEnumeration(global::System.Collections.IEnumerable en)
			{
				this.en = en;
			}

			// Token: 0x060047A1 RID: 18337 RVA: 0x0013C36A File Offset: 0x0013A56A
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return new global::Org.BouncyCastle.Asn1.X509.TbsCertificateList.RevokedCertificatesEnumeration.RevokedCertificatesEnumerator(this.en.GetEnumerator());
			}

			// Token: 0x040025E4 RID: 9700
			private readonly global::System.Collections.IEnumerable en;

			// Token: 0x020008C7 RID: 2247
			private class RevokedCertificatesEnumerator : global::System.Collections.IEnumerator
			{
				// Token: 0x06004838 RID: 18488 RVA: 0x0013DD74 File Offset: 0x0013BF74
				internal RevokedCertificatesEnumerator(global::System.Collections.IEnumerator e)
				{
					this.e = e;
				}

				// Token: 0x06004839 RID: 18489 RVA: 0x0013DD83 File Offset: 0x0013BF83
				public bool MoveNext()
				{
					return this.e.MoveNext();
				}

				// Token: 0x0600483A RID: 18490 RVA: 0x0013DD90 File Offset: 0x0013BF90
				public void Reset()
				{
					this.e.Reset();
				}

				// Token: 0x17000ABD RID: 2749
				// (get) Token: 0x0600483B RID: 18491 RVA: 0x0013DD9D File Offset: 0x0013BF9D
				public object Current
				{
					get
					{
						return new global::Org.BouncyCastle.Asn1.X509.CrlEntry(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(this.e.Current));
					}
				}

				// Token: 0x04002655 RID: 9813
				private readonly global::System.Collections.IEnumerator e;
			}
		}
	}
}
