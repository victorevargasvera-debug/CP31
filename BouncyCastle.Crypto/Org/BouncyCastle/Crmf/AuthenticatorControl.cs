using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Crmf;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x02000507 RID: 1287
	public class AuthenticatorControl : global::Org.BouncyCastle.Crmf.IControl
	{
		// Token: 0x0600325F RID: 12895 RVA: 0x000F1B2A File Offset: 0x000EFD2A
		public AuthenticatorControl(global::Org.BouncyCastle.Asn1.DerUtf8String token)
		{
			this.token = token;
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x000F1B39 File Offset: 0x000EFD39
		public AuthenticatorControl(string token)
		{
			this.token = new global::Org.BouncyCastle.Asn1.DerUtf8String(token);
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06003261 RID: 12897 RVA: 0x000F1B4D File Offset: 0x000EFD4D
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier Type
		{
			get
			{
				return global::Org.BouncyCastle.Crmf.AuthenticatorControl.type;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06003262 RID: 12898 RVA: 0x000F1B54 File Offset: 0x000EFD54
		public global::Org.BouncyCastle.Asn1.Asn1Encodable Value
		{
			get
			{
				return this.token;
			}
		}

		// Token: 0x04001661 RID: 5729
		private static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier type = global::Org.BouncyCastle.Asn1.Crmf.CrmfObjectIdentifiers.id_regCtrl_authenticator;

		// Token: 0x04001662 RID: 5730
		private readonly global::Org.BouncyCastle.Asn1.DerUtf8String token;
	}
}
