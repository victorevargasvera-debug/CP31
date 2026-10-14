using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x02000401 RID: 1025
	public class ParametersWithSalt : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x0600285F RID: 10335 RVA: 0x000AC9C3 File Offset: 0x000AABC3
		public ParametersWithSalt(global::Org.BouncyCastle.Crypto.ICipherParameters parameters, byte[] salt) : this(parameters, salt, 0, salt.Length)
		{
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x000AC9D1 File Offset: 0x000AABD1
		public ParametersWithSalt(global::Org.BouncyCastle.Crypto.ICipherParameters parameters, byte[] salt, int saltOff, int saltLen)
		{
			this.salt = new byte[saltLen];
			this.parameters = parameters;
			global::System.Array.Copy(salt, saltOff, this.salt, 0, saltLen);
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x000AC9FD File Offset: 0x000AABFD
		public byte[] GetSalt()
		{
			return this.salt;
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06002862 RID: 10338 RVA: 0x000ACA05 File Offset: 0x000AAC05
		public global::Org.BouncyCastle.Crypto.ICipherParameters Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x04001062 RID: 4194
		private byte[] salt;

		// Token: 0x04001063 RID: 4195
		private global::Org.BouncyCastle.Crypto.ICipherParameters parameters;
	}
}
