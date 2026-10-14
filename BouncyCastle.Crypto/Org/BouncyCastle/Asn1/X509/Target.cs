using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200066D RID: 1645
	public class Target : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06003CAE RID: 15534 RVA: 0x0011559A File Offset: 0x0011379A
		public static global::Org.BouncyCastle.Asn1.X509.Target GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.Target)
			{
				return (global::Org.BouncyCastle.Asn1.X509.Target)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.X509.Target((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x001155DC File Offset: 0x001137DC
		private Target(global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagObj)
		{
			global::Org.BouncyCastle.Asn1.X509.Target.Choice tagNo = (global::Org.BouncyCastle.Asn1.X509.Target.Choice)tagObj.TagNo;
			if (tagNo == global::Org.BouncyCastle.Asn1.X509.Target.Choice.Name)
			{
				this.targetName = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(tagObj, true);
				return;
			}
			if (tagNo != global::Org.BouncyCastle.Asn1.X509.Target.Choice.Group)
			{
				throw new global::System.ArgumentException("unknown tag: " + tagObj.TagNo.ToString());
			}
			this.targetGroup = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(tagObj, true);
		}

		// Token: 0x06003CB0 RID: 15536 RVA: 0x00115638 File Offset: 0x00113838
		public Target(global::Org.BouncyCastle.Asn1.X509.Target.Choice type, global::Org.BouncyCastle.Asn1.X509.GeneralName name) : this(new global::Org.BouncyCastle.Asn1.DerTaggedObject((int)type, name))
		{
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06003CB1 RID: 15537 RVA: 0x00115647 File Offset: 0x00113847
		public virtual global::Org.BouncyCastle.Asn1.X509.GeneralName TargetGroup
		{
			get
			{
				return this.targetGroup;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06003CB2 RID: 15538 RVA: 0x0011564F File Offset: 0x0011384F
		public virtual global::Org.BouncyCastle.Asn1.X509.GeneralName TargetName
		{
			get
			{
				return this.targetName;
			}
		}

		// Token: 0x06003CB3 RID: 15539 RVA: 0x00115657 File Offset: 0x00113857
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			if (this.targetName != null)
			{
				return new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, this.targetName);
			}
			return new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 1, this.targetGroup);
		}

		// Token: 0x04001AC5 RID: 6853
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName targetName;

		// Token: 0x04001AC6 RID: 6854
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName targetGroup;

		// Token: 0x02000868 RID: 2152
		public enum Choice
		{
			// Token: 0x040025E2 RID: 9698
			Name,
			// Token: 0x040025E3 RID: 9699
			Group
		}
	}
}
