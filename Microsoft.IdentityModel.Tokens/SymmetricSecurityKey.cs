using System;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200003A RID: 58
	public class SymmetricSecurityKey : global::Microsoft.IdentityModel.Tokens.SecurityKey
	{
		// Token: 0x0600018B RID: 395 RVA: 0x00006E54 File Offset: 0x00005054
		public SymmetricSecurityKey(byte[] key)
		{
			if (key == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("key");
			}
			if (key.Length == 0)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException("IDX10703: Cannot create symmetric security key. Key length is zero."));
			}
			this._key = key.CloneByteArray();
			this._keySize = this._key.Length * 8;
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00006EA5 File Offset: 0x000050A5
		public override int KeySize
		{
			get
			{
				return this._keySize;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00006EAD File Offset: 0x000050AD
		public virtual byte[] Key
		{
			get
			{
				return this._key.CloneByteArray();
			}
		}

		// Token: 0x04000162 RID: 354
		private int _keySize;

		// Token: 0x04000163 RID: 355
		private byte[] _key;
	}
}
