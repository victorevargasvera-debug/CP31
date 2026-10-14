using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000531 RID: 1329
	public class CmsProcessableByteArray : global::Org.BouncyCastle.Cms.CmsProcessable, global::Org.BouncyCastle.Cms.CmsReadable
	{
		// Token: 0x0600334A RID: 13130 RVA: 0x000F4A1F File Offset: 0x000F2C1F
		public CmsProcessableByteArray(byte[] bytes)
		{
			this.type = global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.Data;
			this.bytes = bytes;
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x000F4A39 File Offset: 0x000F2C39
		public CmsProcessableByteArray(global::Org.BouncyCastle.Asn1.DerObjectIdentifier type, byte[] bytes)
		{
			this.bytes = bytes;
			this.type = type;
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x0600334C RID: 13132 RVA: 0x000F4A4F File Offset: 0x000F2C4F
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x000F4A57 File Offset: 0x000F2C57
		public virtual global::System.IO.Stream GetInputStream()
		{
			return new global::System.IO.MemoryStream(this.bytes, false);
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x000F4A65 File Offset: 0x000F2C65
		public virtual void Write(global::System.IO.Stream zOut)
		{
			zOut.Write(this.bytes, 0, this.bytes.Length);
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x000F4A7C File Offset: 0x000F2C7C
		[global::System.Obsolete]
		public virtual object GetContent()
		{
			return this.bytes.Clone();
		}

		// Token: 0x040016E6 RID: 5862
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier type;

		// Token: 0x040016E7 RID: 5863
		private readonly byte[] bytes;
	}
}
