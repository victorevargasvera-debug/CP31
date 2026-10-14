using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003EF RID: 1007
	public class HkdfParameters : global::Org.BouncyCastle.Crypto.IDerivationParameters
	{
		// Token: 0x0600280B RID: 10251 RVA: 0x000AC204 File Offset: 0x000AA404
		private HkdfParameters(byte[] ikm, bool skip, byte[] salt, byte[] info)
		{
			if (ikm == null)
			{
				throw new global::System.ArgumentNullException("ikm");
			}
			this.ikm = global::Org.BouncyCastle.Utilities.Arrays.Clone(ikm);
			this.skipExpand = skip;
			if (salt == null || salt.Length == 0)
			{
				this.salt = null;
			}
			else
			{
				this.salt = global::Org.BouncyCastle.Utilities.Arrays.Clone(salt);
			}
			if (info == null)
			{
				this.info = new byte[0];
				return;
			}
			this.info = global::Org.BouncyCastle.Utilities.Arrays.Clone(info);
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x000AC272 File Offset: 0x000AA472
		public HkdfParameters(byte[] ikm, byte[] salt, byte[] info) : this(ikm, false, salt, info)
		{
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000AC27E File Offset: 0x000AA47E
		public static global::Org.BouncyCastle.Crypto.Parameters.HkdfParameters SkipExtractParameters(byte[] ikm, byte[] info)
		{
			return new global::Org.BouncyCastle.Crypto.Parameters.HkdfParameters(ikm, true, null, info);
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x000AC289 File Offset: 0x000AA489
		public static global::Org.BouncyCastle.Crypto.Parameters.HkdfParameters DefaultParameters(byte[] ikm)
		{
			return new global::Org.BouncyCastle.Crypto.Parameters.HkdfParameters(ikm, false, null, null);
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x000AC294 File Offset: 0x000AA494
		public virtual byte[] GetIkm()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.ikm);
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06002810 RID: 10256 RVA: 0x000AC2A1 File Offset: 0x000AA4A1
		public virtual bool SkipExtract
		{
			get
			{
				return this.skipExpand;
			}
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x000AC2A9 File Offset: 0x000AA4A9
		public virtual byte[] GetSalt()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.salt);
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x000AC2B6 File Offset: 0x000AA4B6
		public virtual byte[] GetInfo()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.info);
		}

		// Token: 0x04001034 RID: 4148
		private readonly byte[] ikm;

		// Token: 0x04001035 RID: 4149
		private readonly bool skipExpand;

		// Token: 0x04001036 RID: 4150
		private readonly byte[] salt;

		// Token: 0x04001037 RID: 4151
		private readonly byte[] info;
	}
}
