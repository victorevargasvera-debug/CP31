using System;

namespace Org.BouncyCastle.Asn1.Misc
{
	// Token: 0x020006E2 RID: 1762
	public class VerisignCzagExtension : global::Org.BouncyCastle.Asn1.DerIA5String
	{
		// Token: 0x06004011 RID: 16401 RVA: 0x00122AE8 File Offset: 0x00120CE8
		public VerisignCzagExtension(global::Org.BouncyCastle.Asn1.DerIA5String str) : base(str.GetString())
		{
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x00122AF6 File Offset: 0x00120CF6
		public override string ToString()
		{
			return "VerisignCzagExtension: " + this.GetString();
		}
	}
}
