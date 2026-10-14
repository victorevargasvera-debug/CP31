using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.Icao
{
	// Token: 0x020006F4 RID: 1780
	public class LdsSecurityObject : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600407A RID: 16506 RVA: 0x00124734 File Offset: 0x00122934
		public static global::Org.BouncyCastle.Asn1.Icao.LdsSecurityObject GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Icao.LdsSecurityObject)
			{
				return (global::Org.BouncyCastle.Asn1.Icao.LdsSecurityObject)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Icao.LdsSecurityObject(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x00124758 File Offset: 0x00122958
		private LdsSecurityObject(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null || seq.Count == 0)
			{
				throw new global::System.ArgumentException("null or empty sequence passed.");
			}
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			e.MoveNext();
			this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(e.Current);
			e.MoveNext();
			this.digestAlgorithmIdentifier = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(e.Current);
			e.MoveNext();
			global::Org.BouncyCastle.Asn1.Asn1Sequence datagroupHashSeq = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(e.Current);
			if (this.version.HasValue(1))
			{
				e.MoveNext();
				this.versionInfo = global::Org.BouncyCastle.Asn1.Icao.LdsVersionInfo.GetInstance(e.Current);
			}
			this.CheckDatagroupHashSeqSize(datagroupHashSeq.Count);
			this.datagroupHash = new global::Org.BouncyCastle.Asn1.Icao.DataGroupHash[datagroupHashSeq.Count];
			for (int i = 0; i < datagroupHashSeq.Count; i++)
			{
				this.datagroupHash[i] = global::Org.BouncyCastle.Asn1.Icao.DataGroupHash.GetInstance(datagroupHashSeq[i]);
			}
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x0012483F File Offset: 0x00122A3F
		public LdsSecurityObject(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithmIdentifier, global::Org.BouncyCastle.Asn1.Icao.DataGroupHash[] datagroupHash)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(0);
			this.digestAlgorithmIdentifier = digestAlgorithmIdentifier;
			this.datagroupHash = datagroupHash;
			this.CheckDatagroupHashSeqSize(datagroupHash.Length);
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x00124876 File Offset: 0x00122A76
		public LdsSecurityObject(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithmIdentifier, global::Org.BouncyCastle.Asn1.Icao.DataGroupHash[] datagroupHash, global::Org.BouncyCastle.Asn1.Icao.LdsVersionInfo versionInfo)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(1);
			this.digestAlgorithmIdentifier = digestAlgorithmIdentifier;
			this.datagroupHash = datagroupHash;
			this.versionInfo = versionInfo;
			this.CheckDatagroupHashSeqSize(datagroupHash.Length);
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x001248B4 File Offset: 0x00122AB4
		private void CheckDatagroupHashSeqSize(int size)
		{
			if (size < 2 || size > 16)
			{
				throw new global::System.ArgumentException("wrong size in DataGroupHashValues : not in (2.." + 16.ToString() + ")");
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x0600407F RID: 16511 RVA: 0x001248E9 File Offset: 0x00122AE9
		public global::Org.BouncyCastle.Math.BigInteger Version
		{
			get
			{
				return this.version.Value;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06004080 RID: 16512 RVA: 0x001248F6 File Offset: 0x00122AF6
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DigestAlgorithmIdentifier
		{
			get
			{
				return this.digestAlgorithmIdentifier;
			}
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x001248FE File Offset: 0x00122AFE
		public global::Org.BouncyCastle.Asn1.Icao.DataGroupHash[] GetDatagroupHash()
		{
			return this.datagroupHash;
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06004082 RID: 16514 RVA: 0x00124906 File Offset: 0x00122B06
		public global::Org.BouncyCastle.Asn1.Icao.LdsVersionInfo VersionInfo
		{
			get
			{
				return this.versionInfo;
			}
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x00124910 File Offset: 0x00122B10
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements = this.datagroupHash;
			global::Org.BouncyCastle.Asn1.DerSequence hashSeq = new global::Org.BouncyCastle.Asn1.DerSequence(elements);
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.digestAlgorithmIdentifier,
				hashSeq
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.versionInfo
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001E97 RID: 7831
		public const int UBDataGroups = 16;

		// Token: 0x04001E98 RID: 7832
		private global::Org.BouncyCastle.Asn1.DerInteger version = new global::Org.BouncyCastle.Asn1.DerInteger(0);

		// Token: 0x04001E99 RID: 7833
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithmIdentifier;

		// Token: 0x04001E9A RID: 7834
		private global::Org.BouncyCastle.Asn1.Icao.DataGroupHash[] datagroupHash;

		// Token: 0x04001E9B RID: 7835
		private global::Org.BouncyCastle.Asn1.Icao.LdsVersionInfo versionInfo;
	}
}
