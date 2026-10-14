using System;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200062C RID: 1580
	public class OidTokenizer
	{
		// Token: 0x06003AB9 RID: 15033 RVA: 0x0010F696 File Offset: 0x0010D896
		public OidTokenizer(string oid)
		{
			this.oid = oid;
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06003ABA RID: 15034 RVA: 0x0010F6A5 File Offset: 0x0010D8A5
		public bool HasMoreTokens
		{
			get
			{
				return this.index != -1;
			}
		}

		// Token: 0x06003ABB RID: 15035 RVA: 0x0010F6B4 File Offset: 0x0010D8B4
		public string NextToken()
		{
			if (this.index == -1)
			{
				return null;
			}
			int end = this.oid.IndexOf('.', this.index);
			if (end == -1)
			{
				string result = this.oid.Substring(this.index);
				this.index = -1;
				return result;
			}
			string result2 = this.oid.Substring(this.index, end - this.index);
			this.index = end + 1;
			return result2;
		}

		// Token: 0x040019B9 RID: 6585
		private string oid;

		// Token: 0x040019BA RID: 6586
		private int index;
	}
}
