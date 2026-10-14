using System;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000334 RID: 820
	public class HeartbeatExtension
	{
		// Token: 0x0600222A RID: 8746 RVA: 0x00097608 File Offset: 0x00095808
		public HeartbeatExtension(byte mode)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.HeartbeatMode.IsValid(mode))
			{
				throw new global::System.ArgumentException("not a valid HeartbeatMode value", "mode");
			}
			this.mMode = mode;
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x0009762F File Offset: 0x0009582F
		public virtual byte Mode
		{
			get
			{
				return this.mMode;
			}
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x00097637 File Offset: 0x00095837
		public virtual void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(this.mMode, output);
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x00097645 File Offset: 0x00095845
		public static global::Org.BouncyCastle.Crypto.Tls.HeartbeatExtension Parse(global::System.IO.Stream input)
		{
			byte b = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input);
			if (!global::Org.BouncyCastle.Crypto.Tls.HeartbeatMode.IsValid(b))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			return new global::Org.BouncyCastle.Crypto.Tls.HeartbeatExtension(b);
		}

		// Token: 0x04000D78 RID: 3448
		protected readonly byte mMode;
	}
}
