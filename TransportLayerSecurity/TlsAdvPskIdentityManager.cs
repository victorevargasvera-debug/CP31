using System;
using System.Collections.Generic;
using Org.BouncyCastle.Crypto.Tls;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x02000012 RID: 18
	internal class TlsAdvPskIdentityManager : global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentityManager
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00004E94 File Offset: 0x00003094
		public TlsAdvPskIdentityManager(global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> authenticationMaterials)
		{
			this.a = authenticationMaterials;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004EB0 File Offset: 0x000030B0
		public byte[] GetHint()
		{
			short num = (short)501919842;
			short num2 = num;
			num = (short)1518514274;
			switch (num2 == num)
			{
			}
			num = (short)509935616;
			short num3 = num;
			num = (short)1856897025;
			if (num != 0)
			{
			}
			num = (short)290127872;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004F5C File Offset: 0x0000315C
		public byte[] GetPsk(byte[] identity)
		{
			short num = (short)1953427932;
			short num2 = num;
			num = (short)1281421788;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2028404736;
				short num3 = num;
				num = (short)911540225;
				if (num != 0)
				{
				}
				num = (short)1678573568;
				if (num != 0)
				{
				}
				if (identity == null)
				{
					return null;
				}
				break;
			}
			}
			global::Motorola.Common.Communication.TLS.TlsPskIdentityHint tlsPskIdentityHint = new global::Motorola.Common.Communication.TLS.TlsPskIdentityHint(identity);
			return global::Motorola.Common.Communication.TLS.PreSharedKeysUtilities.GetDerivedKey(tlsPskIdentityHint.KeyId, tlsPskIdentityHint.DeviceId, ref this.a);
		}

		// Token: 0x04000022 RID: 34
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> a;
	}
}
