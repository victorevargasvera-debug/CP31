using System;
using System.Collections;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200031D RID: 797
	public class DefaultTlsSrpGroupVerifier : global::Org.BouncyCastle.Crypto.Tls.TlsSrpGroupVerifier
	{
		// Token: 0x0600218B RID: 8587 RVA: 0x00093D44 File Offset: 0x00091F44
		static DefaultTlsSrpGroupVerifier()
		{
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSrpGroupVerifier.DefaultGroups.Add(global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6StandardGroups.rfc5054_1024);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSrpGroupVerifier.DefaultGroups.Add(global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6StandardGroups.rfc5054_1536);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSrpGroupVerifier.DefaultGroups.Add(global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6StandardGroups.rfc5054_2048);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSrpGroupVerifier.DefaultGroups.Add(global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6StandardGroups.rfc5054_3072);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSrpGroupVerifier.DefaultGroups.Add(global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6StandardGroups.rfc5054_4096);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSrpGroupVerifier.DefaultGroups.Add(global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6StandardGroups.rfc5054_6144);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSrpGroupVerifier.DefaultGroups.Add(global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6StandardGroups.rfc5054_8192);
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00093DCB File Offset: 0x00091FCB
		public DefaultTlsSrpGroupVerifier() : this(global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSrpGroupVerifier.DefaultGroups)
		{
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00093DD8 File Offset: 0x00091FD8
		public DefaultTlsSrpGroupVerifier(global::System.Collections.IList groups)
		{
			this.mGroups = groups;
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x00093DE8 File Offset: 0x00091FE8
		public virtual bool Accept(global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters group)
		{
			foreach (object obj in this.mGroups)
			{
				global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters entry = (global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters)obj;
				if (this.AreGroupsEqual(group, entry))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00093E4C File Offset: 0x0009204C
		protected virtual bool AreGroupsEqual(global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters a, global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters b)
		{
			return a == b || (this.AreParametersEqual(a.N, b.N) && this.AreParametersEqual(a.G, b.G));
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x00093E7C File Offset: 0x0009207C
		protected virtual bool AreParametersEqual(global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.BigInteger b)
		{
			return a == b || a.Equals(b);
		}

		// Token: 0x04000CDC RID: 3292
		protected static readonly global::System.Collections.IList DefaultGroups = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x04000CDD RID: 3293
		protected readonly global::System.Collections.IList mGroups;
	}
}
