using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x0200062F RID: 1583
	public class DHValidationParms : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003ACC RID: 15052 RVA: 0x0010F9C2 File Offset: 0x0010DBC2
		public static global::Org.BouncyCastle.Asn1.X9.DHValidationParms GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.X9.DHValidationParms.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x0010F9D0 File Offset: 0x0010DBD0
		public static global::Org.BouncyCastle.Asn1.X9.DHValidationParms GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X9.DHValidationParms)
			{
				return (global::Org.BouncyCastle.Asn1.X9.DHValidationParms)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X9.DHValidationParms((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid DHValidationParms: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x0010FA1D File Offset: 0x0010DC1D
		public DHValidationParms(global::Org.BouncyCastle.Asn1.DerBitString seed, global::Org.BouncyCastle.Asn1.DerInteger pgenCounter)
		{
			if (seed == null)
			{
				throw new global::System.ArgumentNullException("seed");
			}
			if (pgenCounter == null)
			{
				throw new global::System.ArgumentNullException("pgenCounter");
			}
			this.seed = seed;
			this.pgenCounter = pgenCounter;
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x0010FA50 File Offset: 0x0010DC50
		private DHValidationParms(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.seed = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[0]);
			this.pgenCounter = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06003AD0 RID: 15056 RVA: 0x0010FAB3 File Offset: 0x0010DCB3
		public global::Org.BouncyCastle.Asn1.DerBitString Seed
		{
			get
			{
				return this.seed;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06003AD1 RID: 15057 RVA: 0x0010FABB File Offset: 0x0010DCBB
		public global::Org.BouncyCastle.Asn1.DerInteger PgenCounter
		{
			get
			{
				return this.pgenCounter;
			}
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x0010FAC3 File Offset: 0x0010DCC3
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.seed,
				this.pgenCounter
			});
		}

		// Token: 0x040019C1 RID: 6593
		private readonly global::Org.BouncyCastle.Asn1.DerBitString seed;

		// Token: 0x040019C2 RID: 6594
		private readonly global::Org.BouncyCastle.Asn1.DerInteger pgenCounter;
	}
}
