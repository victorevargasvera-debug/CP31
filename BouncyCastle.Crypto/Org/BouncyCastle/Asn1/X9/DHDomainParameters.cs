using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x0200062D RID: 1581
	public class DHDomainParameters : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003ABC RID: 15036 RVA: 0x0010F71F File Offset: 0x0010D91F
		public static global::Org.BouncyCastle.Asn1.X9.DHDomainParameters GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.X9.DHDomainParameters.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x0010F730 File Offset: 0x0010D930
		public static global::Org.BouncyCastle.Asn1.X9.DHDomainParameters GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X9.DHDomainParameters)
			{
				return (global::Org.BouncyCastle.Asn1.X9.DHDomainParameters)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X9.DHDomainParameters((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid DHDomainParameters: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x0010F780 File Offset: 0x0010D980
		public DHDomainParameters(global::Org.BouncyCastle.Asn1.DerInteger p, global::Org.BouncyCastle.Asn1.DerInteger g, global::Org.BouncyCastle.Asn1.DerInteger q, global::Org.BouncyCastle.Asn1.DerInteger j, global::Org.BouncyCastle.Asn1.X9.DHValidationParms validationParms)
		{
			if (p == null)
			{
				throw new global::System.ArgumentNullException("p");
			}
			if (g == null)
			{
				throw new global::System.ArgumentNullException("g");
			}
			if (q == null)
			{
				throw new global::System.ArgumentNullException("q");
			}
			this.p = p;
			this.g = g;
			this.q = q;
			this.j = j;
			this.validationParms = validationParms;
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x0010F7E4 File Offset: 0x0010D9E4
		private DHDomainParameters(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 3 || seq.Count > 5)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			this.p = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(global::Org.BouncyCastle.Asn1.X9.DHDomainParameters.GetNext(e));
			this.g = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(global::Org.BouncyCastle.Asn1.X9.DHDomainParameters.GetNext(e));
			this.q = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(global::Org.BouncyCastle.Asn1.X9.DHDomainParameters.GetNext(e));
			global::Org.BouncyCastle.Asn1.Asn1Encodable next = global::Org.BouncyCastle.Asn1.X9.DHDomainParameters.GetNext(e);
			if (next != null && next is global::Org.BouncyCastle.Asn1.DerInteger)
			{
				this.j = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(next);
				next = global::Org.BouncyCastle.Asn1.X9.DHDomainParameters.GetNext(e);
			}
			if (next != null)
			{
				this.validationParms = global::Org.BouncyCastle.Asn1.X9.DHValidationParms.GetInstance(next.ToAsn1Object());
			}
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x0010F89F File Offset: 0x0010DA9F
		private static global::Org.BouncyCastle.Asn1.Asn1Encodable GetNext(global::System.Collections.IEnumerator e)
		{
			if (!e.MoveNext())
			{
				return null;
			}
			return (global::Org.BouncyCastle.Asn1.Asn1Encodable)e.Current;
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06003AC1 RID: 15041 RVA: 0x0010F8B6 File Offset: 0x0010DAB6
		public global::Org.BouncyCastle.Asn1.DerInteger P
		{
			get
			{
				return this.p;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06003AC2 RID: 15042 RVA: 0x0010F8BE File Offset: 0x0010DABE
		public global::Org.BouncyCastle.Asn1.DerInteger G
		{
			get
			{
				return this.g;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x0010F8C6 File Offset: 0x0010DAC6
		public global::Org.BouncyCastle.Asn1.DerInteger Q
		{
			get
			{
				return this.q;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06003AC4 RID: 15044 RVA: 0x0010F8CE File Offset: 0x0010DACE
		public global::Org.BouncyCastle.Asn1.DerInteger J
		{
			get
			{
				return this.j;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x0010F8D6 File Offset: 0x0010DAD6
		public global::Org.BouncyCastle.Asn1.X9.DHValidationParms ValidationParms
		{
			get
			{
				return this.validationParms;
			}
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x0010F8E0 File Offset: 0x0010DAE0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.p,
				this.g,
				this.q
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.j,
				this.validationParms
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x040019BB RID: 6587
		private readonly global::Org.BouncyCastle.Asn1.DerInteger p;

		// Token: 0x040019BC RID: 6588
		private readonly global::Org.BouncyCastle.Asn1.DerInteger g;

		// Token: 0x040019BD RID: 6589
		private readonly global::Org.BouncyCastle.Asn1.DerInteger q;

		// Token: 0x040019BE RID: 6590
		private readonly global::Org.BouncyCastle.Asn1.DerInteger j;

		// Token: 0x040019BF RID: 6591
		private readonly global::Org.BouncyCastle.Asn1.X9.DHValidationParms validationParms;
	}
}
