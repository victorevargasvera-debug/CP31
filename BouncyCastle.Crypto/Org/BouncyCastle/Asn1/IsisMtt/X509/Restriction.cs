using System;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.IsisMtt.X509
{
	// Token: 0x020006EE RID: 1774
	public class Restriction : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004058 RID: 16472 RVA: 0x001240D0 File Offset: 0x001222D0
		public static global::Org.BouncyCastle.Asn1.IsisMtt.X509.Restriction GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.IsisMtt.X509.Restriction)
			{
				return (global::Org.BouncyCastle.Asn1.IsisMtt.X509.Restriction)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.IAsn1String)
			{
				return new global::Org.BouncyCastle.Asn1.IsisMtt.X509.Restriction(global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(obj));
			}
			throw new global::System.ArgumentException("Unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x0012410F File Offset: 0x0012230F
		private Restriction(global::Org.BouncyCastle.Asn1.X500.DirectoryString restriction)
		{
			this.restriction = restriction;
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x0012411E File Offset: 0x0012231E
		public Restriction(string restriction)
		{
			this.restriction = new global::Org.BouncyCastle.Asn1.X500.DirectoryString(restriction);
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x0600405B RID: 16475 RVA: 0x00124132 File Offset: 0x00122332
		public virtual global::Org.BouncyCastle.Asn1.X500.DirectoryString RestrictionString
		{
			get
			{
				return this.restriction;
			}
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x0012413A File Offset: 0x0012233A
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.restriction.ToAsn1Object();
		}

		// Token: 0x04001E83 RID: 7811
		private readonly global::Org.BouncyCastle.Asn1.X500.DirectoryString restriction;
	}
}
