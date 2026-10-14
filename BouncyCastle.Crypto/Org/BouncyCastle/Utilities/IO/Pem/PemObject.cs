using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
	// Token: 0x02000059 RID: 89
	public class PemObject : global::Org.BouncyCastle.Utilities.IO.Pem.PemObjectGenerator
	{
		// Token: 0x060003DB RID: 987 RVA: 0x000141A3 File Offset: 0x000123A3
		public PemObject(string type, byte[] content) : this(type, global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(), content)
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000141B2 File Offset: 0x000123B2
		public PemObject(string type, global::System.Collections.IList headers, byte[] content)
		{
			this.type = type;
			this.headers = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(headers);
			this.content = content;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060003DD RID: 989 RVA: 0x000141D4 File Offset: 0x000123D4
		public string Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060003DE RID: 990 RVA: 0x000141DC File Offset: 0x000123DC
		public global::System.Collections.IList Headers
		{
			get
			{
				return this.headers;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060003DF RID: 991 RVA: 0x000141E4 File Offset: 0x000123E4
		public byte[] Content
		{
			get
			{
				return this.content;
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000141EC File Offset: 0x000123EC
		public global::Org.BouncyCastle.Utilities.IO.Pem.PemObject Generate()
		{
			return this;
		}

		// Token: 0x04000281 RID: 641
		private string type;

		// Token: 0x04000282 RID: 642
		private global::System.Collections.IList headers;

		// Token: 0x04000283 RID: 643
		private byte[] content;
	}
}
