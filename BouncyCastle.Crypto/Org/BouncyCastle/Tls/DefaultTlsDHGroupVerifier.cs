using System;
using System.Collections;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000AF RID: 175
	public class DefaultTlsDHGroupVerifier : global::Org.BouncyCastle.Tls.TlsDHGroupVerifier
	{
		// Token: 0x0600069B RID: 1691 RVA: 0x0001B39A File Offset: 0x0001959A
		private static void AddDefaultGroup(global::Org.BouncyCastle.Tls.Crypto.DHGroup dhGroup)
		{
			global::Org.BouncyCastle.Tls.DefaultTlsDHGroupVerifier.DefaultGroups.Add(dhGroup);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0001B3A8 File Offset: 0x000195A8
		static DefaultTlsDHGroupVerifier()
		{
			global::Org.BouncyCastle.Tls.DefaultTlsDHGroupVerifier.AddDefaultGroup(global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc3526_2048);
			global::Org.BouncyCastle.Tls.DefaultTlsDHGroupVerifier.AddDefaultGroup(global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc3526_3072);
			global::Org.BouncyCastle.Tls.DefaultTlsDHGroupVerifier.AddDefaultGroup(global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc3526_4096);
			global::Org.BouncyCastle.Tls.DefaultTlsDHGroupVerifier.AddDefaultGroup(global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc3526_6144);
			global::Org.BouncyCastle.Tls.DefaultTlsDHGroupVerifier.AddDefaultGroup(global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc3526_8192);
			global::Org.BouncyCastle.Tls.DefaultTlsDHGroupVerifier.AddDefaultGroup(global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe2048);
			global::Org.BouncyCastle.Tls.DefaultTlsDHGroupVerifier.AddDefaultGroup(global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe3072);
			global::Org.BouncyCastle.Tls.DefaultTlsDHGroupVerifier.AddDefaultGroup(global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe4096);
			global::Org.BouncyCastle.Tls.DefaultTlsDHGroupVerifier.AddDefaultGroup(global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe6144);
			global::Org.BouncyCastle.Tls.DefaultTlsDHGroupVerifier.AddDefaultGroup(global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe8192);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0001B42D File Offset: 0x0001962D
		public DefaultTlsDHGroupVerifier() : this(global::Org.BouncyCastle.Tls.DefaultTlsDHGroupVerifier.DefaultMinimumPrimeBits)
		{
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0001B43A File Offset: 0x0001963A
		public DefaultTlsDHGroupVerifier(int minimumPrimeBits) : this(global::Org.BouncyCastle.Tls.DefaultTlsDHGroupVerifier.DefaultGroups, minimumPrimeBits)
		{
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0001B448 File Offset: 0x00019648
		public DefaultTlsDHGroupVerifier(global::System.Collections.IList groups, int minimumPrimeBits)
		{
			this.m_groups = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(groups);
			this.m_minimumPrimeBits = minimumPrimeBits;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001B463 File Offset: 0x00019663
		public virtual bool Accept(global::Org.BouncyCastle.Tls.Crypto.DHGroup dhGroup)
		{
			return this.CheckMinimumPrimeBits(dhGroup) && this.CheckGroup(dhGroup);
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0001B477 File Offset: 0x00019677
		public virtual int MinimumPrimeBits
		{
			get
			{
				return this.m_minimumPrimeBits;
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001B47F File Offset: 0x0001967F
		protected virtual bool AreGroupsEqual(global::Org.BouncyCastle.Tls.Crypto.DHGroup a, global::Org.BouncyCastle.Tls.Crypto.DHGroup b)
		{
			return a == b || (this.AreParametersEqual(a.P, b.P) && this.AreParametersEqual(a.G, b.G));
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001B4AF File Offset: 0x000196AF
		protected virtual bool AreParametersEqual(global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.BigInteger b)
		{
			return a == b || a.Equals(b);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001B4C0 File Offset: 0x000196C0
		protected virtual bool CheckGroup(global::Org.BouncyCastle.Tls.Crypto.DHGroup dhGroup)
		{
			foreach (object obj in this.m_groups)
			{
				global::Org.BouncyCastle.Tls.Crypto.DHGroup group = (global::Org.BouncyCastle.Tls.Crypto.DHGroup)obj;
				if (this.AreGroupsEqual(dhGroup, group))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001B524 File Offset: 0x00019724
		protected virtual bool CheckMinimumPrimeBits(global::Org.BouncyCastle.Tls.Crypto.DHGroup dhGroup)
		{
			return dhGroup.P.BitLength >= this.MinimumPrimeBits;
		}

		// Token: 0x040004CA RID: 1226
		public static readonly int DefaultMinimumPrimeBits = 2048;

		// Token: 0x040004CB RID: 1227
		private static readonly global::System.Collections.IList DefaultGroups = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x040004CC RID: 1228
		protected readonly global::System.Collections.IList m_groups;

		// Token: 0x040004CD RID: 1229
		protected readonly int m_minimumPrimeBits;
	}
}
