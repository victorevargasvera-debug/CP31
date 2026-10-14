using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200063E RID: 1598
	public class AlgorithmIdentifier : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003B35 RID: 15157 RVA: 0x00111138 File Offset: 0x0010F338
		public static global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x00111146 File Offset: 0x0010F346
		public static global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetInstance(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			if (obj is global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)
			{
				return (global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)obj;
			}
			return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x00111167 File Offset: 0x0010F367
		public AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm)
		{
			this.algorithm = algorithm;
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x00111176 File Offset: 0x0010F376
		[global::System.Obsolete("Use version taking a DerObjectIdentifier")]
		public AlgorithmIdentifier(string algorithm)
		{
			this.algorithm = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(algorithm);
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x0011118A File Offset: 0x0010F38A
		public AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, global::Org.BouncyCastle.Asn1.Asn1Encodable parameters)
		{
			this.algorithm = algorithm;
			this.parameters = parameters;
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x001111A0 File Offset: 0x0010F3A0
		internal AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 1 || seq.Count > 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			this.algorithm = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
			this.parameters = ((seq.Count < 2) ? null : seq[1]);
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06003B3B RID: 15163 RVA: 0x0011120E File Offset: 0x0010F40E
		public virtual global::Org.BouncyCastle.Asn1.DerObjectIdentifier Algorithm
		{
			get
			{
				return this.algorithm;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06003B3C RID: 15164 RVA: 0x00111216 File Offset: 0x0010F416
		[global::System.Obsolete("Use 'Algorithm' property instead")]
		public virtual global::Org.BouncyCastle.Asn1.DerObjectIdentifier ObjectID
		{
			get
			{
				return this.algorithm;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06003B3D RID: 15165 RVA: 0x0011121E File Offset: 0x0010F41E
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x00111228 File Offset: 0x0010F428
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.algorithm
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.parameters
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001A22 RID: 6690
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm;

		// Token: 0x04001A23 RID: 6691
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable parameters;
	}
}
