using System;
using System.Collections;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000B3 RID: 179
	public class DefaultTlsSrpConfigVerifier : global::Org.BouncyCastle.Tls.TlsSrpConfigVerifier
	{
		// Token: 0x060006C2 RID: 1730 RVA: 0x0001B744 File Offset: 0x00019944
		static DefaultTlsSrpConfigVerifier()
		{
			global::Org.BouncyCastle.Tls.DefaultTlsSrpConfigVerifier.DefaultGroups.Add(global::Org.BouncyCastle.Tls.Crypto.Srp6StandardGroups.rfc5054_1024);
			global::Org.BouncyCastle.Tls.DefaultTlsSrpConfigVerifier.DefaultGroups.Add(global::Org.BouncyCastle.Tls.Crypto.Srp6StandardGroups.rfc5054_1536);
			global::Org.BouncyCastle.Tls.DefaultTlsSrpConfigVerifier.DefaultGroups.Add(global::Org.BouncyCastle.Tls.Crypto.Srp6StandardGroups.rfc5054_2048);
			global::Org.BouncyCastle.Tls.DefaultTlsSrpConfigVerifier.DefaultGroups.Add(global::Org.BouncyCastle.Tls.Crypto.Srp6StandardGroups.rfc5054_3072);
			global::Org.BouncyCastle.Tls.DefaultTlsSrpConfigVerifier.DefaultGroups.Add(global::Org.BouncyCastle.Tls.Crypto.Srp6StandardGroups.rfc5054_4096);
			global::Org.BouncyCastle.Tls.DefaultTlsSrpConfigVerifier.DefaultGroups.Add(global::Org.BouncyCastle.Tls.Crypto.Srp6StandardGroups.rfc5054_6144);
			global::Org.BouncyCastle.Tls.DefaultTlsSrpConfigVerifier.DefaultGroups.Add(global::Org.BouncyCastle.Tls.Crypto.Srp6StandardGroups.rfc5054_8192);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0001B7CB File Offset: 0x000199CB
		public DefaultTlsSrpConfigVerifier() : this(global::Org.BouncyCastle.Tls.DefaultTlsSrpConfigVerifier.DefaultGroups)
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0001B7D8 File Offset: 0x000199D8
		public DefaultTlsSrpConfigVerifier(global::System.Collections.IList groups)
		{
			this.m_groups = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(groups);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001B7EC File Offset: 0x000199EC
		public virtual bool Accept(global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig srpConfig)
		{
			foreach (object obj in this.m_groups)
			{
				global::Org.BouncyCastle.Tls.Crypto.Srp6Group group = (global::Org.BouncyCastle.Tls.Crypto.Srp6Group)obj;
				if (this.AreGroupsEqual(srpConfig, group))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0001B850 File Offset: 0x00019A50
		protected virtual bool AreGroupsEqual(global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig a, global::Org.BouncyCastle.Tls.Crypto.Srp6Group b)
		{
			global::Org.BouncyCastle.Math.BigInteger[] ng = a.GetExplicitNG();
			return this.AreParametersEqual(ng[0], b.N) && this.AreParametersEqual(ng[1], b.G);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0001B886 File Offset: 0x00019A86
		protected virtual bool AreParametersEqual(global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.BigInteger b)
		{
			return a == b || a.Equals(b);
		}

		// Token: 0x040004D2 RID: 1234
		private static readonly global::System.Collections.IList DefaultGroups = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x040004D3 RID: 1235
		protected readonly global::System.Collections.IList m_groups;
	}
}
