using System;
using System.Collections.Generic;
using Org.BouncyCastle.Crypto.Tls;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x02000011 RID: 17
	internal class TlsAdvPskIdentity : global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentity
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00004B9C File Offset: 0x00002D9C
		public TlsAdvPskIdentity(global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> authenticationMaterials)
		{
			this.a = authenticationMaterials;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004BB8 File Offset: 0x00002DB8
		public void SkipIdentityHint()
		{
			short num = (short)2074148865;
			if (num != 0)
			{
			}
			num = (short)412920468;
			short num2 = num;
			num = (short)142191252;
			switch (num2 == num)
			{
			default:
			{
				num = (short)620625920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1600061440;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004C60 File Offset: 0x00002E60
		public void NotifyIdentityHint(byte[] mIdentity)
		{
			short num = (short)742122594;
			short num2 = num;
			num = (short)1220338786;
			switch (num2 == num)
			{
			}
			num = (short)684589056;
			short num3 = num;
			num = (short)742981633;
			if (num != 0)
			{
			}
			num = (short)532938752;
			if (num != 0)
			{
			}
			this.b = new global::Motorola.Common.Communication.TLS.TlsPskIdentityHint(mIdentity);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004D18 File Offset: 0x00002F18
		public byte[] GetPskIdentity()
		{
			short num = (short)429577805;
			short num2 = num;
			num = (short)1439553101;
			switch (num2 == num)
			{
			}
			num = (short)525795328;
			short num3 = num;
			num = (short)1966735361;
			if (num != 0)
			{
			}
			num = (short)1562050560;
			if (num != 0)
			{
			}
			return this.b.IdentityHint;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004DCC File Offset: 0x00002FCC
		public byte[] GetPsk()
		{
			short num = (short)1794853533;
			short num2 = num;
			num = (short)949766813;
			switch (num2 == num)
			{
			}
			num = (short)1790181376;
			short num3 = num;
			num = (short)1588985857;
			if (num != 0)
			{
			}
			num = (short)1510211584;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.TLS.PreSharedKeysUtilities.GetDerivedKey(this.b.KeyId, this.b.DeviceId, ref this.a);
		}

		// Token: 0x04000020 RID: 32
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> a;

		// Token: 0x04000021 RID: 33
		private global::Motorola.Common.Communication.TLS.TlsPskIdentityHint b;
	}
}
