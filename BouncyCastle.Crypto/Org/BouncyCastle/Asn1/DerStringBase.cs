using System;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200061B RID: 1563
	public abstract class DerStringBase : global::Org.BouncyCastle.Asn1.Asn1Object, global::Org.BouncyCastle.Asn1.IAsn1String
	{
		// Token: 0x06003A53 RID: 14931
		public abstract string GetString();

		// Token: 0x06003A54 RID: 14932 RVA: 0x0010E89C File Offset: 0x0010CA9C
		public override string ToString()
		{
			return this.GetString();
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x0010E8A4 File Offset: 0x0010CAA4
		protected override int Asn1GetHashCode()
		{
			return this.GetString().GetHashCode();
		}
	}
}
