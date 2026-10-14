using System;
using System.Collections;
using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000319 RID: 793
	public class DefaultTlsDHVerifier : global::Org.BouncyCastle.Crypto.Tls.TlsDHVerifier
	{
		// Token: 0x06002169 RID: 8553 RVA: 0x0009377C File Offset: 0x0009197C
		private static void AddDefaultGroup(global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters)
		{
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier.DefaultGroups.Add(dhParameters);
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x0009378C File Offset: 0x0009198C
		static DefaultTlsDHVerifier()
		{
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier.AddDefaultGroup(global::Org.BouncyCastle.Crypto.Agreement.DHStandardGroups.rfc7919_ffdhe2048);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier.AddDefaultGroup(global::Org.BouncyCastle.Crypto.Agreement.DHStandardGroups.rfc7919_ffdhe3072);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier.AddDefaultGroup(global::Org.BouncyCastle.Crypto.Agreement.DHStandardGroups.rfc7919_ffdhe4096);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier.AddDefaultGroup(global::Org.BouncyCastle.Crypto.Agreement.DHStandardGroups.rfc7919_ffdhe6144);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier.AddDefaultGroup(global::Org.BouncyCastle.Crypto.Agreement.DHStandardGroups.rfc7919_ffdhe8192);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier.AddDefaultGroup(global::Org.BouncyCastle.Crypto.Agreement.DHStandardGroups.rfc3526_1536);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier.AddDefaultGroup(global::Org.BouncyCastle.Crypto.Agreement.DHStandardGroups.rfc3526_2048);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier.AddDefaultGroup(global::Org.BouncyCastle.Crypto.Agreement.DHStandardGroups.rfc3526_3072);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier.AddDefaultGroup(global::Org.BouncyCastle.Crypto.Agreement.DHStandardGroups.rfc3526_4096);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier.AddDefaultGroup(global::Org.BouncyCastle.Crypto.Agreement.DHStandardGroups.rfc3526_6144);
			global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier.AddDefaultGroup(global::Org.BouncyCastle.Crypto.Agreement.DHStandardGroups.rfc3526_8192);
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x0009381B File Offset: 0x00091A1B
		public DefaultTlsDHVerifier() : this(global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier.DefaultMinimumPrimeBits)
		{
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00093828 File Offset: 0x00091A28
		public DefaultTlsDHVerifier(int minimumPrimeBits) : this(global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier.DefaultGroups, minimumPrimeBits)
		{
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00093836 File Offset: 0x00091A36
		public DefaultTlsDHVerifier(global::System.Collections.IList groups, int minimumPrimeBits)
		{
			this.mGroups = groups;
			this.mMinimumPrimeBits = minimumPrimeBits;
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x0009384C File Offset: 0x00091A4C
		public virtual bool Accept(global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters)
		{
			return this.CheckMinimumPrimeBits(dhParameters) && this.CheckGroup(dhParameters);
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x00093860 File Offset: 0x00091A60
		public virtual int MinimumPrimeBits
		{
			get
			{
				return this.mMinimumPrimeBits;
			}
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00093868 File Offset: 0x00091A68
		protected virtual bool AreGroupsEqual(global::Org.BouncyCastle.Crypto.Parameters.DHParameters a, global::Org.BouncyCastle.Crypto.Parameters.DHParameters b)
		{
			return a == b || (this.AreParametersEqual(a.P, b.P) && this.AreParametersEqual(a.G, b.G));
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00093898 File Offset: 0x00091A98
		protected virtual bool AreParametersEqual(global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.BigInteger b)
		{
			return a == b || a.Equals(b);
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x000938A8 File Offset: 0x00091AA8
		protected virtual bool CheckGroup(global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters)
		{
			foreach (object obj in this.mGroups)
			{
				global::Org.BouncyCastle.Crypto.Parameters.DHParameters group = (global::Org.BouncyCastle.Crypto.Parameters.DHParameters)obj;
				if (this.AreGroupsEqual(dhParameters, group))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x0009390C File Offset: 0x00091B0C
		protected virtual bool CheckMinimumPrimeBits(global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters)
		{
			return dhParameters.P.BitLength >= this.MinimumPrimeBits;
		}

		// Token: 0x04000CD0 RID: 3280
		public static readonly int DefaultMinimumPrimeBits = 2048;

		// Token: 0x04000CD1 RID: 3281
		protected static readonly global::System.Collections.IList DefaultGroups = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x04000CD2 RID: 3282
		protected readonly global::System.Collections.IList mGroups;

		// Token: 0x04000CD3 RID: 3283
		protected readonly int mMinimumPrimeBits;
	}
}
