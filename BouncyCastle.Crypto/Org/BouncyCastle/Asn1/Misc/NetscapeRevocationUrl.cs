using System;

namespace Org.BouncyCastle.Asn1.Misc
{
	// Token: 0x020006E1 RID: 1761
	public class NetscapeRevocationUrl : global::Org.BouncyCastle.Asn1.DerIA5String
	{
		// Token: 0x0600400F RID: 16399 RVA: 0x00122AC8 File Offset: 0x00120CC8
		public NetscapeRevocationUrl(global::Org.BouncyCastle.Asn1.DerIA5String str) : base(str.GetString())
		{
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x00122AD6 File Offset: 0x00120CD6
		public override string ToString()
		{
			return "NetscapeRevocationUrl: " + this.GetString();
		}
	}
}
