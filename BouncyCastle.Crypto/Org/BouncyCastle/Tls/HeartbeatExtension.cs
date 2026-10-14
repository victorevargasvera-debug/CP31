using System;
using System.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000CC RID: 204
	public sealed class HeartbeatExtension
	{
		// Token: 0x06000781 RID: 1921 RVA: 0x00020351 File Offset: 0x0001E551
		public HeartbeatExtension(short mode)
		{
			if (!global::Org.BouncyCastle.Tls.HeartbeatMode.IsValid(mode))
			{
				throw new global::System.ArgumentException("not a valid HeartbeatMode value", "mode");
			}
			this.m_mode = mode;
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00020378 File Offset: 0x0001E578
		public short Mode
		{
			get
			{
				return this.m_mode;
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00020380 File Offset: 0x0001E580
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(this.m_mode, output);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0002038E File Offset: 0x0001E58E
		public static global::Org.BouncyCastle.Tls.HeartbeatExtension Parse(global::System.IO.Stream input)
		{
			short num = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			if (!global::Org.BouncyCastle.Tls.HeartbeatMode.IsValid(num))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			return new global::Org.BouncyCastle.Tls.HeartbeatExtension(num);
		}

		// Token: 0x0400058A RID: 1418
		private readonly short m_mode;
	}
}
