using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200066E RID: 1646
	public class TargetInformation : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003CB4 RID: 15540 RVA: 0x0011567C File Offset: 0x0011387C
		public static global::Org.BouncyCastle.Asn1.X509.TargetInformation GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.TargetInformation)
			{
				return (global::Org.BouncyCastle.Asn1.X509.TargetInformation)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.TargetInformation((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x001156BB File Offset: 0x001138BB
		private TargetInformation(global::Org.BouncyCastle.Asn1.Asn1Sequence targets)
		{
			this.targets = targets;
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x001156CC File Offset: 0x001138CC
		public virtual global::Org.BouncyCastle.Asn1.X509.Targets[] GetTargetsObjects()
		{
			global::Org.BouncyCastle.Asn1.X509.Targets[] result = new global::Org.BouncyCastle.Asn1.X509.Targets[this.targets.Count];
			for (int i = 0; i < this.targets.Count; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.X509.Targets.GetInstance(this.targets[i]);
			}
			return result;
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x00115715 File Offset: 0x00113915
		public TargetInformation(global::Org.BouncyCastle.Asn1.X509.Targets targets)
		{
			this.targets = new global::Org.BouncyCastle.Asn1.DerSequence(targets);
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x00115729 File Offset: 0x00113929
		public TargetInformation(global::Org.BouncyCastle.Asn1.X509.Target[] targets) : this(new global::Org.BouncyCastle.Asn1.X509.Targets(targets))
		{
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x00115737 File Offset: 0x00113937
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.targets;
		}

		// Token: 0x04001AC7 RID: 6855
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence targets;
	}
}
