using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200066F RID: 1647
	public class Targets : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003CBA RID: 15546 RVA: 0x0011573F File Offset: 0x0011393F
		public static global::Org.BouncyCastle.Asn1.X509.Targets GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.Targets)
			{
				return (global::Org.BouncyCastle.Asn1.X509.Targets)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.Targets((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x0011577E File Offset: 0x0011397E
		private Targets(global::Org.BouncyCastle.Asn1.Asn1Sequence targets)
		{
			this.targets = targets;
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x00115790 File Offset: 0x00113990
		public Targets(global::Org.BouncyCastle.Asn1.X509.Target[] targets)
		{
			this.targets = new global::Org.BouncyCastle.Asn1.DerSequence(targets);
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x001157B4 File Offset: 0x001139B4
		public virtual global::Org.BouncyCastle.Asn1.X509.Target[] GetTargets()
		{
			global::Org.BouncyCastle.Asn1.X509.Target[] result = new global::Org.BouncyCastle.Asn1.X509.Target[this.targets.Count];
			for (int i = 0; i < this.targets.Count; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.X509.Target.GetInstance(this.targets[i]);
			}
			return result;
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x001157FD File Offset: 0x001139FD
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.targets;
		}

		// Token: 0x04001AC8 RID: 6856
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence targets;
	}
}
