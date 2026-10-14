using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002B5 RID: 693
	public abstract class AsymmetricKeyParameter : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x06001EE9 RID: 7913 RVA: 0x0008F1A5 File Offset: 0x0008D3A5
		protected AsymmetricKeyParameter(bool privateKey)
		{
			this.privateKey = privateKey;
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001EEA RID: 7914 RVA: 0x0008F1B4 File Offset: 0x0008D3B4
		public bool IsPrivate
		{
			get
			{
				return this.privateKey;
			}
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0008F1BC File Offset: 0x0008D3BC
		public override bool Equals(object obj)
		{
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter other = obj as global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter;
			return other != null && this.Equals(other);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0008F1DC File Offset: 0x0008D3DC
		protected bool Equals(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter other)
		{
			return this.privateKey == other.privateKey;
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0008F1EC File Offset: 0x0008D3EC
		public override int GetHashCode()
		{
			return this.privateKey.GetHashCode();
		}

		// Token: 0x04000B1C RID: 2844
		private readonly bool privateKey;
	}
}
