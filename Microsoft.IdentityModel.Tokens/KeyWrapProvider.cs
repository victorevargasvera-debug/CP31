using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200000D RID: 13
	public abstract class KeyWrapProvider : global::System.IDisposable
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000069 RID: 105
		public abstract string Algorithm { get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006A RID: 106
		// (set) Token: 0x0600006B RID: 107
		public abstract string Context { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006C RID: 108
		public abstract global::Microsoft.IdentityModel.Tokens.SecurityKey Key { get; }

		// Token: 0x0600006D RID: 109 RVA: 0x000043D1 File Offset: 0x000025D1
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600006E RID: 110
		protected abstract void Dispose(bool disposing);

		// Token: 0x0600006F RID: 111
		public abstract byte[] UnwrapKey(byte[] keyBytes);

		// Token: 0x06000070 RID: 112
		public abstract byte[] WrapKey(byte[] keyBytes);
	}
}
