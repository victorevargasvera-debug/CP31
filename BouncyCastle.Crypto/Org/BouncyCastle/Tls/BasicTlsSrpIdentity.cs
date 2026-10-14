using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000090 RID: 144
	public class BasicTlsSrpIdentity : global::Org.BouncyCastle.Tls.TlsSrpIdentity
	{
		// Token: 0x06000609 RID: 1545 RVA: 0x000198A8 File Offset: 0x00017AA8
		public BasicTlsSrpIdentity(byte[] identity, byte[] password)
		{
			this.m_identity = global::Org.BouncyCastle.Utilities.Arrays.Clone(identity);
			this.m_password = global::Org.BouncyCastle.Utilities.Arrays.Clone(password);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000198C8 File Offset: 0x00017AC8
		public BasicTlsSrpIdentity(string identity, string password)
		{
			this.m_identity = global::Org.BouncyCastle.Utilities.Strings.ToUtf8ByteArray(identity);
			this.m_password = global::Org.BouncyCastle.Utilities.Strings.ToUtf8ByteArray(password);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000198E8 File Offset: 0x00017AE8
		public virtual byte[] GetSrpIdentity()
		{
			return this.m_identity;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000198F0 File Offset: 0x00017AF0
		public virtual byte[] GetSrpPassword()
		{
			return this.m_password;
		}

		// Token: 0x0400032F RID: 815
		protected readonly byte[] m_identity;

		// Token: 0x04000330 RID: 816
		protected readonly byte[] m_password;
	}
}
