using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Crmf;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x02000517 RID: 1303
	public class RegTokenControl : global::Org.BouncyCastle.Crmf.IControl
	{
		// Token: 0x060032BD RID: 12989 RVA: 0x000F2B75 File Offset: 0x000F0D75
		public RegTokenControl(global::Org.BouncyCastle.Asn1.DerUtf8String token)
		{
			this.token = token;
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x000F2B84 File Offset: 0x000F0D84
		public RegTokenControl(string token)
		{
			this.token = new global::Org.BouncyCastle.Asn1.DerUtf8String(token);
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060032BF RID: 12991 RVA: 0x000F2B98 File Offset: 0x000F0D98
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier Type
		{
			get
			{
				return global::Org.BouncyCastle.Crmf.RegTokenControl.type;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060032C0 RID: 12992 RVA: 0x000F2B9F File Offset: 0x000F0D9F
		public global::Org.BouncyCastle.Asn1.Asn1Encodable Value
		{
			get
			{
				return this.token;
			}
		}

		// Token: 0x0400168F RID: 5775
		private static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier type = global::Org.BouncyCastle.Asn1.Crmf.CrmfObjectIdentifiers.id_regCtrl_regToken;

		// Token: 0x04001690 RID: 5776
		private readonly global::Org.BouncyCastle.Asn1.DerUtf8String token;
	}
}
